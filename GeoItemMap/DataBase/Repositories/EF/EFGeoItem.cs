using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeoItemMap.DataBase.Entities;
using GeoItemMap.DataBase.Repositories.Abstract;

namespace GeoItemMap.DataBase.Repositories.EF
{
    public class EFGeoItem : IGeoItem
    {
        private readonly AppDbContext context;
        public EFGeoItem(AppDbContext context)
        {
            this.context = context;
        }
        public async Task <IEnumerable<GeoItem>> GetAllItem()
        {
            return await context.GeoItems.ToListAsync();
        }

        public void SaveGeoItem(GeoItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public void DeleteGeoItem(int id)
        {

            context.GeoItems.Remove(new GeoItem() { Id = id });
            context.SaveChanges();
         
        }
    }
}
