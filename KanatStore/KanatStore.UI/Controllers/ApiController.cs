using KanatStore.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Hosting;
using KanatStore.UI.Models;

namespace KanatStore.UI.Controllers
{
    public class ApiController : Controller
    {
        public KanatStoreDBContext _context = null;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;

        public ApiController(KanatStoreDBContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpPost]
        public string Upload(IFormFile file)
        {
            string subFolder = DateTime.Now.ToString("yyyy/MM");
            string path = _env.WebRootPath + "/uploads/" + subFolder;

            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            // string msg = "";
            // foreach (IFormFile postedFile in postedFiles)
            // {
            string fileName = System.IO.Path.GetFileName(file.FileName);
            fileName = Models.Utility.GetHrefParam(fileName);
            using (System.IO.FileStream stream = new System.IO.FileStream(System.IO.Path.Combine(path, fileName), System.IO.FileMode.Create))
            {
                file.CopyTo(stream);
                uploadedFiles.Add(fileName);
                // msg += fileName;
            }
            // }

            string webPath = "/uploads/" + subFolder + "/" + fileName;

            return "{\"status\":1,\"url\":\"" + webPath + "\"}";
        }

        //[HttpPost]
        //public bool SubcribeEmail(string requestEmail)
        //{
        //    bool res = true;

        //    if (!string.IsNullOrWhiteSpace(requestEmail))
        //    {
        //        try
        //        {
        //            var res_email = _context.Emails.FirstOrDefault(x => x.Email == requestEmail);
        //            if (res_email != null)
        //            {
        //                if (res_email.DeletedFlag == 1)
        //                {
        //                    res_email.DeletedFlag = 0;
        //                    res_email.UpdatedAt = DateTime.Now;
        //                    _context.Emails.Update(res_email);
        //                    _context.SaveChanges();
        //                }
        //                else
        //                {
        //                    res = false;
        //                    return res;
        //                }
        //            }
        //            else
        //            {
        //                var email = new Emails
        //                {
        //                    Email = requestEmail,
        //                    DeletedFlag = 0,
        //                    CreatedAt = DateTime.Now,
        //                    UpdatedAt = DateTime.Now
        //                };
        //                _context.Emails.Add(email);
        //                _context.SaveChanges();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            res = false;
        //            return res;
        //        }
        //    }
        //    else
        //    {
        //        res = false;
        //        return res;
        //    }
        //    return res;
        //}

        //[HttpPost]
        //public bool UnSubcribeEmail(string requestEmail)
        //{
        //    bool res = true;

        //    if (!string.IsNullOrWhiteSpace(requestEmail))
        //    {
        //        var emails = _context.Emails.FirstOrDefault(x => x.Email == requestEmail);
        //        if (emails != null)
        //        {
        //            emails.DeletedFlag = 1;
        //            emails.UpdatedAt = DateTime.Now;
        //            _context.Emails.Update(emails);
        //            _context.SaveChanges();
        //        }
        //        else
        //        {
        //            res = false;
        //        }
        //    }
        //    return res;
        //}
    }
}
