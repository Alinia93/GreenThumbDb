using GreenThumbDb.DataBase;
using GreenThumbDb.Models;
using System.Linq;

namespace GreenThumbDb.Managers
{
    public static class PlantManager
    {

        public static Plant SearchForPlant(string plantName)
        {
            using (AppDbContext context = new())
            {
                var plant = context.Plants.FirstOrDefault(p => p.EnglishName == plantName || p.BotanicalName == plantName);
                if (plant != null)
                {
                    return plant;
                }
                else
                {
                    return null!;
                }
            }
        }


    }
}
