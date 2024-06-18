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
using System.Windows.Shapes;

namespace Tasker
{
    public partial class RenameListWindow : Window
    {
        public string NewListName { get; set; }
        public RenameListWindow(string currentName)
        {
            InitializeComponent();
            TitleListTextBox.Text = currentName;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }

        private void RenameButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleListTextBox.Text))
            {
                MessageBox.Show("Please enter a valid list name.");
                return;
            }

            NewListName = TitleListTextBox.Text;
            this.DialogResult = true;
            Close();
        }

        private void Form_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

    }
}
