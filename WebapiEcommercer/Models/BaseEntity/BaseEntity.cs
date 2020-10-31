using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WebapiEcommercer.Models.BaseEntity
{
    [DataContract]
    public class BaseEntity
    {
        public int? Id { get; set; }
    }
}
