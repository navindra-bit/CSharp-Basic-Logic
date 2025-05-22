using System.Windows;
using UserReg.logic;
namespace UserRegister
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

        private void regbnt_Click(object sender, RoutedEventArgs e)
        {
            userBLogic logic = new userBLogic();
            if (logic.Interdata(Usernamebox.Text, useragebox.Text) == -1)
            {
                MessageBox.Show("Registration failed");
            }
            else
            {
                MessageBox.Show("Registration successful");
            }
            
        }

        private void Clearbnt_Click(object sender, RoutedEventArgs e)
        {
            Usernamebox.Text= "";
            useragebox.Text = "";
        }
    }
}