using CommunityToolkit.Mvvm.ComponentModel;
using CrudOperationTask2.Models;
using CrudOperationTask2.Services;
using System.Web;


namespace CrudOperationTask2.ViewModels
{

    [QueryProperty(nameof(Id), nameof(Id))]
    public partial class CarDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]
        Car car;
        [ObservableProperty]
        int id;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Id = Convert.ToInt32(HttpUtility.UrlDecode(query["Id"].ToString()));
            Car = App.CarService.GetCar(Id);
        }
    }
}
