using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM.Model.Helper
{
    public class Notify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void onPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
