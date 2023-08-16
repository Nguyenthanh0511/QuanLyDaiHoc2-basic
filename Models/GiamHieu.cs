using System;
using System.Collections.Generic;

namespace QuanLyDaiHoc.Models;

public partial class GiamHieu
{
    public int GiamHieuId { get; set; }

    public string? Ten { get; set; }

    public byte[]? Img { get; set; }

    public string? ChucVu { get; set; }

    public DateTime? NhiemKy { get; set; }
}
