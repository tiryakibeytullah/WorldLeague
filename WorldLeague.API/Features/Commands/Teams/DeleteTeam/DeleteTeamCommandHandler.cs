using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Teams.DeleteTeam
{
    public class DeleteTeamCommandHandler : IRequestHandler<DeleteTeamCommandRequest, DeleteTeamCommandResponse>
    {
        private readonly ITeamService _teamService;

        public DeleteTeamCommandHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<DeleteTeamCommandResponse> Handle(DeleteTeamCommandRequest request, CancellationToken cancellationToken)
        {
            Team team = await _teamService.GetByIdAsync(request.Id);
            if (team != null)
            {
                _teamService.Remove(team);
                return new();
            }
            else
                throw new NotFoundException();
        }
    }
}
