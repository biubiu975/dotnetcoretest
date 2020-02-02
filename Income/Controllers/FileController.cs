using System;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using Demo2.Data.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Demo2.Models;
using Demo2.Models.Entity;
using Demo2.Models.Requst;

namespace Demo2.Controllers
{
    public class FileController : BaseController
    {
        private readonly IHostingEnvironment IHE;
        private IFileRepository FileRes;

        [HttpPost]
        public JsonResult UploadFiles()
        {
            try
            {
                var files = Request.Form.Files;
                //StringBuilder stringBuilder = new StringBuilder();
                var rootPath = IHE.WebRootPath + "/file";
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }

                var dateDir = DateTime.Now.ToString("yyyyMMdd");
                var datePath = rootPath + "/" + dateDir;
                if (!Directory.Exists(datePath))
                {
                    Directory.CreateDirectory(datePath);
                }

                var path = Path.Combine();
                foreach (var file in files)
                {
                    var fileType = file.ContentType;
                    var type = fileType.Substring(fileType.IndexOf("/") + 1);
                    var newFileName = Guid.NewGuid().ToString("D") + "." + type;
                    var filePath = datePath + "/" + newFileName;
                    FileStream fileStream = new FileStream(filePath,FileMode.Create);
                    file.CopyToAsync(fileStream);

                    UploadFile up_file = new UploadFile
                    {
                        Type = fileType,
                        Name = file.FileName,
                        FilePath = "/file/" + dateDir + "/" + newFileName,
                        DataName = newFileName,
                        Code = Guid.NewGuid().ToString("D"),
                        UniqueCode = CurrentUser("code2").UniqueCode,
                        FileHash = "adsfa",
                    };

                    if (FileRes.AddEntity(up_file))
                    {
                        return Json(ApiResponse.Success("文件上传成功", new{up_file.Code, up_file.FilePath}));
                    }
                    else
                    {
                        return Json(ApiResponse.Fail("文件上传失败"));
                    }
                }

                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器发生错误"));
            }
        }


        public FileController(IHostingEnvironment IHE, IFileRepository FileRes,IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
            this.IHE = IHE;
            this.FileRes = FileRes;
        }
    }
}