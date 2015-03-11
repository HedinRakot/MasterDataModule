using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base
{
    /// <summary>
    /// 
    /// </summary>
	public interface IManager
	{
        /// <summary>
        /// 
        /// </summary>
		IEntities DataContext
		{
			get;
			set;
		}

        /// <summary>
        /// 
        /// </summary>
		void SaveChanges();
	}    
}
