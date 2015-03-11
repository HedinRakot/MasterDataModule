namespace MasterDataModule.Contracts.Managers
{
    public static class AsProDataContextRequestManager
	{
        public delegate IEntities AsProDataContextRequestEventHandler();

        public static event AsProDataContextRequestEventHandler DataContextRequest;

		public static IEntities GetDataContext()
		{
            lock (typeof(AsProDataContextRequestManager))
			{
				if(DataContextRequest != null)
					return DataContextRequest();
			}

			return null;
		}
	}
}
