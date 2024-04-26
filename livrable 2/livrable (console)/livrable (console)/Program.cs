using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.IO;

using classe;
using static classe.LanguageBase;
using static classe.Language_fr;
using static classe.Language_eng;
using static classe.Log;
using static classe.FileProcessor;
using System.Globalization;

class Program
{
    public static LanguageBase lang; // Utilisez une classe de base pour la variable lang

    static void Main()
    {
        
        // language choice
        while (true)
        {
            Console.WriteLine("Enter the desire language : FR ou ENG");

            string input_language = Console.ReadLine();
            string choiceMessage = "";

            if (input_language == "FR")
            {
                lang = new Language_fr();
                choiceMessage = lang.set_lang();
            }
            else if (input_language == "ENG")
            {
                lang = new Language_eng();
                choiceMessage = lang.set_lang();
            }
            else
            {
                Console.WriteLine("No support language please entrer FR or ENG.");
                continue; // Retourne au début de la boucle
            }

            Console.WriteLine(choiceMessage);
            break;
        }

        // type off start
        while (true)
        {

            Console.WriteLine(lang.choice_cut_copy());
            string input_start = Console.ReadLine();

            if (input_start == "COPY" || input_start == "COPIE")
            {
                lang.cut_copy = false;
                Console.WriteLine(lang.validation_choice_copy());
            }
            else if (input_start == "CUT" || input_start == "COUPEZ")
            {
                lang.cut_copy = true;
                Console.WriteLine(lang.validation_choice_cut());
            }
            else
            {
                continue; // Retourne au début de la boucle
            }
            break;
        }

        // Choice off sauvegarde name
        Console.WriteLine(lang.choice_stain_name());
        string sauvegarde_name = Console.ReadLine();
        string sourceDir = "";

        FileProcessor fileProcessor = new FileProcessor(@"C:\\Users\\Hugo\\Desktop\\dossier fichier\");
        fileProcessor.ProcessFiles();

        try
        {
            string[] fileList = Directory.GetFiles(@"C:\\Users\\Hugo\\Desktop\\dossier fichier\");

        }
        catch (DirectoryNotFoundException dirNotFound)
        {
            Console.WriteLine(dirNotFound.Message);
        }


        string backupDir = @"C:\Users\Hugo\Desktop\source";

        long number_of_byte_to_save = 0;

        try
        {
            string[] fileList = Directory.GetFiles(sourceDir);
            // Create a list to store information about each file (name, extension, size).
            List<string[]> fileInformationList = new List<string[]>();

            // Collect file information before copying.
            foreach (string f in fileList)
            {
                string fName = Path.GetFileName(f); // Get the file name with extension.
                try
                {
                    string sourceFilePath = Path.Combine(sourceDir, fName);
                    FileInfo fileInfo = new FileInfo(sourceFilePath);
                    number_of_byte_to_save = number_of_byte_to_save + fileInfo.Length;

                    // Ajouter les informations du fichier à la liste.
                    string[] fileInfoArray = { fName, Path.GetExtension(fName), fileInfo.Length.ToString() };
                    fileInformationList.Add(fileInfoArray);

                    Console.WriteLine(number_of_byte_to_save);
                }
                catch (IOException error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            // Copy files and get their sizes.
            DateTime time_start = DateTime.Now;
            foreach (string[] fileInfo in fileInformationList)
            {
                string fName = fileInfo[0];
                string sourceFilePath = Path.Combine(sourceDir, fName);
                string destinationFilePath = Path.Combine(backupDir, fName);

                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true); // Will not overwrite if the destination file already exists.
                                                                          // Console.WriteLine($"File '{fName}' copied. Size: {fileInfo[2]} bytes");
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message); // Catch exception if the file was already copied.
                }
            }
                DateTime time_stop = DateTime.Now;
                TimeSpan duration = time_start - time_stop;
                Console.WriteLine(duration);
                string var_log = "";
                Log fonc_log = new Log();
                var_log = fonc_log.log_json("SUCCEDED", "Cut original file = " + lang.cut_copy, sauvegarde_name, sourceDir, backupDir, duration, number_of_byte_to_save);
                Console.WriteLine(var_log);
                
            

            if (lang.cut_copy == true)
            {
                foreach (string f in fileList)
                {
                    File.Delete(f);
                }
            }
        }
        catch (DirectoryNotFoundException dirNotFound)
        {
            Console.WriteLine(dirNotFound.Message);
            DateTime error_time = DateTime.Now;
            string var_log = "";
            Log fonc_log = new Log();
            var_log = fonc_log.log_json("FAILED", dirNotFound.Message, sauvegarde_name, sourceDir, backupDir, error_time - error_time, number_of_byte_to_save);
            Console.WriteLine(var_log);
        }

    }
}
