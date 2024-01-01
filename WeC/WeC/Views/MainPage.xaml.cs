using System;

using WeC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WeC.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
