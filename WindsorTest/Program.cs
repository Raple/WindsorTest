using Castle.MicroKernel;
using Castle.Windsor;

namespace WindsorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = WindsorInit.GetContainer();
            ICharge charge = container.Resolve<ICharge>(new Arguments(new { }));           
            charge.ClientCharge();
        }
    }

   
}
