using MediatR;

namespace WorldLeague.API.Features.Commands.Countries.CreateCountry
{
    public class CreateCountryCommandRequest : IRequest<CreateCountryCommandResponse>
    {
        public string Name { get; set; }
    }
}
