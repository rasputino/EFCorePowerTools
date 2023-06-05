﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.dboNs;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.HumanResourcesNs;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.PersonNs;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.ProductionNs;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.PurchasingNs;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.SalesNs;


namespace ScaffoldingPostgreSqlMultiSchemaTester.Models.SalesNs
{
    /// <summary>
    /// Lookup table of customer purchase reasons.
    /// </summary>
    public partial class SalesReason
    {
        public SalesReason()
        {
            SalesOrderHeaderSalesReason = new HashSet<SalesOrderHeaderSalesReason>();
        }

        /// <summary>
        /// Primary key for SalesReason records.
        /// </summary>
        public int SalesReasonId { get; set; }
        /// <summary>
        /// Sales reason description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Category the sales reason belongs to.
        /// </summary>
        public string ReasonType { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
    }
}