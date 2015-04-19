
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class ExamClassDuplicateChecker : BaseDuplicateChecker<ExamClass>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IExamClassManager> manager;
    
    		public ExamClassDuplicateChecker (Lazy<IExamClassManager> manager)
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
    
    		protected override bool HasDuplicate(ExamClass entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Name == entity.Name &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
