using Microsoft.EntityFrameworkCore;
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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void CreateUsers(object sender, RoutedEventArgs e)
        {
            var result = await GetUsers();
            MessageBox.Show(result.Count.ToString());
        }

        private async Task<List<User>> GetUsers()
        {
            using (var context = new AsyncDbContext())
            {
                context.Users.AddRange(new List<User>
                    { 
                        new User {Name = "1"},
                        new User {Name = "2"},
                        new User {Name = "3"},
                        new User {Name = "4"},
                        new User {Name = "5"},
                        new User {Name = "6"},
                        new User {Name = "7"},
                        new User {Name = "8"},
                    });
                await context.SaveChangesAsync();

                return await context.Users.ToListAsync();
            }
        }
    }
}
