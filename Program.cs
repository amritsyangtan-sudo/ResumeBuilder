using resumebuilder.Services;
using ResumeBuilder;
using ResumeBuilder.Exporters;
using ResumeBuilder.Services;

var inputService = new ResumeInputService();
Resume resume = inputService.GetResumeFromConsole();
IExporter exporter = ExporterFactory.Create("pdf");
var service = new ResumeService(exporter);
service.Generate(resume);