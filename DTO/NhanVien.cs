using System.Text.Json.Serialization;
using System;
public class NhanVien
{
    [JsonPropertyName("MaNV")]
    public string MaNhanVien { get; set; }

    [JsonPropertyName("HoTen")]
    public string HoTen { get; set; }

    [JsonPropertyName("NgaySinh")]
    public DateTime NgaySinh { get; set; }

    [JsonPropertyName("GioiTinh")]
    public bool GioiTinh { get; set; }

    [JsonPropertyName("DiaChi")]
    public string DiaChi { get; set; }

    [JsonPropertyName("SDT")]
    public string SDT { get; set; }

    [JsonPropertyName("Email")]
    public string Email { get; set; }

    [JsonPropertyName("NgayVaoLam")]
    public DateTime NgayVaoLam { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("MaCV")]
    public string MaCV { get; set; }

    [JsonPropertyName("MaQuyen")]
    public string MaQuyen { get; set; }
}
