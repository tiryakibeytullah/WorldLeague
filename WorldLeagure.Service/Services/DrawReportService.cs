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
    }
}
