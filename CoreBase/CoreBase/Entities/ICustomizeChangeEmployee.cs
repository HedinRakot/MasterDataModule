namespace TuevSued.V1.IT.FE.CommonObjects.Entities
{
    /// <summary>
    /// Customize change employee id
    /// </summary>
    public interface ICustomizeChangeEmployee : ICommonSystemFields
    {
        /// <summary>
        /// Customized change employee id
        /// </summary>
        int? CustomChangeEmployeeId { get; set; }
    }
}