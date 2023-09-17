using System;

/// <summary>
/// 10.1.4 Класс Manager реализует интерфейс IManager. Попытайтесь самостоятельно определить интерфейс IManager, исходя из данного кода.
/// </summary>
namespace InterfacesEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IManager
    {
        public void Create();
        public void Read();
        public void Update();

        public void Delete();
    }
    public class Manager : IManager
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }

}
