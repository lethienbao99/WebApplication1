//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string Provider { get; set; }
        public System.Guid UserId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
