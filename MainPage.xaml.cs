using CrudOperationTask2.ViewModels;

namespace CrudOperationTask2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;
        }
    }
}
