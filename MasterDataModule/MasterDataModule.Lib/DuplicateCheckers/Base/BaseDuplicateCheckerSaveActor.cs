using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using MasterDataModule.Contracts.SaveActors.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;

namespace MasterDataModule.Lib.DuplicateCheckers.Base
{
    public abstract class BaseDuplicateCheckerSaveActor<TDuplicateChecker> : ISaveActor where TDuplicateChecker: IDuplicateChecker
    {
        readonly Dictionary<string, TDuplicateChecker> checkers = new Dictionary<string, TDuplicateChecker>();

        protected BaseDuplicateCheckerSaveActor(TDuplicateChecker[] checkers)
        {
            foreach (var checker in checkers)
            {
                this.checkers.Add(checker.GetWorkingTypeName(), checker);
            }
        }

        public bool NeedDoAction(object entity, EntityState state)
        {
            return (state == EntityState.Added || state == EntityState.Modified) && checkers.ContainsKey(entity.GetType().Name);
        }

        public void DoAction(object entity, EntityState state)
        {
            var checker = checkers[entity.GetType().Name];
            if (checker.HasDuplicate(entity))
            {
                throw new DbEntityValidationException(string.Format("Database contains entity of type {0} with the same business keys.", entity.GetType().Name));
            }
        }
    }
}
