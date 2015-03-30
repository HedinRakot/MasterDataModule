using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts.Entities.Configuration;
using System.Web.Http;
using TuevSued.V1.IT.FE.CoreBase;

namespace MasterDataModule.API.Controllers.Settings
{
    public partial class UsersController
    {
        public IHttpActionResult Patch(PasswordModel model)
        {
            var entity = Manager.GetById(model.Id);
            if (entity == null)
                return NotFound();

            ValidatePassword(model);

            if (ModelState.IsValid)
            {
                entity.Password = StringHelper.GetMD5Hash(model.password);

                Manager.SaveChanges();

                return Ok(model);
            }
            else
                return BadRequest(ModelState);
        }

        protected override void Validate(UserModel model, User entity, ActionTypes actionType)
        {
            if (!string.Equals(model.login, entity.Login, System.StringComparison.InvariantCultureIgnoreCase))
            {
                if (Manager.GetByLogin(model.login) != null)
                    ModelState.AddModelError("model.login", "login-unique");
            }

            if (actionType == ActionTypes.Add)
                ValidatePassword(model);
        }

        private void ValidatePassword(IPasswordModel model)
        {
            if (string.IsNullOrEmpty(model.password))
                ModelState.AddModelError("model.password", "required");

            if (string.IsNullOrEmpty(model.passwordConfirmation))
                ModelState.AddModelError("model.passwordConfirmation", "required");

            if (model.password != model.passwordConfirmation)
            {
                ModelState.AddModelError("model.password", "password-confirmation-match");
                ModelState.AddModelError("model.passwordConfirmation", "password-match");
            }
        }

        protected void ExtraModelToEntity(User entity, UserModel model, ActionTypes actionType)
        {
            entity.Password = StringHelper.GetMD5Hash(model.password);
        }
    }
}
