using MVCLOGIN.DbEF;
using MVCLOGIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLOGIN.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ProjectDbContext db1 = new ProjectDbContext();
        public ActionResult Index()
        {
            return View();
        }
        //HTTP get/ Home/DangKy
        public ActionResult Dangky()
        {
            return View();
        }
        //HTTP Post /Home/DangKy
        [HttpPost]
        public ActionResult Dangky(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("DangNhap");
        }
        //HTTP get/ Home/DangNhap
        public ActionResult DangNhap()
        {
            return View();
        }
        //HTTP Post /Home/DangNhap
        [HttpPost]
        public ActionResult DangNhap(User user)
        {
            var taikhoanForm = user.TaiKhoan;
            var matkhauForm = user.MatKhau;
            var userCheck = db.Users.SingleOrDefault(x => x.TaiKhoan.Equals(taikhoanForm) && x.MatKhau.Equals(matkhauForm));
            if(userCheck != null) 
            {
                Session["User"] = userCheck;
                return RedirectToAction("Index", "Home");
            }else
            {
                ViewBag.LoginFail = "Đăng nhập thất bại, vui lòng  kt lại!";
                return View("DangNhap");
            }    
            
        }
        public ActionResult DangXuat()
        {
            Session["User"] = null;
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List(int page = 1, int pageSize = 1)//int page = 1, int pageSize = 1
        {
            //return View(db1.Customers.ToList());
            var model = new Model1();
            var usemod = model.ListAllPaging(page, pageSize);
            return View(usemod);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var customer = new Model1().GetID(id);
            return View(customer);
        }
        [HttpPost] //, ActionName("Edit")
        [ValidateAntiForgeryToken]
        public ActionResult Update(Customer collection)
        {


            // TODO: Add update logic here
            if (ModelState.IsValid)
            {
                var customer = new Model1();
                var result = customer.UpdateCustomer(collection);
                if (result)
                    return RedirectToAction("List","Home");
                else
                {
                    ModelState.AddModelError("", "Thêm mới không thành công.");
                }
            }

            return View("List");
        }
    }
}