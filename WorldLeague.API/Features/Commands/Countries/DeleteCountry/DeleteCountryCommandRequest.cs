using MediatR;

namespace WorldLeague.API.Features.Commands.Countries.DeleteCountry
{
    public class DeleteCountryCommandRequest : IRequest<DeleteCountryCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
