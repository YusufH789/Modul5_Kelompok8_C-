﻿using System;

namespace Modul5_Kelompok8_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, password;
            Console.Write("Email : ");
            email = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();
            userService data = new userService(email, password);
            data.login();
            Console.ReadKey();
        }
    }
}
