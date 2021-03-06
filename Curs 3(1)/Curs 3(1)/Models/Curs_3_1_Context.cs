﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Curs_3_1_.Models
{
    public class Curs_3_1_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Curs_3_1_Context() : base("name=Curs_3_1_Context")//va lua constr din clasa de baza, ne config in web config iar el va face conex cu baza de date
        {

        }

        public System.Data.Entity.DbSet<Curs_3_1_.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Curs_3_1_.Models.Order> Orders { get; set; }
    }
}
