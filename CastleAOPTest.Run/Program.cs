using System;
using CastleAOPTest.AOP;
using Castle.DynamicProxy;

namespace CastleAOPTest.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】  
            SimpleInterceptor interceptor = new SimpleInterceptor();//实例化【拦截器】  

            //使用【代理类生成器】创建Person对象，而不是使用new关键字来实例化  
            Person person = generator.CreateClassProxy<Person>(interceptor);


            Console.WriteLine("当前类型:{0},父类型:{1}", person.GetType(), person.GetType().BaseType);
            Console.WriteLine();


            person.SayHello();//跟普通调用没有两样吧？  
            Console.WriteLine();

            person.SayName("福建");//跟普通调用没有两样吧？  
            Console.WriteLine();

            person.SayOther();//它不是虚方法，无法拦截。待会检测输出情况就知道了。     



            Console.ReadLine();
        }
    }
}
