//blake buchanan here, if you're expecting me to remember my name this semester you're gonna have a bad time
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

namespace Participation1
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

        private void EnterFormButton_Click(object sender, RoutedEventArgs e)
        {
            EntryForm ee = new EntryForm(NameTextBox.Text, AddressBox.Text, Convert.ToInt32(ZipBox.Text));
            BigYellowListBox.Items.Add(ee);
        }
    }
}
