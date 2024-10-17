﻿using DesignPatterns.TemplateMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class WordCVReportGeneration : ICVReportGeneration
    {
        protected override FileData ExtractText(TheFile file)
        {
            Console.WriteLine("Extracting text from Word file...");
            return new FileData();
        }
    }
}
