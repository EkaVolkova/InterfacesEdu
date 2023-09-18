using System;

/// <summary>
/// Создайте класс FileManager и выполните в нём множественную реализацию интерфейсов:
///     public interface IWriter 
///     {
///         void Write();
///     }
///     
///     public interface IReader
///     {
///         void Read();
///     }
/// 
///     public interface IMailer
///     {
///         void SendEmail();
///     }
/// 
/// </summary>
namespace MultiplyInterfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }
    class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
