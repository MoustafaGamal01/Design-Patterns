﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal interface ISubscriptionNotificationService
    {
        void SubscribeToNewProductsAvailability();
        void SubscribeToSMSNorifications();
    }
}
