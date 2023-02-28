namespace Astronomy.Pages;


public partial class InformationBodies : ContentPage
{
    public InformationBodies()
    {
        InitializeComponent();
        btnInfo1.Clicked += async (s, e) => await Shell.Current.GoToAsync("informationdetails?info=info1");
        btnInfo2.Clicked += async (s, e) => await Shell.Current.GoToAsync("informationdetails?info=info2");
    }
}