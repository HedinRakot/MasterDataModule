namespace MasterDataModule.Lib.DuplicateCheckers.Interfaces
{
    public interface IDuplicateChecker
    {
        bool HasDuplicate(object entity);
        string GetWorkingTypeName();
    }
}