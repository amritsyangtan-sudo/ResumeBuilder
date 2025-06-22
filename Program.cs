using ResumeBuilder;

var resume = new ResumeBuilder.ResumeBuilder()
.SetName("Amrit Syangtan")
.SetPhone("9860104625")
.SetAddress("Kathmandu, balaju")
.SetEmail("amritsyangtan1@gmail.com")
.SetSummary("C# Developer")
.Build();

Console.WriteLine(resume.ToString());
