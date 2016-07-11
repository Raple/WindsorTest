using System;

namespace WindsorTest
{
    class Commen
    {
    }

    public interface IPrinter
    {
        void RegPrint(int regID);
        void ClientPrint(int chargeID);
    }

    public interface ICharge
    {
        void ClientCharge();
    }

    public class APrinter : IPrinter
    {
        public void ClientPrint(int chargeID)
        {
            Console.WriteLine("A打印" + chargeID.ToString());
        }

        public void RegPrint(int regID)
        {
            Console.WriteLine("A打印" + regID.ToString());
        }
    }
  
    public class BCharge : ICharge
    {
        [Castle.Components.DictionaryAdapter.Key("B")]
        public IPrinter print { set; get; }
        public void ClientCharge()
        {
            Console.WriteLine("B挂号");
            print.ClientPrint(1000);
        }
    }

    public class ACharge : ICharge
    {
        public IPrinter print { set; get; }
        public void ClientCharge()
        {
            Console.WriteLine("A挂号");
            print.ClientPrint(1000);
        }
    }    
}
