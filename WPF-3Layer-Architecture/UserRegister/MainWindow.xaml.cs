using System.Data;
using System.Windows;
using UserReg.logic;
namespace UserRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataSet data;
        private userBLogic user;
        public MainWindow()
        {
            InitializeComponent();
             user = new userBLogic();
            data = user.GetDataset();
            CmbSelect.DisplayMemberPath = "name";
            CmbSelect.SelectedValuePath = "userid";
            CmbSelect.ItemsSource = data.Tables[0].DefaultView;
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
                user = new userBLogic();
                data = user.GetDataset();
                CmbSelect.ItemsSource = null;
                CmbSelect.DisplayMemberPath = "name";
                CmbSelect.SelectedValuePath = "userid";
                CmbSelect.ItemsSource = data.Tables[0].DefaultView;
            }
            
        }

        private void Clearbnt_Click(object sender, RoutedEventArgs e)
        {
            Usernamebox.Text= "";
            useragebox.Text = "";
            CmbSelect.ItemsSource = null;
        }

        private void Updatebnt_Click(object sender, RoutedEventArgs e)
        {
            if (CmbSelect.SelectedValue != null)
            {
                string userid = CmbSelect.SelectedValue.ToString();
                if (user.UpdateData(Usernamebox.Text, useragebox.Text, userid) == -1)
                {
                    MessageBox.Show("Update failed");
                }
                else
                {
                    MessageBox.Show("Update successful");
                    user = new userBLogic();
                    data = user.GetDataset();
                    CmbSelect.ItemsSource=null;
                    CmbSelect.DisplayMemberPath = "name";
                    CmbSelect.SelectedValuePath = "userid";
                    CmbSelect.ItemsSource = data.Tables[0].DefaultView;
                }
            }
            else
            {
                MessageBox.Show("Select Name from ComboBox");
            }
        }

        private void CmbSelect_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DataRowView row = CmbSelect.SelectedItem as DataRowView;
            if (row!=null)
            { 
                Usernamebox.Text = row.Row.Field<string>("name");
                useragebox.Text = row.Row.Field<Decimal>("age").ToString();
            }

         }
    }
}