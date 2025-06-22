using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder
{
    public class Resume
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; } = new();
        public List<string> Education { get; set; } = new();
        public List<string> Experience { get; set; } = new();


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"        Resume");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Phone: {Phone}");
            sb.AppendLine($"Address: {Address}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"Summary: {Summary}");
            if (Skills.Any())
            {
                sb.AppendLine($"Skills:");
                foreach (var skill in Skills)
                {
                    sb.AppendLine($"- {skill}");
                }
            }
            if (Education.Any())
            {
                sb.AppendLine("Education");
                foreach (var edu in Education)
                {
                    sb.AppendLine($"- {edu}");

                }
            }
            if (Experience.Any())
            {
                sb.AppendLine("Experience:");
                foreach (var exp in Experience)
                {
                    sb.AppendLine($"- {exp}");
                }
            }
            return sb.ToString();
        }
    }

}