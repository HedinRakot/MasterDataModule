
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class ExamStationDuplicateChecker : BaseDuplicateChecker<ExamStation>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IExamStationManager> manager;
    
    		public ExamStationDuplicateChecker (Lazy<IExamStationManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(ExamStation entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Place == entity.Place &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
