
using Marten.Pagination;

namespace Catalog.Api.Products.GetProduct
{
    public record GetProductQuery(int? PageNumber = 1, int? PageSize = 10) : Iquery<GetProductResult>;
    public record GetProductResult(IEnumerable<Product> Products);
    public class GetProductHandler(IDocumentSession session, ILogger<GetProductHandler> logger) :
        IqueryHandler<GetProductQuery, GetProductResult>
    {
        public async Task<GetProductResult> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
           
            var products = await session.Query<Product>().ToPagedListAsync(query.PageNumber ?? 1, query.PageSize ?? 10, (cancellationToken));
            return new GetProductResult(products);

        }
    }
}
