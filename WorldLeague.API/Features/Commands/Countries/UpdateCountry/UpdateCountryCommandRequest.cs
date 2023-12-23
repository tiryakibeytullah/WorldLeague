using MediatR;

namespace WorldLeague.API.Features.Commands.Countries.UpdateCountry
{
    public class UpdateCountryCommandRequest : IRequest<UpdateCountryCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
