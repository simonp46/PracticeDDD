using Microsoft.EntityFrameworkCore;

namespace PracticeDDD.Infraestructure
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext>)
        {

        }
        public int MyProperty { get; set; }

    }
}