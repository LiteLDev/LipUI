using CommunityToolkit.Mvvm.ComponentModel;

namespace LipUI.ViewModels
{
    public partial class LipInstallerViewModel : ObservableObject
    {
        [ObservableProperty] bool _manualExe;
        [ObservableProperty] bool _portableExe = true;
        [ObservableProperty] bool _globalExe;
        [ObservableProperty] string _lipPath = string.Empty;
        [NotifyPropertyChangedFor(nameof(CurrentLipPath))]
        [ObservableProperty] string _tip = string.Empty;

        [ObservableProperty] bool _showProgressBar;
        [ObservableProperty] double _progress;
        public string CurrentLipPath => Global.Lip.ExecutablePath;
    }
}
