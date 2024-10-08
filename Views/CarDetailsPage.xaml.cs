using CrudOperationTask2.ViewModels;

namespace CrudOperationTask2.Views;

public partial class CarDetailsPage : ContentPage
{
    public CarDetailsPage(CarDetailsViewModel carDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = carDetailsViewModel;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}