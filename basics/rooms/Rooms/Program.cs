﻿using System;
using System.Globalization;

namespace Rooms {
    class Program {
        static void Main(string[] args) {

            Room[] vect = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= n; i++) {

                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numberRoom = int.Parse(Console.ReadLine());                
                vect[numberRoom] = new Room( name, email );
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
