using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ResumeBuilder.Exporters
{
    public class PDFExporter : IExporter
    {
        private readonly string _folder = "exports";

        public PDFExporter()
        {
            if (!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }
        }

public void Export(Resume resume, string fileName = null)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            fileName ??= $"resume_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string path = Path.Combine(_folder, fileName);
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Content().Column(col =>
                    {
                        col.Item().PaddingVertical(10).PaddingHorizontal(200).Text($"📄 RESUME").FontSize(15).Bold();
                        col.Item().Text($"Name  : {resume.Name}");
                        col.Item().Text($"Email : {resume.Email}");
                        if (!string.IsNullOrWhiteSpace(resume.Phone))
                            col.Item().Text($"Phone : {resume.Phone}");

                        if (!string.IsNullOrWhiteSpace(resume.Summary))
                        {
                            col.Item().PaddingVertical(10).Text("Summary:").Bold();
                            col.Item().Text(resume.Summary);
                        }

                        if (resume.Skills.Any())
                        {
                            col.Item().PaddingVertical(10).Text("Skills:").Bold();
                            foreach (var skill in resume.Skills)
                                col.Item().Text($"- {skill}");
                        }

                        if (resume.Education.Any())
                        {
                            col.Item().PaddingVertical(10).Text("Education:").Bold();
                            foreach (var edu in resume.Education)
                                col.Item().Text($"- {edu}");
                        }

                        if (resume.Experience.Any())
                        {
                            col.Item().PaddingVertical(10).Text("Experience:").Bold();
                            foreach (var exp in resume.Experience)
                                col.Item().Text($"- {exp}");
                        }
                    });
                });
            }).GeneratePdf(path);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"📄 Resume exported to: {path}");
            Console.ResetColor();
        }    }
}