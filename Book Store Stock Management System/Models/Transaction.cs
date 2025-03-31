using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Models;

public partial class Transaction
{
    [Key]
    public int Id { get; set; }

    [Column("ISBN")]
    public long? Isbn { get; set; }

    public int Count { get; set; }

    public DateOnly Date { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal BuyPrice { get; set; }

    public int UserId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? SupplierId { get; set; }

    [ForeignKey("Isbn")]
    [InverseProperty("Transactions")]
    public virtual Book? IsbnNavigation { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("Transactions")]
    public virtual Supplier? Supplier { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Transactions")]
    public virtual User User { get; set; } = null!;
}
