using MKadmin;
using System;
using System.IO;
using System.Text;

class MKadminMain
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        ConsoleManager.SetOutputEncoding();

        string password = "MySchool";
        string fileName = "stud.txt";
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = FileManager.CombinePaths(desktopPath, fileName);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sveiki");
        Console.WriteLine("Lūdzu, ievadiet savu paroli un nospiediet ENTER");
        string enteredPassword = ConsoleManager.ReadLine();

        if (enteredPassword != password)
        {
            ConsoleManager.WriteLine("Parole ir kļūdaina", ConsoleColor.Red);
            ConsoleManager.ReadLineAndPause();
        }
        else
        {
            ConsoleManager.WriteLine("Ja vēlaties pievienot jaunu skolēnu, ierakstiet 'add' un nospiediet ENTER.", ConsoleColor.White);
            ConsoleManager.WriteLine("Ja vēlaties mainīt datus vai izdzēst skolēnu, ierakstiet 'change' un nospiediet ENTER.", ConsoleColor.White);
            string choice = ConsoleManager.ReadLine();
            if (choice == "add")
            {
                Console.WriteLine("Ievadiet skolēna personas kodu, vārdu, uzvārdu un paroli. Piemērs: 010101-01010 Vards Uzvards Parole");
                string addStudent = ConsoleManager.ReadLine();

                FileManager.AppendTextToFile(filePath, addStudent);
            }

            try
            {
                if (FileManager.FileExists(filePath))
                {
                    string[] lines = FileManager.ReadAllLines(filePath);

                    Console.WriteLine("Dati no faila:");
                    Console.ForegroundColor = ConsoleColor.White;

                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    ConsoleManager.WriteLine("Fails nav atrasts.", ConsoleColor.White);
                }
            }
            catch (Exception e)
            {
                ConsoleManager.WriteLine("Kļūda: " + e.Message, ConsoleColor.White);
            }

            ConsoleManager.ReadLineAndPause();
        }
    }
}