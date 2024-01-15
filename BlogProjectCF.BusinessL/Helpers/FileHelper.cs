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

                // wwwroot klasörüne dosya kaydetme
                string webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                webRootPath = webRootPath.Replace("\\", "/"); // Gerekirse

                string savePathInWwwRoot = $"{webRootPath}/{savePath}";

                // Dizin yoksa oluştur
                if (!Directory.Exists(savePathInWwwRoot))
                    Directory.CreateDirectory(savePathInWwwRoot);

                string filePath = $"{savePathInWwwRoot}/{file.FileName}";

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }

                return file.FileName;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

        }
    }
}
