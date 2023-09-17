using System;

/// <summary>
/// 10.2.2 Используя теоретический материал из данного юнита, постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:
/// </summary>
namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
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

}
