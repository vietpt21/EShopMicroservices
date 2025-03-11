using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface IqueryHandler< in TQuery, TResponse> : IRequestHandler<TQuery,TResponse> 
        where TResponse : notnull
        where TQuery : Iquery<TResponse>
    {
    }
}
