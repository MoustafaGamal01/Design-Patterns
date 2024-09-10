using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    public interface IUserManager
    {
        void UpdateToUserProfile(Customer customer);
        void ChangePassword(Customer customer, string newPassword);
    }
}
