using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repository
{
    public class RoleRepository
    {
        private readonly SqlConnection _connection;
        public IEnumerable<Role> GetAll()
        => _connection.GetAll<Role>();
        public Role Get(int id)
        => _connection.Get<Role>(id);
        public void Create(Role role)
        => _connection.Insert(role);
        public void Update(Role role)
        => _connection.Update(role);
        public void Delete(int id)
        {
            var role = _connection.Get<Role>(id);
            _connection.Delete(role);
        }
    }
}