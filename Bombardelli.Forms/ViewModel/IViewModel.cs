using System;
using System.ComponentModel;

namespace Bombardelli.Forms.ViewModel
{
    public interface IViewModel : INotifyPropertyChanged
    {
        event EventHandler ViewModelLoaded;
        void OnViewModelLoaded();
    }
}
