using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment12
    {
        public void ElectricityBill()
        {
            int id, units;
            string name;
            double chargePerUnit, amount;

            while (true)
            {
                Console.WriteLine("Enter Customer Number: ");
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid Customer Number");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter Units Consumed: ");
                if (!int.TryParse(Console.ReadLine(), out units) && (units > 0))
                {
                    Console.WriteLine("Invalid Units");
                }
                else
                {
                    break;
                }
            }

            if (units > 0 && units <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (units < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (units < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }
            
            Console.WriteLine("Customer ID : {0}", id);
            Console.WriteLine("Customer Name : {0}", name);
            Console.WriteLine("Units Consumed : {0}", units);
            Console.WriteLine("Amount Charges @Rs{0} Per Unit : {1}", chargePerUnit, (units * chargePerUnit));

            amount = units * chargePerUnit;
            if (amount >= 400)
            {
                Console.WriteLine("Surcharge Amount : {0}", (0.15 * amount));
                amount = amount + (0.15 * amount);
            }
            if(amount < 100)
            {
                amount = 100;
            }
            Console.WriteLine("Net Amount Paid By the Customer: {0}", amount);

        }
    }
}
