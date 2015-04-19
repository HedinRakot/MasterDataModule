
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class ExamConstraintDuplicateChecker : BaseDuplicateChecker<ExamConstraint>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IExamConstraintManager> manager;
    
    		public ExamConstraintDuplicateChecker (Lazy<IExamConstraintManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		public override string[] BusinessKeys 
    		{
    			get 
    			{
    				return new[] 
    				{
    					 "name"
    				};
    			}
    		}
    
    		protected override bool HasDuplicate(ExamConstraint entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Name == entity.Name &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
