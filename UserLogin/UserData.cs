
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UserLogin.Enums;

namespace UserLogin
{
    public static class UserData
    {
        static private List<User> _testUser = new List<User>();
        static public List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set
            { }
        }

        static private void ResetTestUserData()
        {
            if (_testUser == null)
            {
                TestUser = new List<User>();
                User admin = new User();
                admin.Username = "admin";
                admin.Password = "password";
                admin.FakNum = "00000";
                admin.Role = (int)Enums.UserRoles.ADMIN;
                admin.CreatedDate = DateTime.Now;
                admin.ActiveTime = DateTime.MaxValue;
                User student_1 = new User();
                student_1.Username = "student1";
                student_1.Password = "password1";
                student_1.FakNum = "11111";
                student_1.Role = (int)Enums.UserRoles.STUDENT;
                student_1.CreatedDate = DateTime.Now;
                student_1.ActiveTime = DateTime.MaxValue;
                User student_2 = new User();
                student_2.Username = "student2";
                student_2.Password = "password2";
                student_2.FakNum = "22222";
                student_2.Role = (int)Enums.UserRoles.STUDENT;
                student_2.CreatedDate = DateTime.Now;
                student_2.ActiveTime = DateTime.MaxValue;
                TestUser.Add(student_2);
                TestUser.Add(student_1);
                TestUser.Add(admin);
            }
            
        }
        public static User IsUserPassCorrect(string username, string password)
        {
            User user = (from account in TestUser where account.Username.Equals(username, StringComparison.Ordinal) && account.Password.Equals(password, StringComparison.Ordinal) select account).FirstOrDefault();
            
            return user;
        }

        //internal static User IsUserPassCorrect(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        public static User GetUserByUsername(string username)
        {
        
        foreach (User user in TestUser)
          {
            if (username.Equals(user.Username, StringComparison.Ordinal))
            {
                return user;
            }
          }
        return null;
        }

        public static void SetUserActiveTimeTo(string username, DateTime newActiveTime)
        {
            foreach (User user in TestUser)
            {
                if (user.Username == username)
                {
                    user.ActiveTime = newActiveTime;
                    Logger.LogActivity("Changed the active time of user :" + username);
                }
            }
        }
        public static void SeeAllUsers()
        {
            foreach (User user in TestUser)
            {
            Console.WriteLine(user.Username);
            }
        }

        public static void ChangeUserRole(string username, string role)
        {
            foreach (User user in TestUser)
            {
                if (user.Username == username)
                {
                    user.Role = (int)Enums.UserRoles.Parse(typeof(UserRoles), role);
                    Logger.LogActivity("Changed the role of user : " + username + " to " + role);
                }
            }
        }

    }
}
