using SQLite;
using sqsqpractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sqsqpractise.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<StudentClass>();

        }

        public List<StudentClass> GetAllStudents() {
        
        Init();
            return conn.Table<StudentClass>().ToList();  
        }

        public void AddStudent(StudentClass student)
        {

            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void DeleteStudent(StudentClass student_ID) {


            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new StudentClass { ID = student_ID });
        
        }




    }
}
