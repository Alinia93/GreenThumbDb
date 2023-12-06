using GreenThumbDb.DataBase;
using GreenThumbDb.Models;

namespace GreenThumbDb.Repository
{
    public class UnitOfWorkRepository
    {
        private readonly AppDbContext _context;

        public GenericRepository<Garden> GardenRepository { get; }
        public GenericRepository<GardenPlants> GardenPlantsRepository { get; }
        public GenericRepository<Instruction> InstructionRepository { get; }
        public GenericRepository<Plant> PlantRepository { get; }
        public GenericRepository<User> UserRepository { get; }

        public UnitOfWorkRepository(AppDbContext context)
        {
            _context = context;
            GardenRepository = new(context);
            GardenPlantsRepository = new(context);
            InstructionRepository = new(context);
            PlantRepository = new(context);
            UserRepository = new(context);

        }


        public void Complete()
        {
            _context.SaveChanges();
        }



    }
}
