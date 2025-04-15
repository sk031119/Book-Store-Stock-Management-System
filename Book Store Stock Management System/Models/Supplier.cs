using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Models;

[Table("Supplier")]
public partial class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Phone { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
