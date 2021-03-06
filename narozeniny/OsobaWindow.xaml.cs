using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace narozeniny
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class OsobaWindow : Window
    {
        private SpravceOsob spravceOsob;

        public OsobaWindow(SpravceOsob spravceOsob)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                spravceOsob.Pridej(jmenoTextBox.Text, narozeninyDatePicker.SelectedDate);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
