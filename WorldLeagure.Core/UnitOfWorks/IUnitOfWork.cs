using WorldLeagure.Core.Repositories.Country;
using WorldLeagure.Core.Repositories.DrawReport;
using WorldLeagure.Core.Repositories.Group;
using WorldLeagure.Core.Repositories.Team;

namespace WorldLeagure.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IDrawReportReadRepository DrawReportReadRepository { get; }
        IDrawReportWriteRepository DrawReportWriteRepository { get; }
        IGroupReadRepository GroupReadRepository { get; }
        IGroupWriteRepository GroupWriteRepository { get; }
        ITeamReadRepository TeamReadRepository { get; }
        ITeamWriteRepository TeamWriteRepository { get; }
        ICountryReadRepository CountryReadRepository { get; }
        ICountryWriteRepository CountryWriteRepository { get; }
        Task CommitAsync();
        void Commit();
    }
}
