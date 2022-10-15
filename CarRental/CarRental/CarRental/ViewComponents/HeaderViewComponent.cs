﻿using CarRental.DAL;
using CarRental.Models;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HeaderVM header = new HeaderVM();

            header.User = new User();

            if (User.Identity.IsAuthenticated)
            {
                header.User =await _userManager.FindByNameAsync(User.Identity.Name);
            }


            return View(header);
        }



    }
}
