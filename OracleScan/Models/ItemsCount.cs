using System.ComponentModel;

namespace OracleScan.Models
{
    public class ItemsCount : INotifyPropertyChanged
    {
        private int total;
        private int success;
        private int failed;
        private int scanned;

        private static readonly object _lockSuccess = new();
        private static readonly object _lockFailed = new();
        private static readonly object _lockScan = new();

        public ItemsCount()
        {
            total = 0;
            success = 0;
            failed = 0;
            scanned = 0;
        }

        public int Total
        {
            get => total;
            set
            {
                total = value;
                NotifyPropertyChanged(nameof(Total));
            }
        }

        public int Success
        {
            get => success;
            set
            {
                lock (_lockSuccess) { success = value; }
                NotifyPropertyChanged(nameof(Success));
            }
        }

        public int Failed
        {
            get => failed;
            set
            {
                lock (_lockFailed) { failed = value; }
                NotifyPropertyChanged(nameof(Failed));
            }
        }

        public int Scanned
        {
            get => scanned;
            set
            {
                lock (_lockScan) { scanned = value; }
                NotifyPropertyChanged(nameof(Scanned));
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
