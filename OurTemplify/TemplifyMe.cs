using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OurTemplify
{
    public class TemplifyMe
    {
        public static string[] FolderExclusions { get; set; }
        public static string[] FileExclusions { get; set; }
        public static string[] GlobalExtensionExclusions { get; set; }
        public static string[] TokenExtensionExclusions { get; set; }

        public static void Start(string sourceFolderPath, string targetFolderPath, string oldPattern, string newPattern, StatusStrip statusStrip)
        {
            DateTime startDate = DateTime.Now;

            TemplifyFolder(sourceFolderPath, targetFolderPath, oldPattern, newPattern, statusStrip);

            TimeSpan processTime = DateTime.Now.Subtract(startDate);
            statusStrip.Items["lblFile"].Text = "Listo";
            MessageBox.Show($"Operacion finalizada.", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void TemplifyFolder(string sourceFolderPath, string targetFolderPath, string oldPattern, string newPattern, StatusStrip statusStrip)
        {

            string[] exclusions = FolderExclusions;
            Directory.CreateDirectory(targetFolderPath);

            foreach (string subFolderName in Directory.GetDirectories(sourceFolderPath).Select(c => c.Split('\\').Last()))
            {
                if (!exclusions.Contains(subFolderName.ToLower()))
                {
                    string newFolderPath = Path.Combine(targetFolderPath, subFolderName.Replace(oldPattern, newPattern));
                    TemplifyFolder(Path.Combine(sourceFolderPath, subFolderName), newFolderPath, oldPattern, newPattern, statusStrip);
                }
            }

            TemplifyFiles(sourceFolderPath, targetFolderPath, oldPattern, newPattern, statusStrip);

        }

        public static void TemplifyFiles(string sourceFolderPath, string targetFolderPath, string oldPattern, string newPattern, StatusStrip statusStrip)
        {

            string[] fileNameExclusions = FileExclusions,
                globalExtensionExclusions = GlobalExtensionExclusions,
                tokenExtensionExclusions = TokenExtensionExclusions;

            foreach (string fileName in Directory.GetFiles(sourceFolderPath).Select(c => Path.GetFileName(c)))
            {

                string fileExtension = Path.GetExtension(fileName).ToLower();

                if (!fileNameExclusions.Contains(fileName.ToLower()) && !globalExtensionExclusions.Contains(fileExtension))
                {

                    string targetFilePath = Path.Combine(targetFolderPath, fileName.Replace(oldPattern, newPattern));
                    statusStrip.Items["lblFile"].Text = $"Templificando: {fileName}";
                    File.Copy(Path.Combine(sourceFolderPath, fileName), targetFilePath);
                    File.SetAttributes(targetFilePath, FileAttributes.Normal);

                    if (!tokenExtensionExclusions.Contains(fileExtension))
                        File.WriteAllText(targetFilePath, File.ReadAllText(targetFilePath).Replace(oldPattern, newPattern));

                }

            }

        }
    }
}
