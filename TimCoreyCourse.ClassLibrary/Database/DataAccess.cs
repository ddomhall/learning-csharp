using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;

namespace TimCoreyCourse.ClassLibrary.Database
{
    public class DataAccess
    {
        private string _connStr;

        public DataAccess(string connStr)
        {
            _connStr = connStr;
        }
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connStr)
        {
            using (IDbConnection connection = new SqlConnection(connStr))
            {
                return connection.Query<T>(sqlStatement, parameters).ToList();
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters, string connStr)
        {
            using (IDbConnection connection = new SqlConnection(connStr))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }

        public List<DBPerson> GetAllPeople()
        {
            string sql = "select Id, Name from dbo.People";
            return LoadData<DBPerson, dynamic>(sql, new { }, _connStr);
        }

        public DBFullPerson GetFullPersonById(int id)
        {
            string sql = @"select p.Id, p.Name, a.Name as Address, e.Name as Employer from People p
                            join Addresses a on a.Id = p.AddressId
                            join Employers e on e.Id = p.EmployerId
                            where p.Id = @Id";
            return LoadData<DBFullPerson, dynamic>(sql, new { Id = id }, _connStr).FirstOrDefault();
        }

        public void CreateDBPerson(DBFullPerson person)
        {
            //check if address exists, add if not, otherwise save and get id
            string sql = "select Id from dbo.Addresses where Name = @Name;";
            var addressId = LoadData<int, dynamic>(sql, new { Name = person.Address }, _connStr).FirstOrDefault();

            if (addressId == 0)
            {
                //save address
                sql = "insert into dbo.Addresses (Name) values (@Name);";
                SaveData<dynamic>(sql, new {Name = person.Address}, _connStr);

                sql = "select Id from dbo.Addresses where Name = @Name;";
                addressId = LoadData<int, dynamic>(sql, new { Name = person.Address }, _connStr).FirstOrDefault();
            }

            //check if employer exists, add if not, otherwise save and get id
            sql = "select Id from dbo.Employers where Name = @Name;";
            var employerId = LoadData<int, dynamic>(sql, new { Name = person.Employer }, _connStr).FirstOrDefault();

            if (employerId == 0)
            {
                //save employer
                sql = "insert into dbo.Employers (Name) values (@Name);";
                SaveData<dynamic>(sql, new {Name = person.Employer}, _connStr);

                sql = "select Id from dbo.Employers where Name = @Name;";
                employerId = LoadData<int, dynamic>(sql, new { Name = person.Employer }, _connStr).FirstOrDefault();
            }

            //save person
            sql = "insert into dbo.People (Name, AddressId, EmployerId) values (@Name, @AddressId, @EmployerId);";
            SaveData<DBPerson>(sql, new DBPerson()
            {
                Name = person.Name,
                AddressId = addressId,
                EmployerId = employerId
            }, _connStr);
        }
    }
}
