using System;
using System.IO;

namespace classe
{
    public class FileProcessor
    {
        private string directoryPath;

        public FileProcessor(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public void ProcessFiles()
        {
            try
            {
                string[] fileList = Directory.GetFiles(directoryPath);

                // Ajoutez ici la logique pour traiter les fichiers
                foreach (var filePath in fileList)
                {
                    Console.WriteLine($"Traitement du fichier : {filePath}");
                    // Ajoutez votre logique de traitement ici
                }
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine($"Erreur : {dirNotFound.Message}");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Vérifiez si des arguments ont été fournis en ligne de commande
            if (args.Length == 0)
            {
                Console.WriteLine("Veuillez fournir le chemin du répertoire en tant qu'argument.");
                return;
            }

            string directoryPath = args[0];

            FileProcessor fileProcessor = new FileProcessor(directoryPath);
            fileProcessor.ProcessFiles();

            Console.ReadKey();
        }
    }
}
 