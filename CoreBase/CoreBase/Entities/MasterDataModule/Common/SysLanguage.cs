//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common
{
    /// <summary>
    /// Entity from table SYS_LANGUAGE. Imported from AsPro: Dictionary data. Represents a collection of possible "languages" which can be used in as133 system  
    /// </summary>
    public partial class SysLanguage : IHasId<int>, ICommonSystemFields, IRemovable, IHasTitle
    {
    
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "SYS_LANGUAGE";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="SysLanguage.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'SAP_ID' for property <see cref="SysLanguage.SapId"/>
            /// </summary>
            public static readonly string SapId = "SAP_ID";
            /// <summary>
            /// Column name 'SAP_ID_ISO' for property <see cref="SysLanguage.SapIdIso"/>
            /// </summary>
            public static readonly string SapIdIso = "SAP_ID_ISO";
            /// <summary>
            /// Column name 'RESOURCE_FILE_NAME' for property <see cref="SysLanguage.ResourceFileName"/>
            /// </summary>
            public static readonly string ResourceFileName = "RESOURCE_FILE_NAME";
            /// <summary>
            /// Column name 'IS_AVAILABLE' for property <see cref="SysLanguage.IsAvailable"/>
            /// </summary>
            public static readonly string IsAvailable = "IS_AVAILABLE";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="SysLanguage.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="SysLanguage.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="SysLanguage.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="SysLanguage.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="SysLanguage.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="SysLanguage.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="SysLanguage.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="SysLanguage.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="SysLanguage.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
      
        }
        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public SysLanguage()
        {
            this.CoreDataProductLocalizations = new HashSet<CoreDataProductLocalization>();
            this.Languages = new HashSet<Language>();
        }
    
        /// <summary>
        /// PK. Original table: SYS_LANGUAGE, Column: ID  
        /// </summary>
        public int Id {  get;  set; }
        /// <summary>
        /// Represents unique SAP number. Original table: SYS_LANGUAGE, Column: SAP_ID  
        /// </summary>
        public string SapId {  get;  set; }
        /// <summary>
        /// z.b. ''''DE''''. Original table: SYS_LANGUAGE, Column: SAP_ID_ISO  
        /// </summary>
        public string SapIdIso {  get;  set; }
        /// <summary>
        /// Reference to localization file. Original table: SYS_LANGUAGE, Column: RESOURCE_FILE_NAME  
        /// </summary>
        public string ResourceFileName {  get;  set; }
        /// <summary>
        /// Indicating whether this language can be used for GUI localization. Original table: SYS_LANGUAGE, Column: IS_AVAILABLE  
        /// </summary>
        public bool IsAvailable {  get;  set; }
        /// <summary>
        /// Represents a language description. Original table: SYS_LANGUAGE, Column: DESCRIPTION  
        /// </summary>
        public string Description {  get;  set; }
        /// <summary>
        /// Create date. Original table: SYS_LANGUAGE, Column: CREATE_DATE  
        /// </summary>
        public System.DateTime? CreateDate {  get;  set; }
        /// <summary>
        /// Change date. Original table: SYS_LANGUAGE, Column: CHANGE_DATE  
        /// </summary>
        public System.DateTime? ChangeDate {  get;  set; }
        /// <summary>
        /// Delete date. Original table: SYS_LANGUAGE, Column: DELETE_DATE  
        /// </summary>
        public System.DateTime? DeleteDate {  get;  set; }
        /// <summary>
        /// Owner of record concerning organizational hierarchy. Original table: SYS_LANGUAGE, Column: OWNER_ORG_ID  
        /// </summary>
        public int? OwnerOrgId {  get;  set; }
        /// <summary>
        /// Visibility of record concerning organizational hierarchy. Original table: SYS_LANGUAGE, Column: VISIBILITY_ORG_ID  
        /// </summary>
        public int? VisibilityOrgId {  get;  set; }
        /// <summary>
        /// Employee who created record. Original table: SYS_LANGUAGE, Column: CREATE_EMPLOYEE_ID  
        /// </summary>
        public int? CreateEmployeeId {  get;  set; }
        /// <summary>
        /// Employee who changed record. Original table: SYS_LANGUAGE, Column: CHANGE_EMPLOYEE_ID  
        /// </summary>
        public int? ChangeEmployeeId {  get;  set; }
        /// <summary>
        /// Short name of source data. Original table: SYS_LANGUAGE, Column: SOURCE  
        /// </summary>
        public string Source {  get;  set; }
        /// <summary>
        /// Navigation property to object DRL_CORE_DATA_PRODUCT_LOCALIZATION. Comment: EN: Core data product localization  
        /// </summary>
        public virtual ICollection<CoreDataProductLocalization> CoreDataProductLocalizations {  get;  set; }
    
    	/// <summary>
    	/// Filtered collection of <see cref="CoreDataProductLocalizations"/>
    	/// </summary>
    	public IEnumerable<CoreDataProductLocalization> CoreDataProductLocalizationsFiltered 
    	{
    		get
    		{
    			return CoreDataProductLocalizations.Where(SystemFilter<CoreDataProductLocalization>.Func);
    		}
    	}
    			
        /// <summary>
        /// Navigation property to object DRL_LANGUAGE. Comment: EN: 5.2.12.9 Language  DE: 5.2.12.9 Fahrerlaubnis - Sprachen  
        /// </summary>
        public virtual ICollection<Language> Languages {  get;  set; }
    
    	/// <summary>
    	/// Filtered collection of <see cref="Languages"/>
    	/// </summary>
    	public IEnumerable<Language> LanguagesFiltered 
    	{
    		get
    		{
    			return Languages.Where(SystemFilter<Language>.Func);
    		}
    	}
        
        /// <summary>
        /// 
        /// </summary>
        public string EntityTitle { get { return Description; } }

        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public SysLanguage ShallowCopy()
    	{
    	   return new SysLanguage {
                                           SapId = this.SapId,
                                           SapIdIso = this.SapIdIso,
                                           ResourceFileName = this.ResourceFileName,
                                           IsAvailable = this.IsAvailable,
                                           Description = this.Description,
                                           DeleteDate = this.DeleteDate,
                                           Source = this.Source,
    	                              };
    	}
    }
}
