CREATE DATABASE PRO131
GO
USE PRO131
GO
--Tạo Bảng
-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    sdt VARCHAR(15),
    DanhGia INT
);
-- Bảng TaiKhoan
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100)
);
-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    MaTaiKhoan VARCHAR(50),
    VaiTro NVARCHAR(50),
    FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(TenDangNhap)
);
-- Bảng Ban
CREATE TABLE Ban (
    MaBan INT PRIMARY KEY,
    ViTri NVARCHAR(100),
    TrangThai NVARCHAR(50)
);
-- Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaKhuyenMai INT PRIMARY KEY,
    TenKhuyenMai NVARCHAR(100),
    GiaGiam DECIMAL(10,2),
    NgayBatDau DATE,
    NgayKetThuc DATE
);
-- Bảng LoaiSanPham
CREATE TABLE LoaiSanPham (
    MaLoaiSP INT PRIMARY KEY,
    TenLoai NVARCHAR(100)
);
-- Bảng SanPham
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(100),
    DonGia DECIMAL(10,2),
    MaLoaiSanPham INT,
    FOREIGN KEY (MaLoaiSanPham) REFERENCES LoaiSanPham(MaLoaiSP)
);
-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATE,
    MaKH INT,
    MaNV INT,
    MaBan INT,
    MaKhuyenMai INT,
    TongTien DECIMAL(15,2),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
    FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
);
-- Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaCTHD INT PRIMARY KEY,
    SoLuong INT,
    DonGia DECIMAL(10,2),
    MaHD INT,
    MaSP INT,
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
-- Bảng VatTu
CREATE TABLE VatTu (
    MaVatTu INT PRIMARY KEY,
    TenVatTu NVARCHAR(100),
    SoLuongTon INT
);
-- Bảng VatTuChiTiet
CREATE TABLE VatTuChiTiet (
    MaVatTuChiTiet INT PRIMARY KEY,
    MaVatTu INT,
    SoLuong INT,
    MaSP INT,
    FOREIGN KEY (MaVatTu) REFERENCES VatTu(MaVatTu),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
-- Bảng NguyenLieu
CREATE TABLE NguyenLieu (
    MaNguyenLieu INT PRIMARY KEY,
    TenNguyenLieu NVARCHAR(100),
    DonViTinh NVARCHAR(50),
    SoLuongTon INT
);
-- Bảng ChiTietNguyenLieu
CREATE TABLE ChiTietNguyenLieu (
    MaCTNL INT PRIMARY KEY,
    SoLuongCan DECIMAL(10,2),
    DonViTinh NVARCHAR(50),
    MaSP INT,
    MaNguyenLieu INT,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)
);

--Thủ tục
--Thêm Khách Hàng
CREATE PROCEDURE ThemKhachHang
    @MaKhachHang INT,
    @HoTen NVARCHAR(100),
    @sdt VARCHAR(15),
    @DanhGia INT
AS
BEGIN
    INSERT INTO KhachHang VALUES (@MaKhachHang, @HoTen, @sdt, @DanhGia);
END;
EXEC ThemKhachHang 1, N'Nguyễn Văn A', '0909123456', 5;
EXEC ThemKhachHang 2, N'Trần Thị B', '0912345678', 4;

--Thêm Tài Khoản
CREATE PROCEDURE ThemTaiKhoan
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(100)
AS
BEGIN
    INSERT INTO TaiKhoan(TenDangNhap,MatKhau) VALUES (@TenDangNhap, @MatKhau);
END;
EXEC ThemTaiKhoan 'admin','1';
EXEC ThemTaiKhoan 'nhanvien01', '123456';
SELECT * FROM TaiKhoan

--Thêm nhân viên
CREATE PROCEDURE ThemNhanVien
    @MaNhanVien INT,
    @HoTen NVARCHAR(100),
    @MaTaiKhoan VARCHAR(50),
    @VaiTro NVARCHAR(50)
AS
BEGIN
    INSERT INTO NhanVien VALUES (@MaNhanVien, @HoTen, @MaTaiKhoan, @VaiTro);
END;
EXEC ThemNhanVien 101, N'Phạm Văn C', 'nhanvien01', N'Phục vụ';
EXEC ThemNhanVien 102, N'Lê Thị D', 'admin', N'Quản lý';

--Thêm Bàn
CREATE PROCEDURE ThemBan
    @MaBan INT,
    @ViTri NVARCHAR(100),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO Ban VALUES (@MaBan, @ViTri, @TrangThai);
END;
EXEC ThemBan 1, N'Số 01', N'Trống';
EXEC ThemBan 2, N'Số 02', N'Trống';

--Thêm Khuyến mãi
CREATE PROCEDURE ThemKhuyenMai
    @MaKhuyenMai INT,
    @TenKhuyenMai NVARCHAR(100),
    @GiaGiam DECIMAL(10,2),
    @NgayBatDau DATE,
    @NgayKetThuc DATE
AS
BEGIN
    INSERT INTO KhuyenMai VALUES (@MaKhuyenMai, @TenKhuyenMai, @GiaGiam, @NgayBatDau, @NgayKetThuc);
END;
EXEC ThemKhuyenMai 1, N'Giảm giá mùa hè', 10.00, '2025-06-01', '2025-08-31';
EXEC ThemKhuyenMai 2, N'Khuyến mãi cuối tuần', 5.00, '2025-08-09', '2025-08-11';


