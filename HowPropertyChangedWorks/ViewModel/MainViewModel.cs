using GalaSoft.MvvmLight;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace HowPropertyChangedWorks.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
     
        static Random rand = new Random();

        private int randomNumber = 100;
        DispatcherTimer timer = new DispatcherTimer();

       

        public int RandomNumber
        {
            get { return randomNumber; }
            set { randomNumber = value; RaisePropertyChanged();  }
        }

        public int CallerMemberName { get; private set; }

        public MainViewModel()
        {
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += Timer_Tick;
            timer.Start();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RandomNumber = rand.Next(0,100);
        }

        //public void OnNotification([CallerMemberName] string propertyname = null)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        //    }
        //}
    }
}