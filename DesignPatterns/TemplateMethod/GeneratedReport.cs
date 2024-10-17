namespace DesignPatterns.TemplateMethod
{
    public class GeneratedReport
    {
        private bool isPassed { get; }

        public GeneratedReport(bool isPassed)
        {
            this.isPassed = isPassed;
        }

        public bool IsPassed()
        {
            return isPassed;
        }
    }
}