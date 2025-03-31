using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Models;

public partial class Book
{
    [Key]
    [Column("ISBN")]
    public long Isbn { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal RetailPrice { get; set; }

    public int StockCount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StockStatus { get; set; } = null!;

    public int AuthorId { get; set; }

    public int CategoryId { get; set; }

    public int PublisherId { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Books")]
    public virtual Author Author { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("Books")]
    public virtual Category Category { get; set; } = null!;

    [ForeignKey("PublisherId")]
    [InverseProperty("Books")]
    public virtual Publisher Publisher { get; set; } = null!;

    [InverseProperty("IsbnNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
