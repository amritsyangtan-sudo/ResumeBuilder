using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeBuilder;

namespace resumebuilder.Services
{
    public class ResumeInputService
    {
       public Resume GetResumeFromConsole()
        {
            var builder = new ResumeBuilder.ResumeBuilder();

            Console.Write("Enter Name: ");
            builder.SetName(Console.ReadLine());

            Console.Write("Enter Email: ");
            builder.SetEmail(Console.ReadLine());

            Console.Write("Enter Phone: ");
            builder.SetPhone(Console.ReadLine());

            Console.Write("Enter Summary: ");
            builder.SetSummary(Console.ReadLine());

            Console.WriteLine("Enter Skills (comma-separated): ");
            var skills = Console.ReadLine().Split(',');
            foreach (var skill in skills)
                builder.SetSkills(skill.Trim());

            Console.WriteLine("Enter Education (comma-separated): ");
            var education = Console.ReadLine().Split(',');
            foreach (var edu in education)
                builder.SetEducation(edu.Trim());

            Console.WriteLine("Enter Experience (comma-separated): ");
            var exp = Console.ReadLine().Split(',');
            foreach (var item in exp)
                builder.SetExperience(item.Trim());

            return builder.Build();
        } 
    }
}