using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP1_Resto.Models;

namespace TP1_Resto.Views
{
    public class RestDbConext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Plat> Plats { get; set; }

        //Change la chaine de connexion pour lancer la bd
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DevLogTP4;Trusted_Connection=true;TrustServerCertificate=true;");
	}
}
