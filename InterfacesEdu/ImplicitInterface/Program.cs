using System;

/// <summary>
/// 10.2.4 Реализуйте явно следующий интерфейс и вызовите его метод в классе Program.
/// </summary>
namespace ImplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Build();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        public void Build()
        {
            Console.WriteLine("Неявно реализован метод Build интерфейса IWorker");
        }
    }
}
