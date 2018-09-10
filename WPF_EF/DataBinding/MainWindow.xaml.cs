using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<User> _users = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            _users.Add(new User() { Name = "Bernardo", Birthyear = 1990});
            _users.Add(new User() { Name = "Patrick", Birthyear = 1970 });
            lbUsers.ItemsSource = _users;
        }

        private void BtnAddUser_OnClick(object sender, RoutedEventArgs e)
        {
            _users.Add(new User() {Name = "Victor", Birthyear = 1975});
        }

        private void BtnChangeUser_OnClick(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                ((User) lbUsers.SelectedItem).Name = "Cleoniki";
        }
    }
}
