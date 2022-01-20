using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoBaseDeDatos
{
    public class Post
    {
        public int ID { get; set; }
        public DateTime fecha_de_publicación { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }

    }
    public class blogDbContext: DbContext
    {
        public DbSet<Post> posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
