using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Tasker
{
  
    public partial class CreateTaskWindow : Window
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public CreateTaskWindow()
        {
            InitializeComponent();
            DatePickerTask.SelectedDate = DateTime.Now.Date;
            TimeTaskTextBox.Text = DateTime.Now.ToString("HH:mm");
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void Form_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();    
        }
        public CreateTaskWindow(string title, string description, DateTime deadline) : this()
        {
            TitleTaskTextBox.Text = title;
            DescriptionTextBox.Text = description;
            DatePickerTask.SelectedDate = deadline.Date;
            DatePickerTask.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Now));
            TimeTaskTextBox.Text = DateTime.Now.ToString("HH:mm");
        }
        private void СreateButton_Click(object sender, RoutedEventArgs e)
        {
            Title = TitleTaskTextBox.Text;
            Description = DescriptionTextBox.Text;

            if (!DatePickerTask.SelectedDate.HasValue)
            {
                MessageBox.Show("Please select a date.");
                return;
            }

            if (TitleTaskTextBox.Text  == string.Empty || DescriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter the information about task.");
                return;
            }
         
            if(!TimeSpan.TryParseExact(TimeTaskTextBox.Text, "hh\\:mm", null, out TimeSpan selectedTime))
            {
                MessageBox.Show("Please enter valid times in HH::mm format.");
            }
            DateTime selectedDate = DatePickerTask.SelectedDate.Value;
          
            Deadline = new DateTime(
                selectedDate.Year,
                selectedDate.Month,
                selectedDate.Day,
                selectedTime.Hours,
                selectedTime.Minutes,
                0
            );

            this.DialogResult = true;
            this.Close();

        }

        private void DatePickerTask_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (DatePickerTask.SelectedDate < currentDate.Date)
            {
                MessageBox.Show("Selected date cannot be in the past.");
                DatePickerTask.SelectedDate = currentDate.Date;
            }
        }

        private void TimeTaskTextBox_PreviewLostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            if (DateTime.TryParseExact(TimeTaskTextBox.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedTime))
            {
                DateTime selectedDateTime = DatePickerTask.SelectedDate.Value.Add(selectedTime.TimeOfDay);
                if (selectedDateTime < currentDateTime)
                {
                    MessageBox.Show("Selected time cannot be in the past.");
                    TimeTaskTextBox.Text = currentDateTime.ToString("HH:mm");
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid time format. Please enter time in HH:mm format.");
                TimeTaskTextBox.Text = currentDateTime.ToString("HH:mm");
                e.Handled = true;
            }
        }
    }
}
