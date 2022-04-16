using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

//Capture the information about each guest (assumption is at least one guest and unknown maxium)
//Info to capture: First name, last name, message to the host
//once done, loop through each guest and print their info



namespace MyConsoleUI
{
    class Program
    {
       private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {

            GetGUestInfo();
            PrintGuestInfo();

            Console.ReadLine();
        }
        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfor);
            }
        }
        private static void GetGUestInfo()
        {
            string moreGuestComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetinfoFromConsole("What is your first name: ");
            
                guest.LastName = GetinfoFromConsole("What is your last name: ");

                guest.MessageToHost = GetinfoFromConsole("What message would you like to tell your host: ");

                moreGuestComing = GetinfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestComing.ToLower() == "yes");

        }

        private static string GetinfoFromConsole(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }


    }



}
