using GalaSoft.MvvmLight.Messaging;
using ShareMessengerWithPCL.PCL.Interface;

namespace ShareMessengerWithPCL.PCL
{
    public class HelloWorldService : IHelloWorldService
    {
        public HelloWorldService(IMessenger messenger)
        {
            Messenger.OverrideDefault(messenger);
        }

        public void SayHello()
        {
            Messenger.Default.Send("Hello World !");
        }
    }
}
