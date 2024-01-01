using System;

using WeC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace WeC.Views
{
    public sealed partial class CirclePage : Page
    {
        public CircleViewModel ViewModel { get; } = new CircleViewModel();

        public CirclePage()
        {
            InitializeComponent();
        }
    }
}
