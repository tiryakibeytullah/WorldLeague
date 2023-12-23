using WorldLeagure.Core.Repositories.Country;
using WorldLeagure.Core.Repositories.DrawReport;
using WorldLeagure.Core.Repositories.Group;
using WorldLeagure.Core.Repositories.Team;
using WorldLeagure.Core.UnitOfWorks;
using WorldLeagure.Repository.Repositories.Country;
using WorldLeagure.Repository.Repositories.DrawReport;
using WorldLeagure.Repository.Repositories.Group;
using WorldLeagure.Repository.Repositories.Team;

namespace WorldLeagure.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WorldLeagueDbContext _worldLeagueDbContext;
        private DrawReportReadRepository _drawReportReadRepository;
        private DrawReportWriteRepository _drawReportWriteRepository;
        private GroupReadRepository _groupReadRepository;
        private GroupWriteRepository _groupWriteRepository;
        private TeamReadRepository _teamReadRepository;
        private TeamWriteRepository _teamWriteRepository;
        private CountryReadRepository _countryReadRepository;
        private CountryWriteRepository _countryWriteRepository;

        public UnitOfWork(WorldLeagueDbContext worldLeagueDbContext)
        {
            this._worldLeagueDbContext = worldLeagueDbContext;
        }


        public IDrawReportReadRepository DrawReportReadRepository => _drawReportReadRepository ?? new DrawReportReadRepository(_worldLeagueDbContext);

        public IDrawReportWriteRepository DrawReportWriteRepository => _drawReportWriteRepository ?? new DrawReportWriteRepository(_worldLeagueDbContext);

        public IGroupReadRepository GroupReadRepository => _groupReadRepository ?? new GroupReadRepository(_worldLeagueDbContext);

        public IGroupWriteRepository GroupWriteRepository => _groupWriteRepository ?? new GroupWriteRepository(_worldLeagueDbContext);

        public ITeamReadRepository TeamReadRepository => _teamReadRepository ?? new TeamReadRepository(_worldLeagueDbContext);

        public ITeamWriteRepository TeamWriteRepository => _teamWriteRepository ?? new TeamWriteRepository(_worldLeagueDbContext);

        public ICountryReadRepository CountryReadRepository => _countryReadRepository ?? new CountryReadRepository(_worldLeagueDbContext);

        public ICountryWriteRepository CountryWriteRepository => _countryWriteRepository ?? new CountryWriteRepository(_worldLeagueDbContext);

        public void Commit()
        {
            _worldLeagueDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _worldLeagueDbContext.SaveChangesAsync();
        }
    }
}
