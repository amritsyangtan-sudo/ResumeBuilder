<div align="center">

# 📄 GoF Design Patterns — via ResumeBuilder

**A C# console application that demonstrates GOF of design patterns**  
**through the practical context of building and exporting a resume.**

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Type](https://img.shields.io/badge/Type-Console%20App-blue?style=for-the-badge)
![Patterns](https://img.shields.io/badge/GoF%20Patterns-Factory%20%7C%20Strategy%20%7C%20Builder-orange?style=for-the-badge)

> A hands-on learning project — **design patterns applied to a real, coherent domain**  
</div>

## ✅ What It Does

ResumeBuilder is a console application that:

1. Collects resume data from the user via the console (`ResumeInputService`)
2. Builds a structured `Resume` domain model
3. Selects the appropriate exporter using a **Factory** (`ExporterFactory`)
4. Generates the final resume output via a **Strategy interface** (`IExporter`)

Currently exports to **PDF** — designed to easily support additional formats (Markdown, Word, JSON) by adding new exporters without touching existing code.

---

## 🧩 Design Patterns Used

| Pattern | Category | Where Applied |
|---|---|---|
| **Factory** | Creational | `ExporterFactory.Create("pdf")` — decouples exporter creation from usage |
| **Strategy** | Behavioral | `IExporter` interface — swap export formats without changing `ResumeService` |
| **Builder** *(implicit)* | Creational | `ResumeInputService` constructs a `Resume` object step by step |
| **Service Layer** | Architectural | `ResumeService` orchestrates the build + export pipeline |

### Factory Pattern — Exporter Selection

```csharp
// Caller doesn't need to know which concrete exporter is used
IExporter exporter = ExporterFactory.Create("pdf");
```

Adding a new format (e.g. `"markdown"`) only requires a new class implementing `IExporter`  
and a single new case in the factory — zero changes to `ResumeService` or `Program.cs`.

### Strategy Pattern — IExporter Interface

```csharp
// ResumeService works against the abstraction, not the concrete type
var service = new ResumeService(exporter);
service.Generate(resume);
```

---

## ⚙️ How It Works

```
┌─────────────────────────┐
│       Program.cs        │
│  (Entry point / Wiring) │
└────────┬────────────────┘
         │
         ▼
┌─────────────────────────┐
│   ResumeInputService    │  Prompts user → builds Resume domain object
└────────┬────────────────┘
         │  Resume
         ▼
┌─────────────────────────┐
│    ExporterFactory      │  .Create("pdf") → returns IExporter
└────────┬────────────────┘
         │  IExporter
         ▼
┌─────────────────────────┐
│      ResumeService      │  .Generate(resume) → delegates to exporter
└────────┬────────────────┘
         │
         ▼
┌─────────────────────────┐
│      PdfExporter        │  Writes resume to /exports/
└─────────────────────────┘
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)

### Clone & Run

```bash
git clone https://github.com/amritsyangtan-sudo/ResumeBuilder.git
cd ResumeBuilder
dotnet run
```

Follow the console prompts to enter resume details. The generated file will appear in the `exports/` folder.

### Build Only

```bash
dotnet build
```
---

<div align="center">

*Part of a personal C# learning journey — GoF patterns grounded in real domains.*

</div>
