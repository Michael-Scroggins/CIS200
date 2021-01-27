// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019  
// By: M2994

// File: DescendingByDestinationZip
// DescendingByDestinationZip sets up the class that allows the objects to be sorted in descending order by their destination ZIP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingByDestinationZip : IComparer<Parcel>
    {

        public int Compare(Parcel parcel1, Parcel parcel2)
        {
            // Correct handling of null values from SortingDemo
            if (parcel1 == null & parcel2 == null)
            {
                return 0;
            }

            if (parcel1 == null)
            {
                return -1;
            }

            if (parcel2 == null)
            {
                return 1;
            }

            // Parcel2 first for descending order
            return (parcel2.DestinationAddress.Zip).CompareTo(parcel1.DestinationAddress.Zip);
        }

    }
}
