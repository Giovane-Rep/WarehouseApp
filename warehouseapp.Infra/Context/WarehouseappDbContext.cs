using Microsoft.EntityFrameworkCore;

namespace warehouseapp.Infra.Context {
    public class WarehouseappDbContext : DbContext {
        public WarehouseappDbContext(DbContextOptions<WarehouseappDbContext> options) : base(options) {

        }
    }
}
