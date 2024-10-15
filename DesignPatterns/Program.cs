using DesignPatterns.Observer;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        #region StrategyPatternTesting
        //PaymentProcessor paymentProcessor = new PaymentProcessor(new VisaPaymentStrategy());
        //Order order = new Order();

        //paymentProcessor.ProcessOrderPayment(order);
        #endregion

        OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();

        ISubscriber Ahmed = new SubscriberOp("Ahmed");
        ISubscriber Mohamed = new SubscriberOp("Mohamed");
        ISubscriber Youssef = new SubscriberOp ("Youssef");
        ISubscriber Moustafa = new SubscriberOp("Moustafa");


        onlineMarketPlace.Subscribe(EventType.ProductAdded, Ahmed);
        onlineMarketPlace.Subscribe(EventType.ProductAdded, Mohamed);
        onlineMarketPlace.Subscribe(EventType.OfferAdded, Ahmed);
        onlineMarketPlace.Subscribe(EventType.OfferAdded, Youssef);
        onlineMarketPlace.Subscribe(EventType.JobOpening, Moustafa);



        onlineMarketPlace.AddOffer(new Offer("20% Discount Now! "));
        onlineMarketPlace.AddProduct(new Product { name = "Mobile", price = 10000 });
        onlineMarketPlace.AddJob(new JobFinder("Software Engineer", "C# Developer "));

    }
}
