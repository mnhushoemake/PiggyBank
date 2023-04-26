using static PiggyBank.Models.RequestModel;

namespace PiggyBank.Models
{
    public class UserModel
    {

        public int UserId { get; set; } = 0;
        public string FirstName{ get; set; } = "";
        public string LastName { get; set; } = "";
        public string Password { get; set; } = "";
        
    }
}
