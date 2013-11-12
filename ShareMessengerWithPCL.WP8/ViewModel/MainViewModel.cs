using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using ShareMessengerWithPCL.PCL.Interface;

namespace ShareMessengerWithPCL.WP8.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Message { get; set; }

        public MainViewModel(IHelloWorldService helloWorldService)
        {
            Messenger.Default.Register<string>(this, s => Message = s);
            
            helloWorldService.SayHello();
        }
    }
}
