﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Nviss.Models
{
    public class MailTracker
    {
       [Key]
       public int Id { get; set; }
       public string ReferenceNo { get; set; }
       public string Subject { get; set; }
       public string SignedBy { get; set; }
       public string  Sender { get; set; }
       public DateTime DocumentDate { get; set; }
       public DateTime DateRecieved { get; set; } = DateTime.Now;
        public virtual Document Documents { get; set; }
        [DisplayName("DocumentType")]
        public int DocumentId { get; set; }
        public string NextActionBy { get; set; }
       public DateTime? DateEntered { get; set; }
       public string? EnteredBy { get; set; }
       public string? MinutedTo { get; set; }
    }
}
