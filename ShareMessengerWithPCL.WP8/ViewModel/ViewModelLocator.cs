using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using ShareMessengerWithPCL.PCL;
using ShareMessengerWithPCL.PCL.Interface;

namespace ShareMessengerWithPCL.WP8.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IHelloWorldService>(
                () => new HelloWorldService(Messenger.Default));

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
    }
}
