using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CengApp.ViewModels;
using System.Collections.ObjectModel;

namespace CengApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IfrastructurePage : ContentPage
	{
        public ObservableCollection<ListElementsViewModel> elements { get; set; }

        public IfrastructurePage ()
		{
			InitializeComponent ();

            elements = new ObservableCollection<ListElementsViewModel>();
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B1",
                Capacity = "Kapasite: 36",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B1.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B2",
                Capacity = "Kapasite: 15",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B2.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B3",
                Capacity = "Kapasite: 18",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B3.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B4",
                Capacity = "Kapasite: 24",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B4.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B5",
                Capacity = "Kapasite: 15",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B5.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B6",
                Capacity = "Kapasite: 24",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B6.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Derslik-B7",
                Capacity = "Kapasite: 54",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Class_B7.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Lab-01",
                Capacity = "Kapasite: 61 PC",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Lab_PC1.jpg"
            });
            elements.Add(new ListElementsViewModel
            {
                Name = "Lab-02",
                Capacity = "Kapasite: 24 iMac",
                Image = "http://ceng.eskisehir.edu.tr/Documents/Lab_Mac1.jpg"
            });
            InfrastructureList.ItemsSource = elements;

        }

        async void EnlargePhoto(object sender, SelectedItemChangedEventArgs e)
        {
            var EnlargedPhotoPage = new EnlargedPhoto(e.SelectedItem as ListElementsViewModel);
            await Navigation.PushModalAsync(EnlargedPhotoPage);
            InfrastructureList.SelectedItem = null;
        }
        
    }
}