﻿using System;
using System.Collections.Generic;
namespace LibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            catalog.ReturnBook();
            catalog.ReserveBook();
            catalog.ReserveBook();
            catalog.ReserveBook();
            catalog.ReturnBook();
            Console.WriteLine("Works?");
            //catalog.DisplayMenu();
        }
    }
}