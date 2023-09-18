using System;

/// <summary>
/// Даны три интерфейса:
///     public interface ICreatable 
///     {
///         void Create();
///     }
///
///     public interface IDeletable
///     {
///         void Delete();
///     }
///
///     public interface IUpdatable
///     {
///         void Update();
///     }
/// Создайте класс Entity и выполните в нём множественную неявную реализацию данных интерфейсов.
/// </summary>
namespace MultiplyInterfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }
    class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
