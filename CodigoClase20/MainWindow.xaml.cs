using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodigoClase20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            //Asumiendo que esto va venir desde base de datos
            string imagePath = "https://w7.pngwing.com/pngs/241/840/png-transparent-computer-icons-student-school-student-angle-people-logo-thumbnail.png";

            var students = new List<Student>
            {
                new Student { Name = "John Doe", Grade = 85, ImagePath=imagePath },
                new Student { Name = "Jane Smith", Grade = 62,ImagePath= imagePath },
                new Student { Name = "Sam Brown", Grade = 74,ImagePath =imagePath},
                new Student { Name = "Lisa White", Grade = 59 , ImagePath = imagePath}
            };

            studentListView.ItemsSource = students;
        }
    }
}