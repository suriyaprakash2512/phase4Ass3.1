namespace UserLoginLib
{
    public class Login
    {

        public static string Authenicate(string username, string password)
        {
            string result;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "You must provide username and password";
            }
            else if (username == "sam" && password == "sam@1256")

            {
                result = "valid user";
            }
            else
            {
                result = "invalid user credential";
            }
            return result;

        }
    }
}
