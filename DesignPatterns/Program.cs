using DesignPatterns.Strategy.Interfaces;
using DesignPatterns.Strategy;
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


    }
}
