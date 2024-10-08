﻿using DrugStore_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugStore_Web.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DrugStoreDBContext _context = new DrugStoreDBContext();

        [Route("LienHe")]
        public ActionResult Contact()
        {
            return View();
        }
        
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(TinNhanLienHe tinnhan)
        {
            if (ModelState.IsValid) 
            {
                tinnhan.ThoiGian = DateTime.Now;
                _context.TinNhanLienHes.Add(tinnhan);
                _context.SaveChanges();
                
                TempData["SuccessMessage"] = "PharmaVillage ghi nhận phản hồi!";
                // Chuyển hướng đến trang thành công
                return RedirectToAction("Contact");
            }

            return View(tinnhan);
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult GoogleMapLocations()
        {
            return View();
        }
        public ActionResult FAQ()
        {

            return View();
        }
        
    }
}