using System.ComponentModel.DataAnnotations;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData
{
    /// <summary>
    /// Master data tables edit mode types
    /// </summary>
    public enum EditModeType
    {
        /// <summary>
        /// Readonly
        /// </summary>
        //[Display(Name = "Readonly", ResourceType = typeof(CommonObjectsResources))]
        Readonly = 0,

        /// <summary>
        /// Read/Edit
        /// </summary>
        //[Display(Name = "Edit", ResourceType = typeof(CommonObjectsResources))]
        Edit = 1,

        /// <summary>
        /// Read/Edit/Add
        /// </summary>
        //[Display(Name = "Add", ResourceType = typeof(CommonObjectsResources))]
        Add = 2
    }
}