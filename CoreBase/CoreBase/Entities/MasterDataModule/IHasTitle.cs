using System;
using System.Collections.Generic;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule
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
