//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HuluApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Network
    {
        public int NetworkID { get; set; }
        public string NetworkName { get; set; }
        public Nullable<int> ChannelNumber { get; set; }
        public Nullable<int> ShowsID { get; set; }
    
        public virtual Show Show { get; set; }
    }
}
