using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        Person John;
        Person Sarah;
        Person Pete;
        Person Sammy;
        Person Jeff;
        public Simulation()
        {
            John = new Person("John", 150);
            Sarah = new Person("Sarah", 200);
            Pete = new Person("Pete", 35);
            Sammy = new Person("Sammy", 2000);
            Jeff = new Person("Jeff", 5000000);
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.


            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            John.DisplayInfo();
            Sarah.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            John.TransferMoney(Sarah, 50);
            Sarah.TransferMoney(John, 500);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            John.DisplayInfo();
            Sarah.DisplayInfo();
            Pete.DisplayInfo();
            Sammy.DisplayInfo();
            Jeff.DisplayInfo();
            Person Giver=userSelectPerson("Give");
            Person Receiver= userSelectPerson("Receive");
            int transferamount=userTransferAmount();
            finishUserTransfer(Giver, Receiver, transferamount);


            Console.WriteLine("Simulation complete.");
        }
        public Person userSelectPerson(string recieveGive)
        {
            Console.WriteLine($"Pick a person to {recieveGive} money");
            String person = Console.ReadLine();
            Person Person = null;
            switch (person)
            {
                case ("John"):
                    Person = John;
                    break;
                case ("Sarah"):
                    Person = Sarah;
                    break;
                case ("Pete"):
                    Person = Pete;
                    break;
                case ("Sammy"):
                    Person = Sammy;
                    break;
                case ("Jeff"):
                    Person = Jeff;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            return Person;
        }
        public int userTransferAmount()
            {
                Console.WriteLine("Select amount to transfer");
                int transferAmount = Int32.Parse(Console.ReadLine());
                return transferAmount;
            }
        public void finishUserTransfer(Person Giver,Person Receiver, int transferAmount)
            {
                Giver.TransferMoney(Receiver, transferAmount);
                Giver.DisplayInfo();
                Receiver.DisplayInfo();
            }
        }
    }


            