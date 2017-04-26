using skool.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace skool.DAL
{
public class SchoolContext : DbContext
{
public SchoolContext() : base("SchoolContext")
{
}

public DbSet<Student> Students { get; set; }
public DbSet<Teacher> Teachers { get; set; }
public DbSet<Subject> Subjects { get; set; }
public DbSet<Notices> Notices { get; set; }

public DbSet<useraccount> useraccount { get; set; }

protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
}

public System.Data.Entity.DbSet<skool.Models.Parent> Parents { get; set; }

public System.Data.Entity.DbSet<skool.Models.AccountViewModels> AccountViewModels { get; set; }
}
}