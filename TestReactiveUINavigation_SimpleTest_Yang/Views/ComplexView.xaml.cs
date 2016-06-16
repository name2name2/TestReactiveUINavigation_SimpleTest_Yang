using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using TestReactiveUINavigation_SimpleTest_Yang.ViewModels;

namespace TestReactiveUINavigation_SimpleTest_Yang.Views
{
    /// <summary>
    /// ComplexView.xaml 的互動邏輯
    /// </summary>
    public partial class ComplexView : UserControl, IViewFor
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
                "ViewModel", typeof(ComplexViewModel), typeof(ComplexView),
                new PropertyMetadata(default(ComplexViewModel)));

        public ComplexView()
        {
            InitializeComponent();
        }

        public ComplexViewModel ViewModel
        {
            get { return (ComplexViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set {
                ViewModel = (ComplexViewModel) value;
                this.DataContext = ViewModel;
            }
        }
    }


}
