﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ScaffoldingPostgreSqlMultiSchemaTester.Models
{
    /// <summary>
    /// High-level product categorization.
    /// </summary>
    public partial class Productcategory
    {
        public Productcategory()
        {
            Productsubcategory = new HashSet<Productsubcategory>();
        }

        /// <summary>
        /// Primary key for ProductCategory records.
        /// </summary>
        public int Productcategoryid { get; set; }
        /// <summary>
        /// Category description.
        /// </summary>
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual ICollection<Productsubcategory> Productsubcategory { get; set; }
    }
}