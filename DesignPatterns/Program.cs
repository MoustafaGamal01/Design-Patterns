using DesignPatterns.Strategy.Interfaces;
using DesignPatterns.Strategy;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using DesignPatterns.TemplateMethod.Interfaces;
using DesignPatterns.TemplateMethod;
using DesignPatterns.Memento;
using DesignPatterns.Visitor.Interfaces;
using DesignPatterns.Visitor;

class Program
{
    static void Main(string[] args)
    {
        #region StrategyPatternTesting
        //PaymentProcessor paymentProcessor = new PaymentProcessor(new VisaPaymentStrategy());
        //Order order = new Order();

        //paymentProcessor.ProcessOrderPayment(order);
        #endregion

        #region Observer
        //OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();

        //ISubscriber Ahmed = new SubscriberOp("Ahmed");
        //ISubscriber Mohamed = new SubscriberOp("Mohamed");
        //ISubscriber Youssef = new SubscriberOp ("Youssef");
        //ISubscriber Moustafa = new SubscriberOp("Moustafa");


        //onlineMarketPlace.Subscribe(EventType.ProductAdded, Ahmed);
        //onlineMarketPlace.Subscribe(EventType.ProductAdded, Mohamed);
        //onlineMarketPlace.Subscribe(EventType.OfferAdded, Ahmed);
        //onlineMarketPlace.Subscribe(EventType.OfferAdded, Youssef);
        //onlineMarketPlace.Subscribe(EventType.JobOpening, Moustafa);



        //onlineMarketPlace.AddOffer(new Offer("20% Discount Now! "));
        //onlineMarketPlace.AddProduct(new Product { name = "Mobile", price = 10000 });
        //onlineMarketPlace.AddJob(new JobFinder("Software Engineer", "C# Developer ")); 
        #endregion

        #region Strategy
        //Product Laptob = new Product("Laptob", 10000, new RegularPricingStrategy());
        //Console.WriteLine(Laptob.CalculatePrice());

        //Product Wallet = new Product("Wallet", 10000, new GoldPricingStrategy());
        //Console.WriteLine(Wallet.CalculatePrice());

        //Product Mobile = new Product("Mobile", 10000, new PremiumPricingStrategy());
        //Console.WriteLine(Mobile.CalculatePrice());

        //Product DellLaptob = new Product("DellLaptob", 10000, new BankAccountPricingStrategy());
        //Console.WriteLine(DellLaptob.CalculatePrice());

        //var paypalCheckout = new Checkout(new DesignPatterns.Strategy.PaypalPaymentStrategy());
        //paypalCheckout.ProcessPayment(Laptob.GetPrice());

        //var NewPaymentCheckout = new Checkout(new DesignPatterns.Strategy.NewPaymentMethodStrategy());
        //NewPaymentCheckout.ProcessPayment(DellLaptob.GetPrice());

        //var mastercardCheckout = new Checkout(new DesignPatterns.Strategy.MastercardPaymentStrategy());
        //mastercardCheckout.ProcessPayment(Mobile.GetPrice());

        //var visaCheckout = new Checkout(new DesignPatterns.Strategy.VisaPaymentStrategy());
        //visaCheckout.ProcessPayment(Wallet.GetPrice());
        #endregion

        #region TemplateMethod

        //ICVReportGeneration pdfGenerationReport = new PDFCVReportGeneration();
        //var generatedPDFRepot = pdfGenerationReport.GenerateReport("/gemy/Desktop/CV.pdf");
        //Console.WriteLine("Generated PDF Report: " + generatedPDFRepot.IsPassed());
        //Console.WriteLine("---------------------------------------------------");
        //ICVReportGeneration wordGenerationReport = new WordCVReportGeneration();
        //var generatedwordRepot = wordGenerationReport.GenerateReport("/gemy/Desktop/CV.docx");
        //Console.WriteLine("Generated Word Report: " + generatedwordRepot.IsPassed());

        //Console.WriteLine("---------------------------------------------------");
        //ICVReportGeneration imageGenerationReport = new ImageCVReportGeneration();
        //var generatedImageRepot = imageGenerationReport.GenerateReport("/gemy/Desktop/CV.png");
        //Console.WriteLine("Generated Image Report: " + generatedImageRepot.IsPassed());

        #endregion

        #region Memento

        //History history = new History();
        //TextEditor textEditor = new TextEditor();

        //textEditor.SetContent("Hello!");
        //history.SaveHistoryState(textEditor.Save());

        //textEditor.SetContent("World!");
        //history.SaveHistoryState(textEditor.Save());

        //textEditor.SetContent("Welcome to Design Pattern Course!");
        //history.SaveHistoryState(textEditor.Save());

        //textEditor.Restore(history.Undo());
        //textEditor.Restore(history.Undo());
        //textEditor.Restore(history.Undo());
        //textEditor.Restore(history.Redo());
        //textEditor.Restore(history.Redo());

        //Console.WriteLine(textEditor.GetContent());
        #endregion

        #region Visitor
        IScheduleManagement scheduleManagement = new DayShiftScheduleManagement();
        scheduleManagement.Accept(new ManageLeaveRequestsVisitor());

        List<IScheduleManagement> scheduleManagements = new List<IScheduleManagement>
        {
            new DayShiftScheduleManagement(),
            new NightShiftScheduleManagement(),
            new RemoteWorkScheduleManagement()
        };

        foreach (var schedule in scheduleManagements)
        {
            schedule.Accept(new CalcBonusVisitor());
        }
        #endregion
    }
}
