using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DtoMappers
{
    public interface IEntityMapper<TSource, TDestination>
    {
        TSource CreateFrom(TDestination destination);
        TDestination MapTo(TSource source);
    }
}
