using Prism.Commands;
using PropertyChanged;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel viewModel;
        public MainWindow()
        {
            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }


    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        public int AddItem1 { get; set; }

        public int AddItem2 { get; set;}

        public int AddSum { get; set;}

        [DoNotNotify]
        public DelegateCommand CleanBtn { get; set;}
        [DoNotNotify]
        public DelegateCommand AddBtn { get; set;}

        public MainWindowViewModel()
        {
            AddItem1 = 0;
            AddItem2 = 0;
            AddSum = 0;
            CleanBtn = new DelegateCommand(() =>
            {
                AddItem1 = 0;
                AddItem2 = 0;
                AddSum = 0;
            });

            AddBtn = new DelegateCommand(() =>
            {
                AddSum = AddItem1 + AddItem2;
            });

        }
    }
}
