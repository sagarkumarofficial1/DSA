using DSA.SOLIDS;
using DSA.Stack;
using System;
using Unity;
using Unity.Injection;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpecialStack s = new SpecialStack();
            //s.Push(10);
            //s.Push(5);
            //s.Push(20);
            //s.Push(30);
            //s.Push(2);
            //s.Pop();
            //s.Pop();
            //int[] arr = { 1, 4, 5, 3, 66, 3, 2, 4 };
            //Stack.Stack.NextGreateValue(arr);
            //Console.WriteLine(s.GetMin());
            //DSA.Stack.Stack.run();
            //Console.WriteLine(BraketMatcher.Check("((a+b) + ((a)+b))".Replace(" ","")));

            //CustomerBussinessLogin CBL = new CustomerBussinessLogin();
            //var output = CBL.GetCustname();
            //Console.WriteLine(output);

            //Unit Container
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>("BMW");
            container.RegisterType<ICar, Audi>();

            container.RegisterType<Driver>("Driver", new InjectionConstructor(container.Resolve<ICar>("BMW")));

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            Driver driver2 = container.Resolve<Driver>("Driver");
            driver2.RunCar();

            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi);
            Driver driver3 = container.Resolve<Driver>();
            driver3.RunCar();
            driver3.RunCar();

            Console.Read();
        }
    }
}
