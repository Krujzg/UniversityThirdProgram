//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothShop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Megrendeles
    {
        public int RendelesID { get; set; }
        public Nullable<System.DateTime> Leadasi_idopont { get; set; }
        public Nullable<System.DateTime> Hatarido { get; set; }
        public Nullable<int> DB_szam { get; set; }
        public int VasarloID { get; set; }
        public int RuhaID { get; set; }
    
        public virtual Megrendelo Megrendelo { get; set; }
    }
}
