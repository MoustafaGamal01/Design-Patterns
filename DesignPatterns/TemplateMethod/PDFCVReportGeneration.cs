using DesignPatterns.TemplateMethod.Interfaces;
using DesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Formats.Tar;

namespace DesignPatterns.TemplateMethod
{
    public class PDFCVReportGeneration : ICVReportGeneration
    {
        protected override FileData ExtractText(TheFile file)
        {
            Console.WriteLine("Extracting text from PDF file...");
            return new FileData();
        }
    }
}
