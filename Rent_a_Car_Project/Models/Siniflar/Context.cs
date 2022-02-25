using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rent_a_Car_Project.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Cars> cars { get; set; }
        public DbSet<Admin> admins { get; set; }


    }
}