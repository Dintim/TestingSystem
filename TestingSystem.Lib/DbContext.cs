using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace TestingSystem.Lib
{
    public class DbContext
    {
        private string _path;

        public DbContext(string path)
        {
            _path = path;
        }

        public bool AddUser(User user)
        {
            try
            {
                using (var db=new LiteDatabase(_path))
                {
                    var users = db.GetCollection<User>("users");                    
                    users.Insert(user);

                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }


        public bool AddTest(Test test)
        {
            try
            {
                using (var db = new LiteDatabase(_path))
                {
                    var users = db.GetCollection<Test>("tests");
                    users.Insert(test);

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
