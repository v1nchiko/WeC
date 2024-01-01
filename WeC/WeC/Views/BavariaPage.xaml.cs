using System;

using WeC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WeC.Views
{
    public sealed partial class BavariaPage : Page
    {
        public BavariaViewModel ViewModel { get; } = new BavariaViewModel();

        public BavariaPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
