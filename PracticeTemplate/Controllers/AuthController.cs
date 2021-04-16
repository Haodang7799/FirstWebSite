using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeTemplate.Data;
using PracticeTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace PracticeTemplate.Controllers
{
    public class AuthController : Controller
    {
        private readonly PracticeTemplateDBContext _context;

        public AuthController(PracticeTemplateDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Username,Password")] LoginUser request)
        {
          
                if (request.Username == "admin" && request.Password == "12345")
                {
                return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
                
            
        }
        public async Task<IActionResult> Tables()
        {
            return View(await _context.salaryTables.ToListAsync());
        }
        
    }
}