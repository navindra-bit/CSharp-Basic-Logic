using MVVM.Model.Models;
using MVVM.ModelView.Helper;

namespace MVVM.ModelView
{
    public class ViewModelLogic
    {
        public ButtonCommand ButtonCommand { get; set; }

        public ViewModels ViewModels { get; set; }
        public ViewModelLogic()
        {
            ButtonCommand = new ButtonCommand(Regiter);
            ViewModels = new ViewModels();
            ViewModels.isValid = "Yes";
        }
        public void Regiter()
        {
            if(ViewModels.isValid.ToUpper() == "YES")
            {
                ViewModels.status = "Registration successful";
                ViewModels.color = "Green";
            }
            else
            {
                ViewModels.status = "Registration failed";
                ViewModels.color = "Red";
            }
        }

    }
}
