using ISU_BT_PROJECT.Models;

namespace ISU_BT_PROJECT.Data
{
    public interface ILogin
    {
        Task<IEnumerable<BTUser>> getuser();
        Task<BTUser> AuthenticateUser(string username, string password);
    }
}
