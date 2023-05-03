using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DataBase.Entities
{
    public class GeoItem
    {
        public int Id { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public string Description { get; set; }
    }
}
