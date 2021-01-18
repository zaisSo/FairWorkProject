//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FairWorkk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HiddenDiscount
    {
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public int SaloonId { get; set; }
        public int StandId { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string Area { get; set; }
        public decimal TotalPrice { get; set; }
        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public Nullable<decimal> MeterPrice { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual Stand Stand { get; set; }
    }
}