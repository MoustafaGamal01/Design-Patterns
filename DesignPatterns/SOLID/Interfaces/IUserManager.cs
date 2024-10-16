﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.Interfaces
{
    public interface IUserManager
    {
        //void SubscribeToNewProductsAvailability();
        //void SubscribeToSMSNorifications();
        void UpdateToUserProfile(Customer customer);
        void ChangePassword(Customer customer, string newPassword);
    }
}
