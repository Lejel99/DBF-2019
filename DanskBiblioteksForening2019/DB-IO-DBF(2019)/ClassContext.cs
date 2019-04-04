using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using REPO_DBF_2019_;

namespace DB_IO_DBF_2019_
{
    public class ClassContext : DbContext
    {
        //これは何ですか?
        public ClassContext() : base(@"Data Source=CV-BB-5300;Initial Catalog=EntityDbf_2019; Integrated Security=True")
        {
            Database.SetInitializer<ClassContext>(new CreateDatabaseIfNotExists<ClassContext>());
        }

        public DbSet<ClassBog> Bog { get; set; }

        public DbSet<ClassAuthor> Author { get; set; }

        public DbSet<ClassGenre> Genre { get; set; }
        
        public DbSet<ClassISBN> ISBN { get; set; }

        public DbSet<ClassPublisher> Publisher { get; set; }

        public DbSet<ClassTitle> Title { get; set; }

        public DbSet<ClassType> Type { get; set; }
        
        public DbSet<ClassPerson> Person { get; set; }

        public DbSet<Classudlaan> udlaan { get; set; }

        public DbSet<ClassUser> Access { get; set; }
    }
}
