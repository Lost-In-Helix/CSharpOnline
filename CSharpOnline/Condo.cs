﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    /* This class is a child class of House
     Lesson 11 Inheritance */
    public class Condo : House
    {
        string _balcony;

        public void Maintenance()
        {
            Console.WriteLine("Fixing Condo stuff");
        }

        public override void DoorOpenClose()
        {
            Console.WriteLine("The door creaks");
        }

    } // end class
} // end namespacce