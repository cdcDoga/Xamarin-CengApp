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
	public partial class EnlargedPhoto : ContentPage
	{
        public EnlargedPhoto(ListElementsViewModel Item)
        {
            InitializeComponent();

            BindingContext = Item;
        }
    }
}