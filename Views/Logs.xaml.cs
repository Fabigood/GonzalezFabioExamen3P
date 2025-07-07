
using CommunityToolkit.Mvvm.ComponentModel;
using GonzalezFabioExamen3P.Services;

namespace GonzalezFabioExamen3P.ViewModels
{
    public partial class LogsViewModel : ObservableObject
    {
        [ObservableProperty]
        List<string> logs;

        private readonly LogService logService;

        public LogsViewModel(LogService log)
        {
            logService = log;
            LoadLogs();
        }

        async void LoadLogs()
        {
            Logs = await logService.ReadLogsAsync();
        }
    }
}
