﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ScaffoldingPostgreSqlMultiSchemaTester.Models
{
    /// <summary>
    /// Where to send a person email.
    /// </summary>
    public partial class Emailaddress
    {
        /// <summary>
        /// Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID
        /// </summary>
        public int Businessentityid { get; set; }
        /// <summary>
        /// Primary key. ID of this email address.
        /// </summary>
        public int Emailaddressid { get; set; }
        /// <summary>
        /// E-mail address for the person.
        /// </summary>
        public string Emailaddress1 { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime Modifieddate { get; set; }

        public virtual Person Businessentity { get; set; }
    }
}