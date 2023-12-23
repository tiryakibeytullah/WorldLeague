using MediatR;

namespace WorldLeague.API.Features.Queries.Countries.GetByIdCountry
{
    public class GetByIdCountryQueryRequest : IRequest<GetByIdCountryQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
