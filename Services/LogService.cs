using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GonzalezFabioExamen3P.Services
{
    public class LogService
    {
        private readonly string logFile;

        public LogService()
        {
            var folder = FileSystem.AppDataDirectory;
            logFile = Path.Combine(folder, "Logs_Gonzalez.txt");
        }

        public async Task AppendLogAsync(string nombre)
        {
            var line = $"Se incluyó el registro {nombre} el {DateTime.Now:dd/MM/yyyy HH:mm}";
            await File.AppendAllTextAsync(logFile, line + Environment.NewLine);
        }

        public async Task<List<string>> ReadLogsAsync()
        {
            if (!File.Exists(logFile))
                return new List<string>();

            var lines = await File.ReadAllLinesAsync(logFile);
            return lines.ToList();
        }
    }
}
