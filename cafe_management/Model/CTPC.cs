//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cafe_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTPC
    {
        public int MaPC { get; set; }
        public int MaNgL { get; set; }
        public Nullable<int> SL { get; set; }
    
        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
        public virtual PHIEUCHI PHIEUCHI { get; set; }
    }
}
