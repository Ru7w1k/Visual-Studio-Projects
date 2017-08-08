using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Notify
    {
        public virtual void NotifyUser()
        {
            Console.WriteLine("Notify Method Unknown");
        }                  
    }

    public class NotifySMS : Notify
    {
        public override void NotifyUser()
        {
            Console.WriteLine("Notify User Via SMS Service");
        }
    }

    public class NotifyEmail : Notify
    {
        public override void NotifyUser()
        {
            Console.WriteLine("Notify User Via Email");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Notify notify = null;

            Console.WriteLine("Enter Method of Notification\n1.SMS \n2.Email");
            int method = int.Parse(Console.ReadLine());

            switch(method)
            {
                case 1:
                    notify = new NotifySMS();
                    break;

                case 2:
                    notify = new NotifyEmail();
                    break;

                default:
                    notify = new Notify();                    
                    break;
            }

            notify.NotifyUser();           
        }
    }
}
