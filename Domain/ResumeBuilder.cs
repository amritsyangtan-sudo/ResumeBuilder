using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder
{
    public class ResumeBuilder
    {
        private readonly Resume _resume = new();

        public ResumeBuilder SetName(string name)
        {
            _resume.Name = name;
            return this;
        }

        public ResumeBuilder SetPhone(string phone)
        {
            _resume.Phone = phone;
            return this;
        }

        public ResumeBuilder SetAddress(string address)
        {
            _resume.Address = address;
            return this;
        }

        public ResumeBuilder SetEmail(string email)
        {
            _resume.Email = email;
            return this;
        }

        public ResumeBuilder SetSummary(string summary)
        {
            _resume.Summary = summary;
            return this;
        }

        public ResumeBuilder SetSkills(string skills)
        {
            _resume.Skills.Add(skills);
            return this;
        }

        public ResumeBuilder SetEducation(string education)
        {
            _resume.Education.Add(education);
            return this;
        }

        public ResumeBuilder SetExperience(string experience)
        {
            _resume.Experience.Add(experience);
            return this;
        }

        public Resume Build()
        {
            return _resume;
        }
        
    }
}