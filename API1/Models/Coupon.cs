﻿namespace API1.Models;

public partial class Coupon
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Expiration { get; set; }
}
