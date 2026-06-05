using System;
using System.Collections.Generic;

namespace ShoesProject.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRols { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual Role IdRolsNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
