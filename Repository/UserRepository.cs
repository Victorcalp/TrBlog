using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repository
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;
        public UserRepository(SqlConnection connection){
            _connection = connection;
        }
        public IEnumerable<User> GetAll()
        => _connection.GetAll<User>();
        public User GetUser(int id)
        => _connection.Get<User>(id);
        public void CreateUser(User user)
        => _connection.Insert(user);
        public void UpdateUser(User user)
        => _connection.Update(user);
        public void Delete(User user)
        => _connection.Delete(user);
        public void Delete(int id){
            var user = _connection.Get<User>(id);
            _connection.Delete<User>(user);
        }
    }
}