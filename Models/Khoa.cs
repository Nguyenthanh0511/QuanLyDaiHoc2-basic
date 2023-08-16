using System;
using System.Collections.Generic;

namespace QuanLyDaiHoc.Models;

public partial class Khoa
{
    public int KhoaId { get; set; }

    public string TenKhoa { get; set; } = null!;

    public string Mota { get; set; } = null!;

    public string TruongKhoa { get; set; } = null!;

    public string Sodienthoai { get; set; } = null!;
}
