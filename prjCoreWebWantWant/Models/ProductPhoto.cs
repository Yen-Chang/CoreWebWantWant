﻿using System;
using System.Collections.Generic;

namespace prjCoreWebWantWant.Models;

public partial class ProductPhoto
{
    public int ProductPhotoId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductPhotoName { get; set; }

    public byte[]? ProductPhoto1 { get; set; }

    public virtual Product? Product { get; set; }
}
