using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using ShareMessengerWithPCL.PCL.Interface;

namespace ShareMessengerWithPCL.WP8.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IHelloWorldService helloWorldService)
        {
            Messenger.Default.Register<string>(this, s => MessageBox.Show(s));

            helloWorldService.SayHello();
        }
    }
}
