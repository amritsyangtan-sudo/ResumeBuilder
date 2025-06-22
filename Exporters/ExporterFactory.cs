using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Exporters
{
    public class ExporterFactory
    {
        public static IExporter Create(string type)
        {
            return type.ToLower() switch
            {
                "text" => new TxtExporter(),
                "pdf" => new PDFExporter(),
                _ => throw new NotSupportedException($"Exporter type {type} not supoprted.")
            };
        }
    }
}