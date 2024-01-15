using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Data;
using MobileShop.Models;

namespace MobileShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSanPhamsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public LoaiSanPhamsController(ApplicationDbContext context) {
            _context = context;
        }

        //Lay danh sach loai san pham
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _context.LOAISANPHAMs.ToList();    
            return Ok(dsLoai);
        }

        //Lay loai san pham theo id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loai = _context.LOAISANPHAMs.SingleOrDefault(lo => lo.MaLSP == id);
            if (loai != null)
            {
                return Ok(loai);
            }
            else
            {
                return NotFound();
            }
        }

        //Them loai san pham
        [HttpPost]
        public IActionResult CreateNew(LOAISANPHAMModel model)
        {
            try
            {
                var loai = new LOAISANPHAM
                {
                    TenL = model.TenL,
                    Icon = model.Icon,
                    BiDanh = model.BiDanh
                };
                _context.Add(model);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Cap nhat loai san pham 
        [HttpPut("{id}")]
        public IActionResult UpdateLoaiById(int id, LOAISANPHAMModel model)
        {
            var loai = _context.LOAISANPHAMs.SingleOrDefault(lo => lo.MaLSP == id);
            if (loai != null)
            {
                loai .TenL = model.TenL;
                loai.Icon = model.Icon;
                loai.BiDanh = model.BiDanh;
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
