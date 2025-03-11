
using Basket.API.Data;

namespace Basket.API.Basket.GetBasket
{
    public record GetBasketQuery(string UserName) : Iquery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);
    public class GetBasketHandlercs(IBasketRepository repository) : IqueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            var basket = await repository.GetBasket(query.UserName);
            return new GetBasketResult(basket);
        }
    }
}
