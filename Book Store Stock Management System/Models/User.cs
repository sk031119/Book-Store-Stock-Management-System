using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Models;

[Index("Username", Name = "UQ__Users__536C85E4BB98B443", IsUnique = true)]
public partial class User
{
    [Key]
    public int UserId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("PASSWORD")]
    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Role { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
