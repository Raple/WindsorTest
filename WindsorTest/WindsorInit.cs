using Castle.Windsor;
using Castle.Windsor.Installer;

namespace WindsorTest
{
    public class WindsorInit
    {
        private static WindsorContainer _container;
        public static WindsorContainer GetContainer()
        {
            if (_container == null)
            {
                _container = new WindsorContainer();
                _container.Install(FromAssembly.This());
            }
            return _container;
        }

        public void CloseContext()
        {
            _container.Dispose();
        }
    }
}
