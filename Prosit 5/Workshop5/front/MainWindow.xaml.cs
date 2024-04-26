using System.Diagnostics;
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
    
namespace front
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void OnClick1(object sender, RoutedEventArgs e)
        {
            Process notepadProcess = new Process

            {

                StartInfo = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = "C:\\Windows\\win.ini"
                }
            };

            
            notepadProcess.Start();

        }

        
        public MainWindow()
        {
            InitializeComponent();
            ChargerProcessus();
        }


        private void ChargerProcessus()
        {
            Process[] processus = Process.GetProcesses();

            processGrid.ItemsSource = processus;
        }

        }
    }
