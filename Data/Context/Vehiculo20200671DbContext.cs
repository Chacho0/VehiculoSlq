using Vehiculo20200671.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculo20200671.Data.Context;

 public class Vehiculo20200671DbContext:DbContext
 {
     public Vehiculo20200671DbContext(DbContextOptions options):base(options)
    {
        
    }

public virtual DbSet<vehiculo> Vehiculos {get; set;} = null!;
public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
 }
 public interface Vehiculo20200671
 {
   public DbSet<vehiculo> vehiculos {get; set;}
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
 }