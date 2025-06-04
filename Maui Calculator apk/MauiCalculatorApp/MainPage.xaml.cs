using MauiCalculatorApp.Models;

namespace MauiCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        string Firstnum = "";
        string secondnum = "";
        public EnumType? enumType = null;
        string opertype = "";
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                if (enumType == null)
                {
                    Firstnum += button.Text;
                }
                else
                {
                    secondnum += button.Text;
                }
                Display.Text = Firstnum + opertype + secondnum;
            }
            catch (Exception)
            {
                Display.Text = "Code Error";
            }


        }
        private void CalcOper(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "+")
            {
                enumType = EnumType.Add;
                opertype = "+";
            }
            else if (button.Text == "-")
            {
                enumType = EnumType.Sub;
                opertype = "-";
            }
            else if (button.Text == "*")
            {
                enumType = EnumType.Mul;
                opertype = "*";
            }
            else
            {
                enumType = EnumType.Div;
                opertype = "/";
            }

           
        }
        private void OnCalc(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(Firstnum);
                int second = Convert.ToInt32(secondnum);

                switch (enumType)
                {
                    case EnumType.Add:
                        Display.Text = (first + second).ToString();
                        break;
                    case EnumType.Sub:
                        Display.Text = (first - second).ToString();
                        break;
                    case EnumType.Mul:
                        Display.Text = (first * second).ToString();
                        break;
                    case EnumType.Div:
                        if (second == 0)
                        {
                            Display.Text = "Zero cannot be divided";
                            break;
                        }
                        else
                        {
                            Display.Text = (first / second).ToString();
                            break;
                        }
                    default:
                        Display.Text = "Code Error";
                        break;
                }
                Firstnum = "";
                secondnum = "";
                enumType = null;
                opertype = "";
            }
            catch (Exception)
            {
                Display.Text = "Code Error";
            }
        }
        private void OnClear(object sender, EventArgs e)
        {
            Firstnum = "";
            secondnum = "";
            enumType = null;
            Display.Text ="";
            opertype = "";
        }
    }

}
