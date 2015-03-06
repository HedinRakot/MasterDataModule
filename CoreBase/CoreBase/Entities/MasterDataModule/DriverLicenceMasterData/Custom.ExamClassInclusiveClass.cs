using System;
using System.Collections.Generic;
using System.Linq;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData
{
    /// <summary>
    /// Entity from table DRL_EXAM_CLASS. EN: 5.2.12.5 Class  DE: 5.2.12.5 Fahrerlaubnis - Klassen  
    /// </summary>
    public partial class ExamClassInclusiveClass : IHasId<int>, ICommonSystemFields, ISystemFields, IRemovable
    {
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static partial class Fields
        {
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamClass.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
        }
        #endregion

        /// <summary>
        /// DELETE DATUM
        /// </summary>
        public System.DateTime? DeleteDate { get; set; }
    }
}