--Thêm Hóa Đơn

DROP PROCEDURE IF EXISTS ThemHoaDon;
GO

CREATE PROCEDURE ThemHoaDon
    @NgayLap DATE,
    @MaKH INT = NULL,
    @MaNV INT = NULL,
    @MaBan INT,
    @MaKhuyenMai INT = NULL,
    @TongTien DECIMAL(15,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO HoaDon (NgayLap, MaKH, MaNV, MaBan, MaKhuyenMai, TongTien)
    VALUES (@NgayLap, @MaKH, @MaNV, @MaBan, @MaKhuyenMai, @TongTien);

    -- Trả về mã hóa đơn vừa tạo
    SELECT SCOPE_IDENTITY() AS MaHDMoi;
END;
GO

--Thêm Loại Sản Phẩm
CREATE PROCEDURE ThemLoaiSanPham
    @MaLoaiSP INT,
    @TenLoai NVARCHAR(100)
AS
BEGIN
    INSERT INTO LoaiSanPham VALUES (@MaLoaiSP, @TenLoai);
END;
EXEC ThemLoaiSanPham 1,N'Cà Phê';
EXEC ThemLoaiSanPham 2,N'Trà Sữa';

--Thêm Sản Phẩm
CREATE PROCEDURE ThemSanPham
    @MaSP INT,
    @TenSP NVARCHAR(100),
	@DonGia DECIMAL(10,2),
	@MaLoaiSanPham INT
AS
BEGIN
    INSERT INTO SanPham(MaSP,TenSP,DonGia,MaLoaiSanPham) VALUES (@MaSP, @TenSP,@DonGia,@MaLoaiSanPham);
END;
INSERT INTO SanPham VALUES (1, N'Cà phê sữa', 30000.00, 1);
INSERT INTO SanPham VALUES (2, N'Bạc xỉu', 45000.00, 1);



--Thêm Chi Tiết Hóa Đơn
CREATE PROCEDURE ThemChiTietHoaDon
    @MaCTHD INT,
    @SoLuong INT,
    @DonGia DECIMAL(10,2),
    @MaHD INT,
    @MaSP INT
AS
BEGIN
    INSERT INTO ChiTietHoaDon(MaCTHD,SoLuong,DonGia,MaHD,MaSP) VALUES (@MaCTHD, @SoLuong, @DonGia, @MaHD, @MaSP);
END;
EXEC ThemChiTietHoaDon 1, 2, 30000.00, 1001, 1;
EXEC ThemChiTietHoaDon 2, 1, 45000.00, 1002, 2;

--Thêm Vật Tư
CREATE PROCEDURE ThemVatTu
    @MaVatTu INT,
    @TenVatTu NVARCHAR(100),
    @SoLuongTon INT
AS
BEGIN
    INSERT INTO VatTu VALUES (@MaVatTu, @TenVatTu, @SoLuongTon);
END;

--Thêm Vật Tư Chi Tiết
CREATE PROCEDURE ThemVatTuChiTiet
    @MaVatTuChiTiet INT,
    @MaVatTu INT,
    @SoLuong INT,
    @MaSP INT
AS
BEGIN
    INSERT INTO VatTuChiTiet VALUES (@MaVatTuChiTiet, @MaVatTu, @SoLuong, @MaSP);
END;

--Thêm Nguyên Liệu
CREATE PROCEDURE ThemNguyenLieu
    @MaNguyenLieu INT,
    @TenNguyenLieu NVARCHAR(100),
    @DonViTinh NVARCHAR(50),
    @SoLuongTon INT
AS
BEGIN
    INSERT INTO NguyenLieu VALUES (@MaNguyenLieu, @TenNguyenLieu, @DonViTinh, @SoLuongTon);
END;
EXEC ThemNguyenLieu 1, N'Cà phê', N'gram', 1000;
EXEC ThemNguyenLieu 2, N'Sữa', N'gram', 200;

--Thêm Chi Tiết Nguyên Liệu
CREATE PROCEDURE ThemChiTietNguyenLieu
    @MaCTNL INT,
    @SoLuongCan DECIMAL(10,2),
    @DonViTinh NVARCHAR(50),
    @MaSP INT,
    @MaNguyenLieu INT
AS
BEGIN
    INSERT INTO ChiTietNguyenLieu VALUES (@MaCTNL, @SoLuongCan, @DonViTinh, @MaSP, @MaNguyenLieu);
END;
-------------------------------
DECLARE @i INT = 0
WHILE @i <= 10
BEGIN
INSERT Ban (MaBan ,ViTri) VALUES (@i ,N'Bàn' + CAST(@i AS VARCHAR(100)))
SET @i = @i + 1
END
-------------------------------
CREATE PROC USP_GetTableList
AS SELECT * FROM Ban
GO
EXEC USP_GetTableList

---------------------------------
CREATE PROC USP_InsertBillInfo
AS SELECT * FROM ChiTietHoaDon
GO
EXEC USP_InsertBillInfo
----------------------

CREATE PROCEDURE USP_InsertBill
    @idTable INT
AS
BEGIN
    INSERT INTO HoaDon (MaBan, NgayLap, TongTien)
    VALUES (@idTable, GETDATE(), 0)
END
