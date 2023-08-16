using System;
using System.Collections.Generic;

namespace QuanLyDaiHoc.Models;

public partial class Nguoidung
{
    public int IdNguoiDung { get; set; }

    public string? TenNguoiDung { get; set; }

    public string? Salt { get; set; }

    public string? Md5Password { get; set; }

    public string? Password { get; set; }

    public string? FieldA { get; set; }
}
