using S3Train.Contract;
using S3Train.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.PerfumShop.Areas.Admin.Models;

namespace Web.PerfumShop.Areas.Admin.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        // GET: Vendor
        public ActionResult VendorHome()
        {
            var models = GetVendors(_vendorService.SelectAll());
            return View(models);
        }

        private static IList<VendorViewModel> GetVendors(IList<Vendor> vendors)
        {
            return vendors.Select(x => new VendorViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}