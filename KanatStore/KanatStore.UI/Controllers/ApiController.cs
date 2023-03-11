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
            string fileName = System.IO.Path.GetFileName(file.FileName);
            fileName = Models.Utility.GetHrefParam(fileName);
            using (System.IO.FileStream stream = new System.IO.FileStream(System.IO.Path.Combine(path, fileName), System.IO.FileMode.Create))
            {
                file.CopyTo(stream);
                uploadedFiles.Add(fileName);
            }
            string webPath = "/uploads/" + subFolder + "/" + fileName;

            return "{\"status\":1,\"url\":\"" + webPath + "\"}";
        }
    }
}
