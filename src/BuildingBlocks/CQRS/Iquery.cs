using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    public interface Iquery<out TResponse>: IRequest<TResponse> where TResponse : notnull
    {
    }
}
