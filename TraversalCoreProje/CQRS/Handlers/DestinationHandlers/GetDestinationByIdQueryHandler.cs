using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var result = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = result.DestinationId,
                City = result.City,
                Daynight = result.DayNight,
                Price = result.Price,
            };
        }
    }
}
