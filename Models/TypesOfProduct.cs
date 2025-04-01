﻿using System;
using System.Collections.Generic;

namespace PR5_Materials.Models;

public partial class TypesOfProduct
{
    public short Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
