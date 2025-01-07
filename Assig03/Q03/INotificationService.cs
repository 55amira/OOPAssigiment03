using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig03.Q03
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
