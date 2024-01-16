using Microsoft.AspNetCore.Http;

namespace BlogProjectCF.BusinessL.Helpers
{
    public static class FileHelper
    {
        public static string SaveFile(IFormFile file, string savePath)
        {
            try
            {
                if (file == null || file.Length == 0)
                    return "FileSaveError";


                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                webRootPath = webRootPath.Replace("\\", "/");
                Guid guid = Guid.NewGuid();
                string savePathInWwwRoot = $"{webRootPath}/{savePath}";
                // Dizin yoksa oluştur
                if (!Directory.Exists(savePathInWwwRoot))
                    Directory.CreateDirectory(savePathInWwwRoot);

                string fileName = $"{guid}{Path.GetExtension(file.FileName)}";

                string filePath = $"{savePathInWwwRoot}/{fileName}";

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }

                return fileName;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

        }

        public static bool DeleteFile(string path)
        {
            string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            webRootPath = webRootPath.Replace("\\", "/");
            try
            {
                File.Delete(webRootPath + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File Cannot Be Deleted! Error Message: {ex.Message}");
                return false;
            }

            return true;
        }
    }
}
