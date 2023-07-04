using System.ComponentModel;

namespace OracleScan.Models
{
    public class ProxyCount : INotifyPropertyChanged
    {
        private int total;
        private int banned;
        private int error;

        private static readonly object _lockBan = new();
        private static readonly object _lockError = new();
        private static readonly object _lockTotal = new();

        public ProxyCount()
        {
            total = 0;
            banned = 0;
            error = 0;
        }

        public int Total
        {
            get => total;
            set
            {
                lock (_lockTotal) { total = value; }
                NotifyPropertyChanged(nameof(Total));
            }
        }

        public int Banned
        {
            get => banned;
            set
            {
                lock (_lockBan) { banned = value; }
                NotifyPropertyChanged(nameof(Banned));
            }
        }

        public int Error
        {
            get => error;
            set
            {
                lock (_lockError) { error = value; }
                NotifyPropertyChanged(nameof(Error));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
