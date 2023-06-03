﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ScaffoldingPostgreSqlMultiSchemaTester.Models
{
    /// <summary>
    /// Unit of measure lookup table.
    /// </summary>
    public partial class Unitmeasure
    {
        public Unitmeasure()
        {
            Billofmaterials = new HashSet<Billofmaterials>();
            ProductSizeunitmeasurecodeNavigation = new HashSet<Product>();
            ProductWeightunitmeasurecodeNavigation = new HashSet<Product>();
            Productvendor = new HashSet<Productvendor>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public string Unitmeasurecode { get; set; }
        /// <summary>
        /// Unit of measure description.
        /// </summary>
        public string Name { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual ICollection<Billofmaterials> Billofmaterials { get; set; }
        public virtual ICollection<Product> ProductSizeunitmeasurecodeNavigation { get; set; }
        public virtual ICollection<Product> ProductWeightunitmeasurecodeNavigation { get; set; }
        public virtual ICollection<Productvendor> Productvendor { get; set; }
    }
}