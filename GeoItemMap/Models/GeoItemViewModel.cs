using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoItemMap.DataBase.Entities;

namespace GeoItemMap.Models
{
    public class GeoItemViewModel
    {
        public IEnumerable<GeoItem> GeoItems { get; set; }
    }
}
