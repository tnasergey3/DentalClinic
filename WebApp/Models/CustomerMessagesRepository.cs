using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CustomerMessagesRepository
    {
        private static List<CustomerMessages> customerMessages = new List<CustomerMessages>();
        public static IEnumerable<CustomerMessages> CustomerMessages
        {
            get { return customerMessages; }
        }
        public static void AddMessage(CustomerMessages customerMessage) {
            customerMessages.Add(customerMessage);
        }
    }
}
