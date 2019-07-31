using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ECommerce.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadProvince()
        {
            var xmlDoc = XDocument.Load(Server.MapPath(@"~/Assets/data/DVHC_data.xml"));
            var xElement = xmlDoc.Element("DonViHanhChinhVietNam").
                Elements("DVHC").Elements("Cap").Where(x => x.Value.Equals("TINH"));
            var provinceModels = new List<ProvinceModel>();
            ProvinceModel province = null;
            foreach (var item in xElement)
            {
                province = new ProvinceModel();
                province.ProvinceID = item.Parent.Element("MaDVHC").Value;
                province.ProvinceName = item.Parent.Element("Ten").Value;
                provinceModels.Add(province);
            }
            return Json(new
            {
                 data = provinceModels,
                 status = true
            });
        }

        [AllowAnonymous]
        public ActionResult Demo()
        {
            return View();
        }
    }
}