using DesignPatterns.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class OnlineMarketPlace
    {
        private Dictionary<EventType, List<ISubscriber>> Subscribers;
        private List<Product> Products;
        private List<Offer> Offers;
        private List<JobFinder> JobFinders;

        public OnlineMarketPlace()
        {
            Subscribers = new Dictionary<EventType, List<ISubscriber>>();
            InitializeSubscriberEvents();
            Products = new List<Product>();
            Offers = new List<Offer>();
            JobFinders = new List<JobFinder>();
        }

        public void InitializeSubscriberEvents()
        {
            Subscribers.Add(EventType.ProductAdded, new List<ISubscriber>());
            Subscribers.Add(EventType.OfferAdded, new List<ISubscriber>());
            Subscribers.Add(EventType.JobOpening, new List<ISubscriber>());
        }
        
        public void Subscribe(EventType eventType, ISubscriber subscriber)
        {
            if (Subscribers.ContainsKey(eventType))
            {
                Subscribers[eventType].Add(subscriber);
            }
            else
            {
                Subscribers[eventType] = new List<ISubscriber> { subscriber };
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            NotifySubscribers(EventType.ProductAdded, $"New Product Added: {product.name}");
        }

        public void AddJob(JobFinder jobFinder)
        {
            JobFinders.Add(jobFinder);
            NotifySubscribers(EventType.JobOpening, $"New Job Added: {jobFinder.GetJobName()} - {jobFinder.GetJobDescription()}");
        }

        public void AddOffer(Offer offer)
        {
            Offers.Add(offer);
            NotifySubscribers(EventType.OfferAdded, $"New Offer Added: {offer.GetMessage()}");
        }

        public void NotifySubscribers(EventType eventType, string message)
        {
            Subscribers[eventType].ForEach(subscriber => subscriber.Notify(message));
        }

        public void Unsuscribe(EventType eventType, ISubscriber subscriber)
        {
            if (Subscribers.ContainsKey(eventType))
            {
                Subscribers[eventType].Remove(subscriber);
            }
        }

    }
}
