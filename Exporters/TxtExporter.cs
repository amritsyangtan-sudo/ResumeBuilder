using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ResumeBuilder.Exporters
{
    public class TxtExporter : IExporter
    {
        private readonly string _folder = "exports";
        public TxtExporter()
        {
            if (!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }
        }
        public void Export(Resume resume, string fileName = null)
        {
            if (resume == null)

                throw new ArgumentException(nameof(resume));
            

                fileName ??= $"resume_{DateTime.Now:yyyymmdd_hhmmss}.txt";
                string path = Path.Combine(_folder, fileName);
                File.WriteAllText(path, resume.ToString());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Resume exported to: {path}");
                Console.ResetColor();

        }
    }
}