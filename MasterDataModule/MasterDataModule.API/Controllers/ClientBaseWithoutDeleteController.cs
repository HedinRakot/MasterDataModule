﻿using System;
using System.Web.Http;
using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Managers.Base;

namespace MasterDataModule.API.Controllers
{
    public abstract class ClientBaseWithoutDeleteController<TModel, TEntity, TId, TManager> :
        ReadOnlyClientBaseController<TModel, TEntity, TId, TManager>
        where TManager : IManagerBase<TEntity, TId>
        where TModel : class, IHasId<TId>, ISystemModelFields, new()
        where TEntity : class, IHasId<TId>, IRemovable, ISystemFields
    {
        protected ClientBaseWithoutDeleteController(TManager manager)
            : base(manager)
        {
        }

        public event EventHandler<ActionSuccessEventArgs<TEntity, TId>> ActionSuccess;

        protected void OnActionSuccess(TEntity entity, ActionTypes actionType)
        {
            if (ActionSuccess != null)
            {
                ActionSuccess(this, new ActionSuccessEventArgs<TEntity, TId>
                {
                    ActionType = actionType,
                    Entity = entity
                });
            }
        }

        protected abstract void ModelToEntity(TModel model, TEntity entity, ActionTypes actionType);

        protected virtual void Validate(TModel model, TEntity entity, ActionTypes actionType)
        {
        }

        public virtual IHttpActionResult Put([FromBody] TModel model)
        {
            var entity = Manager.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }

            Validate(model, entity, ActionTypes.Update);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ModelToEntity(model, entity, ActionTypes.Update);

            // TODO we should save FROM_DATE as "FROM_DATE 00:00:00"
            // TO_DATE as "TO_DATE 23:59:59"
            var sysModel = ((object) model) as IModelIntervalFields;
            var sysEntity = entity as IIntervalFields;
            if (sysEntity != null && sysModel != null)
            {
                sysEntity.ToDate = sysModel.toDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }

            Manager.SaveChanges();

            OnActionSuccess(entity, ActionTypes.Update);

            EntityToModel(entity, model);

            return Ok(model);
        }

        public virtual IHttpActionResult Post([FromBody] TModel model)
        {
            var entity = Manager.DataContext.CreateObject<TEntity>();
            Validate(model, entity, ActionTypes.Add);
            if (ModelState.IsValid)
            {
                ModelToEntity(model, entity, ActionTypes.Add);

                Manager.AddEntity(entity);
                Manager.SaveChanges();

                model = new TModel
                {
                    Id = entity.Id
                };

                OnActionSuccess(entity, ActionTypes.Add);

                EntityToModel(entity, model);

                return Ok(model);
            }

            return BadRequest(ModelState);
        }

        private bool HasConcurrency(ISystemFields entity, ISystemModelFields model)
        {
            if (entity == null || 
                model == null ||
                entity.ChangeDate == DateTime.MinValue) //exclude tables without ChangeDate field. DateTime.MinValue is a default for them
            {
                return false;
            }
            return entity.ChangeDate != model.changeDate;
        }
    }
}