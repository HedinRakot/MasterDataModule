﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using MonitoringAgent.Data.Interfaces.Entities;
namespace MonitoringAgent.Common.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MasterDataMonitoringModelContainer : DbContext
    {
        public MasterDataMonitoringModelContainer()
            : base("name=MasterDataMonitoringModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<WcfServiceInfo> WcfServiceInfoSet { get; set; }
    }
}
