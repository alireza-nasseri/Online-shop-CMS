//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeaturesSummery
    {
        public int FS_ID { get; set; }
        public string FS_Name { get; set; }
        public int FeaturesID { get; set; }
    
        public virtual Features Features { get; set; }
    }
}
