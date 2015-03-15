using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="EmpEmployee"/> entity
    /// </summary>
    [DataContract]
    public class EmpEmployeeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="EmpEmployee.PersonalNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string personalNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.Domain"/> entity
        /// </summary>
        [DataMember]
        public string domain{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.UserName"/> entity
        /// </summary>
        [DataMember]
        public string userName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.WindowsUserName"/> entity
        /// </summary>
        [DataMember]
        public string windowsUserName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.IsSsoAllowed"/> entity
        /// </summary>
        [DataMember]
        public bool? isSsoAllowed{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.IsEmergencyLoginAllowed"/> entity
        /// </summary>
        [DataMember]
        public bool? isEmergencyLoginAllowed{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.MiddleName"/> entity
        /// </summary>
        [DataMember]
        public string middleName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.LastName"/> entity
        /// </summary>
        [DataMember]
        public string lastName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.Comment"/> entity
        /// </summary>
        [DataMember]
        public string comment{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.SexType"/> entity
        /// </summary>
        [DataMember]
        public int? sexType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.Title"/> entity
        /// </summary>
        [DataMember]
        public string title{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.Birthdate"/> entity
        /// </summary>
        [DataMember]
        public DateTime birthdate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="EmpEmployee.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
