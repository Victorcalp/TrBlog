
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repository
{
    //só aceita T se for uma classe (where T : class)
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection){
            _connection = connection;
        }
        public IEnumerable<T> GetAll()
        => _connection.GetAll<T>();
        public T GetId(int id)
        => _connection.Get<T>(id);
        public void Create(T value)
        => _connection.Insert(value);
        public void Update(T value)
        => _connection.Update(value);
        public void Delete(T value)
        => _connection.Delete(value);
        public void Delete(int id){
            var value = _connection.Get<T>(id);
            _connection.Delete<T>(value);
        }
    }
}