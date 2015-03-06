using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData
{
    /// <summary>
    /// 
    /// </summary>
    public class Role : IHasId<int>, ICommonSystemFields, ISystemFields, IRemovable, IHasTitle
	{
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "MASTER_DATA_ROLE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="ExamClass.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="ExamClass.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="ExamClass.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="ExamClass.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="ExamClass.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="ExamClass.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="ExamClass.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="ExamClass.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamClass.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            // <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamClass.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
		public Role()
		{
			Users = new HashSet<User>();
			Permissions = new HashSet<Permission>();
		}

        /// <summary>
        /// 
        /// </summary>
		public int Id { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
				
        /// <summary>
        /// 
        /// </summary>
        //[InverseProperty("Role")]
		public virtual ICollection<User> Users { get; set; }
		
        /// <summary>
        /// 
        /// </summary>
        //[InverseProperty("Roles")]
		public virtual ICollection<Permission> Permissions { get; set; }

        /// <summary>
        /// ANLAGEDATUM (INSERT-DATUM)  
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// AENDERUNGSDATUM (UPDATE-DATUM)  
        /// </summary>
        public System.DateTime ChangeDate { get; set; }
        /// <summary>
        /// OWNER (SCHLUESSEL EINER ORGANISATIONSEINHEIT, WELCHE FUER DIE PFLEGE EINES DATENSATZES  
        /// </summary>
        public int? OwnerOrgId { get; set; }
        /// <summary>
        /// SICHTBARKEIT (SCHLUESSEL EINER ORGANISATIONSEINHEIT, AB WELCHER IM HIERACHIEBAUM ABWAERTS EIN DATENSATZ SICHTBAR IST)  
        /// </summary>
        public int? VisibilityOrgId { get; set; }
        /// <summary>
        /// ANLEGER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ANGELEGT HAT)  
        /// </summary>
        public int? CreateEmployeeId { get; set; }
        /// <summary>
        /// AENDERER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ALS LETZTES GEAENDERT HAT, BEI NEUANLAGE IST DIESER WERT GLEICH DEM ANLEGER)  
        /// </summary>
        public int? ChangeEmployeeId { get; set; }
        /// <summary>
        /// VON-DATUM DER GUELTIGKEIT  
        /// </summary>
        public System.DateTime FromDate { get; set; }
        /// <summary>
        /// ENDE-DATUM DER GUELTIGKEIT  
        /// </summary>
        public System.DateTime ToDate { get; set; }

        // <summary>
        /// Entity create date 
        /// </summary>
        DateTime? ICommonSystemFields.CreateDate
        {
            get
            {
                return CreateDate;
            }
            set
            {
                if (value.HasValue) { CreateDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }
        /// <summary>
        /// Last changed date 
        /// </summary>
        DateTime? ICommonSystemFields.ChangeDate
        {
            get
            {
                return ChangeDate;
            }
            set
            {
                if (value.HasValue) { ChangeDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }
        /// <summary>
        /// From date entity valid 
        /// </summary>
        DateTime? ISystemFields.FromDate
        {
            get
            {
                return FromDate;
            }
            set
            {
                if (value.HasValue) { FromDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }
        /// <summary>
        /// To date entity valid 
        /// </summary>
        DateTime? ISystemFields.ToDate
        {
            get
            {
                return ToDate;
            }
            set
            {
                if (value.HasValue) { ToDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }

        /// <summary>
        /// DELETE DATUM
        /// </summary>
        public System.DateTime? DeleteDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EntityTitle
        {
            get { return Name; }
        }
    }
}
