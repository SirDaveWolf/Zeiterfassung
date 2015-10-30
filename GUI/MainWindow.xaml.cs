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
            var data = GetMyData();

            foreach( var dataItem in data )
            {
                this.comboBoxTest.Items.Add(dataItem);
            }
        }
    }
}
