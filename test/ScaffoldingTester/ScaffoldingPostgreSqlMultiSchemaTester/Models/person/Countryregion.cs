﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ScaffoldingPostgreSqlMultiSchemaTester.Models
{
    /// <summary>
    /// Lookup table containing the ISO standard codes for countries and regions.
    /// </summary>
    public partial class Countryregion
    {
        public Countryregion()
        {
            Countryregioncurrency = new HashSet<Countryregioncurrency>();
            Salesterritory = new HashSet<Salesterritory>();
            Stateprovince = new HashSet<Stateprovince>();
        }

        /// <summary>
        /// ISO standard code for countries and regions.
        /// </summary>
        public string Countryregioncode { get; set; }
        /// <summary>
        /// Country or region name.
        /// </summary>
        public string Name { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual ICollection<Countryregioncurrency> Countryregioncurrency { get; set; }
        public virtual ICollection<Salesterritory> Salesterritory { get; set; }
        public virtual ICollection<Stateprovince> Stateprovince { get; set; }
    }
}