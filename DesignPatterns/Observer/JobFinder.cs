using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class JobFinder
    {
        private string JobTitle { get;  }
        private string JobDescription { get; }


        public JobFinder(string jobTitle, string jobDescription)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
        }

        public string GetJobName()
        {
            return JobTitle;
        }

        public string GetJobDescription()
        {
            return JobDescription;
        }
    }
}
