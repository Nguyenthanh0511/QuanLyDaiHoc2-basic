using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using QuanLyDaiHoc.Models;

namespace QuanLyDaiHoc.Controllers
{
    public class GiamHieuxController : Controller
    {
        private readonly QuanLyDaiHoc2Context _context;
        public GiamHieuxController(QuanLyDaiHoc2Context context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            return _context.GiamHieus != null ?
            View(await _context.GiamHieus.ToListAsync()) :
            Problem("Entity set ' QuanLyDaiHoc2Context.GiamHieux'is null. ");
        }
    }
}
