using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Tasker
{
    public partial class EditTaskWindow : Window
    {
        private DateTime? originalSelectedDate;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public EditTaskWindow()
        {
            InitializeComponent();
            DatePickerTaskDate.SelectedDate = DateTime.Now.Date;
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm");
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

        private void CanButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
        public void Initialize(DateTime? selectedDate)
        {
            originalSelectedDate = selectedDate;
            DatePickerTaskDate.SelectedDate = selectedDate; 
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Title = TitleTaskTextBox.Text;
            Description = DescriptionTextBox.Text;

            if (!DatePickerTaskDate.SelectedDate.HasValue)
            {
                MessageBox.Show("Please select a date.");
                return;
            }

            if (TitleTaskTextBox.Text == string.Empty || DescriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter the information about task.");
                return;
            }

            if (!TimeSpan.TryParseExact(TimeTextBox.Text, "hh\\:mm", null, out TimeSpan selectedTime))
            {
                MessageBox.Show("Please enter valid time in HH:mm format.");
                return;
            }
            DateTime selectedDate = DatePickerTaskDate.SelectedDate.Value;
            Deadline = selectedDate.Add(selectedTime);

            this.DialogResult = true;
            this.Close();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (DatePickerTaskDate.SelectedDate < currentDate.Date)
            {
                MessageBox.Show("Selected date cannot be in the past.");
                DatePickerTaskDate.SelectedDate = currentDate.Date;
            }
        }

        private void TimeTextBox_PreviewLostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            if (TimeSpan.TryParseExact(TimeTextBox.Text, "hh\\:mm", null, out TimeSpan selectedTime))
            {
                DateTime selectedDateTime = DatePickerTaskDate.SelectedDate.Value.Add(selectedTime);
                if (selectedDateTime < currentDateTime)
                {
                    MessageBox.Show("Selected time cannot be in the past.");
                    TimeTextBox.Text = currentDateTime.ToString("HH:mm");
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid time format. Please enter time in HH:mm format.");
                TimeTextBox.Text = currentDateTime.ToString("HH:mm");
                e.Handled = true;
            }
        }
    }
 }
