using MediatR;
using WorldLeague.API.Exceptions;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.Services;

namespace WorldLeague.API.Features.Commands.Countries.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommandRequest, DeleteCountryCommandResponse>
    {
        private readonly ICountryService _countryService;

        public DeleteCountryCommandHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<DeleteCountryCommandResponse> Handle(DeleteCountryCommandRequest request, CancellationToken cancellationToken)
        {
            Country country = await _countryService.GetByIdAsync(request.Id);
            if (country != null)
            {
                _countryService.Remove(country);
                return new();
            }
            else
                throw new NotFoundException();
        }
    }
}
