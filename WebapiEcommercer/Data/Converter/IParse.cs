using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Data.Converter
{
    public interface IParse<O, D>
    {
        D Parse(O origin);
        List<D> ParseList(List<O> origin);
    }
}
