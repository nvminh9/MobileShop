using System.ComponentModel.DataAnnotations;

namespace MobileShop.Models
{
    public class LOAISANPHAMModel
    {
        [MaxLength(10)]
        public string? TenL { get; set; }
        public string? Icon { get; set; }
        [MaxLength(50)]
        public string? BiDanh { get; set; }
    }
}
