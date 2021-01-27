// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019  
// By: M2994

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Jack Travis", "554 Ratters Place", "Apt. 2",
             "New Hope", "ME", 32245); // Test Address 4
            Address a6 = new Address("Travis Scott", "776 Bingham Place", "Suite 23",
            "Dry Lot", "Ky", 54545); // Test Address 4


            Letter letter1 = new Letter(a1, a2, 3.95M); // Letter Test Object
            Letter letter2 = new Letter(a4, a3, 4.95M); // Letter Test Object
            Letter letter3 = new Letter(a2, a1, 6.95M);// Letter Test Object
            Letter letter4 = new Letter(a1, a4, 1.95M);// Letter Test Object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a6, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp3 = new GroundPackage(a6, a5, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a6, a1, 35, 13, 18,    // Next Day test object
               85, 9.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a2, a3, 35.2, 23.5, 23.0, // Two Day test object
        80.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap1);
            parcels.Add(tdap2);


            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(); // Separate and clear

            Console.WriteLine("Parcels sorted by ascending cost:");
           Console.WriteLine("====================");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause(); // Separate and clear

            // Sort the parcels using the DescendingByDestinationZip class
            parcels.Sort(new DescendingByDestinationZip());

           
            Console.WriteLine("Parcels sorted by descending destination ZIP:");
            Console.WriteLine("====================");

            // Display the descending destination zip parcels
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause(); // Separate and clear
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
