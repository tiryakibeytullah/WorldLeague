using Microsoft.EntityFrameworkCore;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Repositories;
using WorldLeagure.Core.Services;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Core.ViewModels;
using WorldLeagure.Service.HelperClasses;
using WorldLeagure.Service.Services.Common;

namespace WorldLeagure.Service.Services
{
    public class DrawReportService : BaseService<DrawReport>, IDrawReportService
    {
        public DrawReportService(IWriteRepository<DrawReport> writeRepository, IReadRepository<DrawReport> readRepository, IUnitOfWork unitOfWork) : base(writeRepository, readRepository, unitOfWork)
        {

        }

        public async Task<List<DrawReportViewModel>> GetListByUserAsync(string firstName, string surname)
        {
            List<DrawReport> drawReports = await (_unitOfWork.DrawReportReadRepository.GetWithNavigationProperties())
                .Where(d => d.Firstname.ToLower() == firstName.ToLower() && d.Surname.ToLower() == d.Surname.ToLower())
                .ToListAsync();

            IEnumerable<IGrouping<Group, DrawReport>> grouping = drawReports.GroupBy(d => d.Group);
            List<DrawReportViewModel> drawReportViewModels = grouping.Select(d => new DrawReportViewModel
            {
                Group = d.Key,
                Teams = drawReports.Where(y => y.GroupId == d.Key.Id).Select(y => y.Team).ToList()
            }).ToList();

            return drawReportViewModels;
        }


        public async Task<List<DrawReportViewModel>> DrawLotsAsync(int groupCount, string firstName, string surname)
        {
            List<Group> groups = await (_unitOfWork.GroupReadRepository.GetAll()).ToListAsync();
            List<Country> countriesWithNavigation = await _unitOfWork.CountryReadRepository.GetWithNavigationPropertiesAsync();

            Dictionary<Country, List<Team>> countriesWithTeams = new Dictionary<Country, List<Team>>();
            foreach (Country country in countriesWithNavigation)
                countriesWithTeams.Add(country, country.Teams.ToList());

            //Kura sonuçları
            List<DrawReportViewModel> drawLosts = PlaceTeams.CreateDrawLost(countriesWithTeams, groups, groupCount);

            //Kura sonuçlarının database'e kayıt edilmesi
            List<DrawReport> drawReports = new List<DrawReport>();
            foreach (var item in drawLosts)
            {
                drawReports.AddRange(item.Teams.Select(x => new DrawReport()
                {
                    Firstname = firstName,
                    Surname = surname,
                    GroupId = item.Group.Id,
                    TeamId = x.Id
                }).ToList());
            }

            await _unitOfWork.DrawReportWriteRepository.AddRangeAsync(drawReports);
            await _unitOfWork.CommitAsync();

            return drawLosts;
        }

        public async Task RemoveRangeAsync(string firstName, string surname)
        {
            List<DrawReport> drawReports = await (_unitOfWork.DrawReportReadRepository.GetAll())
                 .Where(d => d.Firstname.ToLower() == firstName.ToLower() && d.Surname.ToLower() == d.Surname.ToLower()).ToListAsync();

            foreach (var drawReport in drawReports)
            {
                drawReport.IsDeleted = true;
                drawReport.UpdatedDate = DateTime.Now;
            }

            _unitOfWork.DrawReportWriteRepository.UpdateRange(drawReports);
            await _unitOfWork.CommitAsync();
        }
    }
}
