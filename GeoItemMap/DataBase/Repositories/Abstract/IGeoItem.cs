using GeoItemMap.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DataBase.Repositories.Abstract
{
    public interface IGeoItem
    {
        Task  <IEnumerable<GeoItem>> GetAllItem();

        void SaveGeoItem(GeoItem entity);
        void DeleteGeoItem(int id);
    }
}
