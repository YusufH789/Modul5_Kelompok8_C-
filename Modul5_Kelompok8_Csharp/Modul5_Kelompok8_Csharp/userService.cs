using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5_Kelompok8_Csharp
{
    class userService
    {
        private string[,] data;
        private string[,] histories;
        private string email, password, roles, matkul1, matkul2, tanggal = "";

        public userService(string emails, string passwords)
        {
            email = emails;
            password = passwords;
            data = new string[2, 3] {
                {"yusufkelompok8@gmail.com", "12345678", "userpraktikan1" },
                {"samykelompok8@gmail.com", "87654321", "userpraktikan2"  }
            };
            histories = new string[2, 4]
            {
                {"yusufkelompok8@gmail.com", "Fisika Dasar", "Dasar Komputer dan Pemrograman", "26-04-2020" },
                {"samykelompok8@gmail.com", "Dasar Komputer dan Pemrograman", "Konsep Jaringan Komputer", "26-04-2020" }
            };
        }
        public void login()
        {
            var (status, role) = checkCredentials();
            if (status == true)
            {
                Console.WriteLine("\nWelcome " + role);
                Console.WriteLine("Logged it as user email: " + email);
                Console.WriteLine("\n" + email + " Meminjam buku : ");
                Console.WriteLine(matkul1);
                Console.WriteLine(matkul2);
                Console.WriteLine("Tanggal peminjaman : " + tanggal);
            }
            else
            {
                Console.WriteLine("\nInvalid Login");
            }
        }
        private (bool, string) checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == email && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    email = histories[i, 0];
                    matkul1 = histories[i, 1];
                    matkul2 = histories[i, 2];
                    tanggal = histories[i, 3];
                    return (true, roles);
                }
            }
            return (false, roles);
        }
    }
}
