using System.Linq;
using System.Linq.Dynamic;
using System.Web.Http;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using TuevSued.V1.IT.FE.CoreBase;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] {PermissionTypes.Users})]
    public class UsersController : ClientApiController<UserModel, User, int, IUserManager>
    {
        public UsersController(IUserManager manager)
            : base(manager)
        {
        }

        public IHttpActionResult Patch(PasswordModel model)
        {
            var entity = Manager.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }

            ValidatePassword(model);

            if (ModelState.IsValid)
            {
                entity.Password = StringHelper.GetMD5Hash(model.password);

                Manager.SaveChanges();

                //TODO Logger.AddInformation(@"У пользователя ""{}"" был изменен пароль.", entity.Name);

                return Ok(model);
            }
            return BadRequest(ModelState);
        }

        protected override void Validate(UserModel model, User entity, ActionTypes actionType)
        {
            if (!string.Equals(model.login, entity.Login, System.StringComparison.InvariantCultureIgnoreCase))
            {
                if (Manager.GetByLogin(model.login) != null)
                {
                    ModelState.AddModelError("model.login", "login-unique");
                }
            }

            if (actionType == ActionTypes.Add)
            {
                ValidatePassword(model);
            }
        }

        private void ValidatePassword(IPasswordModel model)
        {
            if (string.IsNullOrEmpty(model.password))
            {
                ModelState.AddModelError("model.password", "required");
            }

            if (string.IsNullOrEmpty(model.passwordConfirmation))
            {
                ModelState.AddModelError("model.passwordConfirmation", "required");
            }

            if (model.password != model.passwordConfirmation)
            {
                ModelState.AddModelError("model.password", "password-confirmation-match");
                ModelState.AddModelError("model.passwordConfirmation", "password-match");
            }
        }

        protected override void EntityToModel(User entity, UserModel model)
        {
            model.role = entity.MasterDataRoleId.Value;
            model.login = entity.Login;
            model.name = entity.Name;
        }

        protected override void ModelToEntity(UserModel model, User entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Login = model.login;
            entity.MasterDataRoleId = model.role;

            if (actionType == ActionTypes.Add)
            {
                entity.Password = StringHelper.GetMD5Hash(model.password);
            }
        }

        protected override IQueryable<User> Sort(IQueryable<User> entities, Sorting sorting)
        {
            if (sorting.Field == "role")
            {
                return entities.OrderBy("Role.Name " + sorting.Direction);
            }

            return base.Sort(entities, sorting);
        }
    }
}