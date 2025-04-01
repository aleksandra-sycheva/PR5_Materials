using PR5_Materials.Models;
using System;
using System.Collections.Generic;

namespace PR5_Materials;

public partial class Product
{
    public int Id { get; set; }

    public short IdTypeOfProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimumCost { get; set; }

    public virtual ICollection<HistoryOfProduct> HistoryOfProducts { get; set; } = new List<HistoryOfProduct>();

    public virtual TypesOfProduct IdTypeOfProductNavigation { get; set; } = null!;
}
