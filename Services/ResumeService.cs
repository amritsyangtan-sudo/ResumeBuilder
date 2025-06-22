using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeBuilder.Exporters;

namespace ResumeBuilder.Services
{
    public class ResumeService
    {
        private readonly IExporter _exporter;

        public ResumeService(IExporter exporter)
        {
            _exporter = exporter;
        }

        public void Generate(Resume resume)
        {
            if (resume == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Resume is null. Cannot export.");
                Console.ResetColor();
                return;
            }
            string fileName = $"{resume.Name}_resume_{DateTime.Now:yyyymmdd_hhmmss}.pdf";
            _exporter.Export(resume, fileName);
        }
    }
}