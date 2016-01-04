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

namespace Projektarbeit
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

        public List<ProjectEntry> GetMyData()
        {
            var dataList = new List<ProjectEntry>();

            dataList.Add(new ProjectEntry()
            {
                Name = "Projekt1",
                ID = 0
            });

            dataList.Add(new ProjectEntry()
                {
                    Name = "Projekt2",
                    ID = 1
                });

            return dataList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonLogin_Click ( object sender, RoutedEventArgs e )
        {
            Window loginWindow = new Window();
            loginWindow.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;

            TextBox mailBox = new TextBox();
            mailBox.Width = 256;
            mailBox.Margin = new Thickness( 5 );
            mailBox.Text = "E-Mail";

            PasswordBox passwordBox = new PasswordBox();
            passwordBox.Width = 256;
            passwordBox.Margin = new Thickness( 5 );
            passwordBox.Password = "Password";

            Button submitButton = new Button();
            submitButton.Width = 256;
            submitButton.Margin = new Thickness( 5 );
            submitButton.Content = "Anmelden";

            submitButton.Click += ( send, eargs ) =>
                {
                    String mailAddress = mailBox.Text;
                    String password = passwordBox.Password;

                    // hier anmelden via webservice

                    loginWindow.DialogResult = true;
                    loginWindow.Close();
                };

            panel.Children.Add( mailBox );
            panel.Children.Add( passwordBox );
            panel.Children.Add( submitButton );
            loginWindow.Content = panel;

            if ( loginWindow.ShowDialog() == true )
            {
                this.LoginInformation.Visibility = System.Windows.Visibility.Visible;
                this.ButtonLogin.Content = "Logout";
                this.ButtonLogin.Click -= ButtonLogin_Click;
                this.ButtonLogin.Click += ButtonLogin_Click_Logout;
            }
        }


        private void ButtonLogin_Click_Logout ( object sender, RoutedEventArgs e )
        {
            this.ButtonLogin.Content = "Login";
            this.ButtonLogin.Click += ButtonLogin_Click;
            this.ButtonLogin.Click -= ButtonLogin_Click_Logout;
            this.LoginInformation.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
