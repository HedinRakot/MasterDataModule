//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringAgent.Data.Interfaces.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteInfo
    : ICheckServiceInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeoutChecking { get; set; }
        public string SitePath { get; set; }
    }
}