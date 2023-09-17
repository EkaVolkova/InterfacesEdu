using System;

/// <summary>
/// 10.2.2 Используя теоретический материал из данного юнита, постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:
/// 10.2.4 Реализуйте явно следующий интерфейс и вызовите его метод в классе Program 
/// </summary>
namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Явно реализован метод Write интерфейса IWriter");
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Явно реализован метод Build интерфейса IWorker");
        }
    }

}
