using System;
using System.Collections.Generic;

namespace Caso2Scaffolding22200563roldan.Models;

public partial class Mechanic
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly HireDate { get; set; }
}
