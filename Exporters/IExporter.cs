using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Exporters
{
    public interface IExporter
    {
        void Export(Resume resume, string fileName = null);
    }
}