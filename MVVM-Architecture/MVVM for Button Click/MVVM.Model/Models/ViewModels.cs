using MVVM.Model.Helper;

namespace MVVM.Model.Models
{
    public class ViewModels : Notify
    {
        public ViewModels()
        {
            _isValid = "";
            _status = "";
            _color = "";
        }

        private string _isValid;
        public string isValid
        {
            get => _isValid;
            set
            {
                _isValid = value;
                onPropertyChanged();
                
            }
        }
        private string _status;
        public string status
        {
            get => _status;
            set
            {
                _status = value;
                onPropertyChanged();
            }
        }
        private string _color;
        public string color
        {
            get => _color;
            set
            {
                _color = value;
                onPropertyChanged();
            }
        }
    }
    
}
