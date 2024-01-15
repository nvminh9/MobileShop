using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MobileShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #region DbSet
        public DbSet<THANHVIEN> THANHVIENs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<QUYEN> QUYENs { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPs { get;set; }
        public DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public DbSet<LOAITHANHVIEN_QUYEN> LOAITHANHVIEN_QUYENs { get; set; }
        public DbSet<LOAITHANHVIEN> LOAITHANHVIENs { get; set; }
        public DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public DbSet<KHUYENMAI> KHUYENMAIs {  get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public DbSet<CHITIETSANPHAM> CHITIETSANPHAMs { get; set; }
        public DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public DbSet<CHITIETDONDATHANG> CHITIETDONDATHANGs { get; set; }
        public DbSet<BINHLUAN> BINHLUANs { get; set; }
        #endregion

    }
}
