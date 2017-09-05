using System;
using System.ComponentModel;
using System.Threading;

namespace Bombardelli.Forms.ViewModel
{
    public abstract class ViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ViewModelLoaded;

        public static SynchronizationContext UISynchronizationContext { get; set; }

        public virtual void OnViewModelLoaded()
        {
            ViewModelLoaded?.Invoke(this, null);
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
