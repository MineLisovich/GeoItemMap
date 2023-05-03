using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoItemMap.DataBase.Repositories.Abstract;

namespace GeoItemMap.DataBase
{
    public class DataManager
    {
        public IGeoItem GeoItem { get; set; }

        public DataManager(IGeoItem geoItem)
        {
            GeoItem=geoItem;
        }
    }
}
