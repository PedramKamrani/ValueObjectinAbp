using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        private readonly ContextDB _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ContextDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //List<string> roles =new  List<string>();
            //var rolename = _context.Users.Where(c=>c.Id==2).Include(c => c.UserRoles).
            //    ThenInclude(c => c.Role);
            //Console.WriteLine(rolename);
            //foreach (var user in rolename)
            //{
            //   var res= user.UserRoles.Select(c => c.Role.Name).ToList();
            //    roles.AddRange(res);
            //}
            //var b = roles;
            //var ba = "";
            
            
            //var result = _context.Users.Where(c => c.Id == 1)
            //     .Include(c => c.UserRoles)
            //    .SingleOrDefault();
            //foreach (var item in result.UserRoles)
            //{
            //    var rolename = _context.UserRoles
            //        .Include(c => c.Role)
            //        .Where(x => x.RoleId == item.RoleId)
            //        .Select(c=>c.Role.Name).ToList();
               
            //}

            //    var roleName = _context.UserRoles.Include(x => x.Role)
            //       .Where(x => x.RoleId == item.Id)
            //       .ToList();
            //foreach ()
            //{

            //}

            List<string> list = new List<string>(); 
            var role=_context.Users.Where(x=>x.Id==2)
                .Include(x=>x.UserRoles)
                .ThenInclude(c=>c.Role);
            foreach (var item in role)
            {
                var rolename = item.UserRoles.Select(c => c.Role.Name);
                list.AddRange(rolename);
            }

            var b = list;
            var name = "";
            // var name = roleName.Role.Name;
            return View(name);

        }

        //return View();
    }
}
