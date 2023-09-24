using System;

/// <summary>
/// 10.4.4 Определены два класса:
/// 
///     public class User
///     {
///
///     }
///
///     public class Account : User
///     {
///
///     }
///     Определён обобщённый интерфейс:

///     public interface IUpdater<inT>
///     {
///         void Update(T entity);
///     }
///     
/// Реализуйте данный интерфейс в классе UserService, и продемонстрируйте контравариацию интерфейса в базовом классе Program.
/// </summary>
namespace CovarianceContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            IUpdater<Account> updater1 = new UserService();
            IUpdater<User> updater2 = new UserService();
            updater2.Update(new User());
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
    class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
