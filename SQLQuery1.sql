-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(200),
    Email VARCHAR(100)
);

-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY(1,1),
    TenSP NVARCHAR(100),
    Gia DECIMAL(10,2),
    MoTa NVARCHAR(500)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY IDENTITY(1,1),
    NgayLap DATE,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH)
);

-- Bảng Chi tiết hóa đơn
CREATE TABLE CT_HoaDon (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP INT FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT
);

-- Bảng Giao hàng
CREATE TABLE GiaoHang (
    MaGiaoHang INT PRIMARY KEY IDENTITY(1,1),
    MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD),
    TrangThai NVARCHAR(50),
    NgayGiao DATE
);

-- Bảng Khuyến mãi
CREATE TABLE KhuyenMai (
    MaKM INT PRIMARY KEY IDENTITY(1,1),
    TenKM NVARCHAR(100),
    PhanTramGiam INT,
    NgayBatDau DATE,
    NgayKetThuc DATE
);

-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV VARCHAR(10) NOT NULL PRIMARY KEY,
    TenNV NVARCHAR(100) NULL,
    TaiKhoan VARCHAR(50) NULL,
    MatKhau VARCHAR(50) NULL,
    ChucVu NVARCHAR(50) NULL
);

select * from GiaoHang
select * from HoaDon