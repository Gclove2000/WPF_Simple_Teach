using Prism.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public MainWindowViewModel ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel();
            this.DataContext = ViewModel;
            InitializeComponent();
        }
    }


    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel
    {
        [DoNotNotify]
        public DelegateCommand AddCommand { get; set; }
        public ObservableCollection<Item> ItemList { get; set; }

        public DelegateCommand <Item> DeleteCommand {get; set;}
        
        public string AddContext { get;set; }
        public MainWindowViewModel()
        {
            AddContext = "";
            ItemList = new ObservableCollection<Item>();
            AddItem("小明");
            AddItem("小刘");
            AddItem("小红");

            AddCommand = new DelegateCommand(() =>
            {
                if(AddContext != "")
                {
                    AddItem(AddContext);
                }
                AddContext = "";
            });

            DeleteCommand = new DelegateCommand<Item>((item) =>
            {

                ItemList.Remove(item);

            });
        }

        private void AddItem(string Content)
        {
            ItemList.Add(new Item { Content = Content,Id = ItemList.Count });
        }

        
        
    }


    public class Item
    {
        public int Id { get; set; }

        public string Content { get; set; }
    }


}
