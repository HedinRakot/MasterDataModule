using MasterDataModule.Contracts.Entities.Configuration;

namespace MasterDataModule.Contracts.Managers.Configuration
{
    /// <summary>
    /// </summary>
    public partial interface IUserManager
    {
        /// <summary>
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        User GetByLogin(string userLogin);
    }
}