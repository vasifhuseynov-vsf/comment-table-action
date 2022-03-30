﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using RentCar.Models.Entities;
using RentCar.Models.ViewModels;
using RentCar.Models.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public CarController(AppDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        //***** Detail *****//
        public async Task<IActionResult> Detail(int id)
        {
            var car = await _dbContext.CarModels
                .Include(c => c.Car)
                .Include(c => c.District).ThenInclude(d => d.City)
                .Include(c => c.CarImages)
                .FirstOrDefaultAsync(c => c.Id == id);

            return View(new CarDetailViewModel { 
                CarModel = car
            });
        }

        //***** Comment *****//
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Comment(CreateCommentViewModel model)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);

            Comment comment = new Comment
            {
                UserName = user.UserName,
                CarModelId = model.CarModelId,
                Text = model.Text
            };

            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Detail), "Room", new { id = model.CarModelId });
        }
    }
}
