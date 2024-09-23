using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CrudOperationTask2.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string? title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(isNotLoading))]
        bool isLoading;

        public bool isNotLoading => !isLoading;
    }
}
