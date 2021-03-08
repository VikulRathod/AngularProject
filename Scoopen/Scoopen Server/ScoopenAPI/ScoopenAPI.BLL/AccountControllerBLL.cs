using ScoopenAPI.DAL;
using ScoopenAPI.Models.Account;

namespace ScoopenAPI.BLL
{
    public class AccountControllerBLL
    {
        IAccountControllerDAL _iAccountControllerDAL;

        public AccountControllerBLL(IAccountControllerDAL iAccountControllerDAL)
        {
            _iAccountControllerDAL = iAccountControllerDAL;
        }

        public int RegisterUser(string firstName, string lastName, string mobile, string email, string otp)
        {
            return _iAccountControllerDAL.RegisterUser(firstName, lastName, mobile, email, otp);
        }

        public int ActivateRegisteredUser(string mobile, string password, string email, string otp)
        {
            return _iAccountControllerDAL.ActivateRegisteredUser(mobile, password, email, otp);
        }

        public void SaveOtpInDatabase(string mobile, string email, string otp)
        {
            _iAccountControllerDAL.SaveOtpInDatabase(mobile, email, otp);
        }

        public string GetOtpFromDatabase(string mobile, string email)
        {
            return _iAccountControllerDAL.GetOtpFromDatabase(mobile, email);
        }

        public User Authenticate(string username, string password)
        {
            return _iAccountControllerDAL.Authenticate(username, password);
        }

        public int ChangePasswordOnFirstLogin(string userName, string currentPassword, string newPassword)
        {
            return _iAccountControllerDAL.ChangePasswordOnFirstLogin(userName, currentPassword, newPassword);
        }
    }
}
