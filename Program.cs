using ResumeBuilder;
using ResumeBuilder.Exporters;
using ResumeBuilder.Services;

var resume = new ResumeBuilder.ResumeBuilder()
.SetName("Amrit Syangtan")
.SetPhone("9860104625")
.SetAddress("Kathmandu, balaju")
.SetEmail("amritsyangtan1@gmail.com")
.SetSummary("C# Developer")
.SetSkills("C#")
.SetSkills("Libre Office Macro Programming")
.SetSkills("Python")
.SetEducation("BSCIT")
.SetExperience("MixERP open source project")
.SetExperience("Network Settlement")
.Build();

Console.WriteLine(resume.ToString());

IExporter exporter = ExporterFactory.Create("pdf");
var service = new ResumeService(exporter);
service.Generate(resume);