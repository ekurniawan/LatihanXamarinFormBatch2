using LatihanXamarinApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace LatihanXamarinApp.DAL
{
    public class DataAccess
    {
        private SQLiteConnection conn;
        public DataAccess()
        {
            string dbName = "MyDb.db3";
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, dbName);
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            //return conn.Query<Employee>("select * from Employee order by EmpName asc");
            var results = from e in conn.Table<Employee>()
                          orderby e.EmpName
                          select e;

            //var results = conn.Table<Employee>().OrderBy(e => e.EmpName).ToList();
            return results.ToList();
        }
    }
}
