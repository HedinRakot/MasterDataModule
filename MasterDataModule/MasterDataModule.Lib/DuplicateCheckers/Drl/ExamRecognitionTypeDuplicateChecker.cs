
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class ExamRecognitionTypeDuplicateChecker : BaseDuplicateChecker<ExamRecognitionType>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IExamRecognitionTypeManager> manager;
    
    		public ExamRecognitionTypeDuplicateChecker (Lazy<IExamRecognitionTypeManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(ExamRecognitionType entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Name == entity.Name &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
