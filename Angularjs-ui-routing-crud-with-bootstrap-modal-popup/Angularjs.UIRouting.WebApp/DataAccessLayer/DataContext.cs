using Angularjs.UIRouting.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Angularjs.UIRouting.WebApp.DataAccessLayer
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DefaultConnection")
        {
            Database.SetInitializer<DataContext>
                (new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }

    
}