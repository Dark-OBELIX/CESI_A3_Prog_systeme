//using Newtonsoft.Json; // librairie utiliser pour les logs en json

//   var_log = fonc_log.log_json(sauvegarde_name, sourceDir, backupDir, fileSizeInBytes);

namespace classe {
    public class Log
    {
        public string log_json(string save_name, 
            string status, 
            string error_message,
            string file_source_path, 
            string file_target_path,
            TimeSpan duration,
            long file_size)
        { 

        try
        {
            string logFilePath = "log_application.txt";

            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Sauvegarde : {save_name}");
                sw.WriteLine($"Statut : {status}");
                sw.WriteLine($"Error : {error_message}");
                sw.WriteLine($"Source : {file_source_path}");
                sw.WriteLine($"Destination : {file_target_path}");
                sw.WriteLine($"Date/Heure fin de tache : {DateTime.Now}");
                sw.WriteLine($"duration : {duration}");
                sw.WriteLine($"Size (bytes): {file_size}");
                sw.WriteLine(); // Ligne vide pour séparer les entrées dans le fichier log
            }

            return "Informations ajoutées au fichier log avec succès.";
        }
        catch (Exception ex)
        {
           return "Erreur lors de l'écriture dans le fichier log : {ex.Message}";
        }

        }
    }
}