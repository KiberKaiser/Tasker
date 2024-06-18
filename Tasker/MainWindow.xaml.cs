using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;
using Newtonsoft.Json;
namespace Tasker
{
  
    public partial class MainWindow : Window
    {

        public class TaskList
        {
           public string Name { get; set; }
           public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
           public bool IsSelected { get; set; }
        }

        public class TaskItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Deadline { get; set; }
        }

        private List<TaskList> _taskLists = new List<TaskList>();
        private TaskList selectedList;
        private Button selectedButton;
        private TaskItem selectedTask;
        private Border selectedTaskBorder;
        
        public MainWindow()
        {
            InitializeComponent();
            LoadTaskLists();
        }
        
        private void UpdateListUI()
        {
            if (_taskLists == null)
            {
                return;
            }

            ListsPanel.Children.Clear();
            foreach (var list in _taskLists)
            {
                AddListToUI(list);
            }
        }

        private void AddListToUI(TaskList list)
        {
            Button listButton = new Button
            {
                Content = list.Name,
                Tag = list,
                Height = 40,
                Width = 251,
                Style = (Style)FindResource("ListButtonStyle")
            };

            listButton.Click += ListButton_Click;
            ListsPanel.Children.Add(listButton);
        }

        private void AddTaskToUI(TaskItem task)
        {
            Border taskBorder = new Border
            {               
                Margin = new Thickness(5),
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1),
                Background = Brushes.LightGray,
                Child = new TextBlock
                {
                    Text = $"{task.Title}\nDescription: {task.Description}\nTime: {task.Deadline:MM/dd/yyyy HH:mm}",
                    TextWrapping = TextWrapping.Wrap,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    HorizontalAlignment = HorizontalAlignment.Stretch
                }
            };
            TasksPanel.Children.Add(taskBorder);
        }

        private void DisplayTasks(TaskList list)
        {
            TasksPanel.Children.Clear();

            foreach (var task in list.Tasks)
            {
                Border taskBorder = new Border
                {
                    Margin = new Thickness(5),
                    BorderBrush = Brushes.Gray,
                    BorderThickness = new Thickness(1),
                    Background = Brushes.LightGray,
                    Child = new StackPanel
                    {
                        Children =
                {
                    new TextBlock
                    {
                        Text = $"{task.Title}\nDescription: {task.Description}\nTime: {task.Deadline:MM/dd/yyyy HH:mm}",
                        TextWrapping = TextWrapping.Wrap,
                        VerticalAlignment = VerticalAlignment.Stretch,
                        HorizontalAlignment = HorizontalAlignment.Stretch
                    }
                }
                    }
                };
                taskBorder.MouseLeftButtonDown += (s, e) =>
                {
                    if (selectedTaskBorder != null)
                    {
                        selectedTaskBorder.Background = Brushes.LightGray;
                    }

                    selectedTaskBorder = taskBorder;
                    selectedTaskBorder.Background = Brushes.LightBlue;
                    selectedTask = task;
                };

                TasksPanel.Children.Add(taskBorder);
            }
        }

        private void TaskBorder_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (selectedTaskBorder != null)
            {
                selectedTaskBorder.ClearValue(Border.BackgroundProperty);
            }

            selectedTaskBorder = sender as Border;
            selectedTaskBorder.Background = Brushes.LightBlue;

            selectedTask = selectedTaskBorder.Tag as TaskItem;
        }
        private void DeleteListButton_Click(object sender, RoutedEventArgs e)
        {
            if(selectedList == null)
            {
                MessageBox.Show("Please select a list to delete");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete the selected list and all tasks in it?", "Delete list", MessageBoxButton.YesNo);
            
                if (result == MessageBoxResult.Yes)
                {
                    _taskLists.Remove(selectedList);
                    ListsPanel.Children.Remove(selectedButton);
                    TasksPanel.Children.Clear();
                    selectedList = null;
                    selectedButton = null;
                }
            
        }

        private void RenameListButton_Click(object sender, RoutedEventArgs e)
        {
            if(selectedList == null)
            {
                MessageBox.Show("Please select a list to rename");
                return;
            }
            RenameListWindow renameListWindow = new RenameListWindow(selectedList.Name);
            if(renameListWindow.ShowDialog() == true)
            {
                selectedList.Name = renameListWindow.NewListName;
                UpdateListUI();
            }
        }        

        private void EditTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedTask == null)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            EditTaskWindow editTaskWindow = new EditTaskWindow();
            if (editTaskWindow.ShowDialog() == true)
            {
                selectedTask.Title = editTaskWindow.Title;
                selectedTask.Description = editTaskWindow.Description;
                selectedTask.Deadline = editTaskWindow.Deadline;
                DisplayTasks(selectedList);
            }
        }
        
        private void AddListButton_Click(object sender, RoutedEventArgs e)
        { 

            CreateListWindow createListWindow = new CreateListWindow();
            if (createListWindow.ShowDialog() == true)
            {
                TaskList newList = new TaskList { Name = createListWindow.ListName};
                _taskLists.Add(newList);
                AddListToUI(newList);
            }
        }
   
        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedButton != null)
            {
                selectedButton.ClearValue(Button.BackgroundProperty);
                selectedButton.ClearValue(Button.ForegroundProperty);
            }

            selectedButton = sender as Button;
            selectedButton.Background = (Brush)FindResource("SelectedBackgroundBrush");
            selectedButton.Foreground = (Brush)FindResource("SelectedForegroundBrush");

            selectedList = (TaskList)selectedButton.Tag;
            DisplayTasks(selectedList);
        }

       
        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedTask == null)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            selectedList.Tasks.Remove(selectedTask);
            selectedTask = null;
            DisplayTasks(selectedList);
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedList == null)
            {
                MessageBox.Show("Please select a list first.");
                return;
            }

            CreateTaskWindow createTaskWindow = new CreateTaskWindow();
            if (createTaskWindow.ShowDialog() == true)
            {
                TaskItem newTask = new TaskItem
                {
                    Title = createTaskWindow.Title,
                    Description = createTaskWindow.Description,
                    Deadline = createTaskWindow.Deadline
                };
                selectedList.Tasks.Add(newTask);
                DisplayTasks(selectedList);
            }
        }

        private void SaveTaskLists()
        {
            string json = JsonConvert.SerializeObject(_taskLists, Formatting.Indented);
            File.WriteAllText("taskLists.json", json);
        }

        private void LoadTaskLists()
        {
            try
            {
                if (File.Exists("taskLists.json"))
                {
                    string json = File.ReadAllText("taskLists.json");
                    _taskLists = JsonConvert.DeserializeObject<List<TaskList>>(json);
                    UpdateListUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading task lists: {ex.Message}");
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            SaveTaskLists();
            base.OnClosing(e);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {         
            Close();        
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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