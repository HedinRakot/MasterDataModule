using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule
{
    public static class ASProDataContextRequestManager
	{
        public delegate IEntities ASProDataContextRequestEventHandler();

        public static event ASProDataContextRequestEventHandler DataContextRequest;

		public static IEntities GetDataContext()
		{
            lock (typeof(ASProDataContextRequestManager))
			{
				if(DataContextRequest != null)
					return DataContextRequest();
			}

			return null;
		}
	}
}
