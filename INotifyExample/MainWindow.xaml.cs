using System.Windows;

namespace INotifyExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person person { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            person = new Person { FirstName = "Hi", LastName = "There" };
            this.DataContext = person;
        }
    }
}
