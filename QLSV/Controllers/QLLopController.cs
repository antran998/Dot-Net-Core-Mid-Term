using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Models;

namespace QLSV.Controllers
{
    public class QLLopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QLLopController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("QLLop")]
        public async Task<IActionResult> QLLop()
        {
            var lophp = await _context.LopHocPhan.Include(x=>x.Sinhvien).ToListAsync();
            return View(lophp);
        }
    }
}