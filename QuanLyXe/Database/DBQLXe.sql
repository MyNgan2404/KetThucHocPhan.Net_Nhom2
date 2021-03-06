USE [QLXe]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 1/3/2022 11:22:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [bigint] IDENTITY(1,1) NOT NULL,
	[NhaXe] [nvarchar](50) NOT NULL,
	[BienSo] [nvarchar](50) NOT NULL,
	[TaiXe] [nvarchar](50) NULL,
	[LoaiXe] [nvarchar](50) NOT NULL,
	[TinhTrang] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (1, N'Xe khách Hoàng Long', N'30V24635', N'Nguyễn Văn Hoàng Long', N'35 chỗ', N'Đang hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (2, N'Xe khách Phương Trang', N'75F23456', N'Trần Thị Phương Trang', N'40 chỗ', N'Đang hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (3, N'Xe khách Mai Linh Express', N'75F24988', N'Lê Thị Mỹ Ngân', N'35 chỗ', N'Đang hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (4, N'Xe khách Kumo Sanco', N'45H24456', N'Nguyễn Thị Thùy Dung', N'30 chỗ', N'Dừng hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (5, N'Xe khách Thuận Thảo', N'75F230545', N'Nguyễn Thuận Thảo', N'40 chỗ', N'Dừng hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (6, N'Xe khách Việt Tân Pháp', N'88T103403', N'Văn Việt Thảo', N'45 chỗ', N'Đang hoạt động')
INSERT [dbo].[Xe] ([MaXe], [NhaXe], [BienSo], [TaiXe], [LoaiXe], [TinhTrang]) VALUES (9, N'Nhà xe Mỹ Ngân', N'34H12245', N'', N'20 chỗ', N'Đang hoạt động')
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
