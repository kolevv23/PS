
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserLogin
{
    public class LoginValidation
    {

        public static Enums.UserRoles currentUserRole;
        public static string currentUserName;
        public String username;
        private String password;
        private String errorMessage;
        private ActionOnError _errorfunc;

        public delegate void ActionOnError(string errorMsg);


        public LoginValidation(String username, String password, ActionOnError actionOnError)
        {

            this._errorfunc = actionOnError;
            this.username = username;
            this.password = password;
        }

        public Boolean ValidateUserInput(User user)
        {
            Boolean emptyUserName;
            emptyUserName = username.Equals(String.Empty);

            if (emptyUserName == true)
            {
                currentUserRole = Enums.UserRoles.ANONYMOUS;
                errorMessage = "Username not set";
                _errorfunc(errorMessage);
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = password.Equals(String.Empty);

            if (emptyUserName == true)
            {
                currentUserRole = Enums.UserRoles.ANONYMOUS;
                errorMessage = "Username not set";
                _errorfunc(errorMessage);
                return false;
            }
            if (username.Length < 5)
            {
                currentUserRole = Enums.UserRoles.ANONYMOUS;
                errorMessage = "Username is too short";
                _errorfunc(errorMessage);
                return false;
            }
            if (password.Length < 5)
            {
                currentUserRole = Enums.UserRoles.ANONYMOUS;
                errorMessage = "Password is too short";
                _errorfunc(errorMessage);
                return false;
            }
            User userFromUserData = UserData.IsUserPassCorrect(username, password);
            if (user == null)
            {
                currentUserRole = Enums.UserRoles.ANONYMOUS;
                errorMessage = "User not found";
                _errorfunc(errorMessage);
                return false;
            }
            user.Username = userFromUserData.Username;
            user.Password = userFromUserData.Password;
            user.FakNum = userFromUserData.FakNum;
            user.Role = userFromUserData.Role;
            currentUserName = user.Username;
            currentUserRole = (Enums.UserRoles)user.Role;
            Logger.LogActivity("Successful Login");
            return true;
        
    }
    }
}
