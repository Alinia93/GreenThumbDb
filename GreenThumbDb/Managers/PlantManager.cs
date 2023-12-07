using GreenThumbDb.DataBase;
using GreenThumbDb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


        public static string GetInfoPlant(Plant plant)
        {

            StringBuilder plantInfo = new();

            plantInfo.Append($"Name: {plant.EnglishName}. Botanical name: {plant.BotanicalName}. Color: {plant.Color}. Plant family:{plant.Family}");

            List<Instruction> instructions = plant.Instructions.ToList();

            if (instructions != null)
            {
                foreach (Instruction instruction in instructions)
                {
                    plantInfo.Append($"Instructions: {instruction.Name}. Description: {instruction.Description}");
                }

            }
            return plantInfo.ToString();
        }
    }
}
