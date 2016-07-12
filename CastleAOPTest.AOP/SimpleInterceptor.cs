
using System;
using Castle.Core.Interceptor;

/// <summary>
/// 重写拦截器方法
/// </summary>
namespace CastleAOPTest.AOP
{
    public class SimpleInterceptor: StandardInterceptor
    {
        protected override void PreProceed(IInvocation invocation)
        {
            Console.WriteLine("调用前的拦截器，方法名是：{0}。", invocation.Method.Name);
            base.PreProceed(invocation);

        }

        protected override void PerformProceed(IInvocation invocation)
        {
            Console.WriteLine("拦截的方法返回时调用的拦截器，方法名是：{0}。", invocation.Method.Name);
            base.PerformProceed(invocation);

        }


        protected override void PostProceed(IInvocation invocation)
        {
            Console.WriteLine("调用后的拦截器，方法名是：{0}。", invocation.Method.Name);
            base.PostProceed(invocation);

        }
    }
}
