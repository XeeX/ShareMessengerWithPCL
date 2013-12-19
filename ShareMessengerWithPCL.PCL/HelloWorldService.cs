using GalaSoft.MvvmLight.Messaging;
using ShareMessengerWithPCL.PCL.Interface;

namespace ShareMessengerWithPCL.PCL
{
    /*
     *  The sample was orignilay created for a blog post presenting the OverrideDeault method.
     *  This is why I'll let the usage of this one in comment but in real life
     *  you should use a private member like _messenger here.
     */

    public class HelloWorldService : IHelloWorldService
    {
        private readonly IMessenger _messenger;
        public HelloWorldService(IMessenger messenger)
        {
            //Messenger.OverrideDefault(messenger);
            _messenger = messenger;
        }

        public void SayHello()
        {
            //Messenger.Default.Send("Hello World !");
            _messenger.Send("Hello World !");
        }
    }
}
