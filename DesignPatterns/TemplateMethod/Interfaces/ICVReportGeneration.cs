using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Interfaces
{
    public abstract class ICVReportGeneration
    {
        private AnalyzedData AnalyzedData(FileData fileData)
        {
            Console.WriteLine("Analyzing data ...");
            return new AnalyzedData();
        }

        protected abstract FileData ExtractText(TheFile file);

        public GeneratedReport GenerateReport(string cvFilePath)
        {
            var file = ReadFile(cvFilePath);
            var extractedData = ExtractText(file);
            var analyzedData = AnalyzedData(extractedData);
            return GeneratedReport(analyzedData);
        }

        private GeneratedReport GeneratedReport(AnalyzedData analyzedData)
        {
            Console.WriteLine("Generating data ...");
            return new GeneratedReport(true);
        }

        private TheFile ReadFile(string filePath)
        {
            Console.WriteLine("Reading file from path: " + filePath);
            return new TheFile();
        }
    }
}
