using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.PasswordManager
{
    /*
    public  class App
    {
        private static readonly Dictionary<string, String> _passwordEntries = new();
        public static void Run(string[] args)
        {
            ReadPasswords();
            while (true)
            {
                Console.WriteLine("Please Select option:");
                Console.WriteLine("1. List all passwords\n2. Add or change password\n3. Get password\n4. Delete password");
                var selectOption = Console.ReadLine();
                if (selectOption == "1")
                    listAllPassword();
                else if (selectOption == "2")
                    AddOrChangePassword();
                else if (selectOption == "3")
                    GetPassword();
                else if (selectOption == "4")
                    DeletePassword();
                else
                    Console.WriteLine("Invalid option!");
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }

        private static void listAllPassword()
        {
            foreach (var entry in _passwordEntries)
                    
                    Console.WriteLine($"{entry.Key} = {entry.Value}");

        }
        private static void DeletePassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
            {
                _passwordEntries.Remove(appName);
                SavePassword();
            }
            else
                Console.WriteLine("Passwoed not found");
        }

        private static void GetPassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                Console.WriteLine($"Your password is: {_passwordEntries[appName]}");
            else 
                Console.WriteLine("password not found");
        }

        private static void AddOrChangePassword()
        {
            Console.Write("Please enter website or app name: ");
            var appName = Console.ReadLine();
            Console.Write("Please enter your password: ");
            var password = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName)) { 
                _passwordEntries[appName] = password;
              
            }
            else
                _passwordEntries.Add(appName, password);
            SavePassword();
        }
        private static void ReadPasswords()
        {
            if(File.Exists("Password.txt"))
            {
                var passwordlin = File.ReadAllText("password.txt");
                foreach(var line in passwordlin.Split(Environment.NewLine))
                {
                    if(!String.IsNullOrEmpty(line))
                    {
                        var equalIndex = line.IndexOf('=');
                        var appNmae= line.Substring(0, equalIndex);
                        var password= line.Substring(equalIndex + 1);
                        _passwordEntries.Add(appNmae,EncryptionUtility.Decrypt (password));
                    }
                }
            }
        }
        private static void SavePassword()
        {
            var sb= new StringBuilder();
            foreach (var entry in _passwordEntries)
                sb.AppendLine($"{entry.Key} =  {EncryptionUtility.Encrypt(entry.Value)}");
            File.WriteAllText("Password.txt",sb.ToString());
        }

    
    }
    */
}
