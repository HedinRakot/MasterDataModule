namespace MasterDataModule.Contracts
{
    /// <summary>
    /// Interface entity with name
    /// </summary>
    public interface IHasTitle
    {
        /// <summary>
        /// Entity name
        /// </summary>
        string EntityTitle { get; }
    }
}
