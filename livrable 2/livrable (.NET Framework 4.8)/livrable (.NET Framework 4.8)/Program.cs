using System;
using System.IO;
using Easyspace;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the language you want : FR or ENG");
        string input_language = Console.ReadLine();
        string choiceMessage = "";

        if (input_language == "FR")
        {
            language_fr lang = new language_fr();
            choiceMessage = lang.choice_cut_copy();
        }
        else
        {
            language_eng lang = new language_eng();
            choiceMessage = lang.choice_cut_copy();
        }

        Console.WriteLine(choiceMessage);
        string sourceDir = @"C:\Archive\sources";
        string backupDir = @"C:\Archive\CESI test";

        try
        {
            string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
            string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

            // Copy text files.
            foreach (string f in txtList)
            {
                string fName = f.Substring(sourceDir.Length + 1);// Remove path from the file name.

                try
                {
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));// Will not overwrite if the destination file already exists.
                }

                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);// Catch exception if the file was already copied.
                }
            }
        }
        catch (DirectoryNotFoundException dirNotFound)
        {
            Console.WriteLine(dirNotFound.Message);
        }
    }
}