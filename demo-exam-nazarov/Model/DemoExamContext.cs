using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace demo_exam_nazarov.Model;

public partial class DemoExamContext : DbContext
{
    public DbSet<Agent> Agents { get; set; }
    public DbSet<AgentType> AgentsTypes { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialSupplier> MaterialSuppliers { get; set; }
    public DbSet<MaterialType> MaterialTypes { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

    public DemoExamContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;user=root;password=;database=;",
            new MySqlServerVersion(new Version(8, 0, 44)));
    }
}
