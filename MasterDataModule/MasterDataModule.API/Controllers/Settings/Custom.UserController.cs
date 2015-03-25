using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts.Entities.Configuration;
using TuevSued.V1.IT.FE.CoreBase;

namespace MasterDataModule.API.Controllers.Settings
{
    public partial class UsersController
    {
        protected void ExtraModelToEntity(User entity, UserModel model, ActionTypes actionType)
        {
            entity.Password = StringHelper.GetMD5Hash(model.password);
        }
    }
}
