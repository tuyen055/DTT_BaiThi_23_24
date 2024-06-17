using Microsoft.EntityFrameworkCore;

namespace DTT_BaiThi_23_24.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions options) : base(options) {}
    }
}