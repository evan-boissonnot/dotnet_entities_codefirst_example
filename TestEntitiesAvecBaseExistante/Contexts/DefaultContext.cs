using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestEntitiesAvecBaseExistante.Contexts
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        public DefaultContext()
        {
        }

        public DbSet<Models.Paragraphe> Paragraphes { get; set; }
    }
}
