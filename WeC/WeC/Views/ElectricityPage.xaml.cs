using System;

using WeC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WeC.Views
{
    public sealed partial class ElectricityPage : Page
    {
        public ElectricityViewModel ViewModel { get; } = new ElectricityViewModel();

        public ElectricityPage()
        {
            InitializeComponent();
        }
    }
}
