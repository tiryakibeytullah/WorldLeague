namespace WorldLeagure.Core.Repositories.Group
{
    public interface IGroupReadRepository : IReadRepository<WorldLeagure.Core.Entities.Group>
    {
        Task<bool> CheckGroupAsync(Guid id);
    }
}
