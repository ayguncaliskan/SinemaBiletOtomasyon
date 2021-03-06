USE [Sinema_Bileti]
GO
/****** Object:  Table [dbo].[Film_Bilgileri]    Script Date: 24.05.2020 23:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film_Bilgileri](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [varchar](50) NOT NULL,
	[Yonetmen] [varchar](50) NULL,
	[FilmTuru] [varchar](50) NULL,
	[FilmSuresi] [varchar](50) NULL,
	[tarih] [varchar](50) NULL,
	[YapimYili] [varchar](50) NULL,
	[Resim] [varchar](100) NULL,
 CONSTRAINT [PK_Film_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[FilmAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasiyer_Bilgileri]    Script Date: 24.05.2020 23:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasiyer_Bilgileri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kasiyer_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon_Bilgileri]    Script Date: 24.05.2020 23:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon_Bilgileri](
	[SalonId] [int] IDENTITY(1,1) NOT NULL,
	[SalonAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Salon_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[SalonAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis_Bilgileri]    Script Date: 24.05.2020 23:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis_Bilgileri](
	[SatısId] [int] IDENTITY(1,1) NOT NULL,
	[KoltukNO] [varchar](50) NULL,
	[SalonAdi] [varchar](50) NULL,
	[FilmAdi] [varchar](50) NULL,
	[Tarih] [varchar](50) NULL,
	[Saat] [varchar](50) NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Ucret] [varchar](50) NULL,
	[Tarih2] [varchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Satis_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[SatısId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seans_Bilgileri]    Script Date: 24.05.2020 23:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seans_Bilgileri](
	[SeansId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [varchar](50) NULL,
	[SalonAdi] [varchar](50) NULL,
	[Tarih] [varchar](50) NULL,
	[Seans] [varchar](50) NULL,
 CONSTRAINT [PK_Seans_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[SeansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Film_Bilgileri] ON 

INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (15, N'Alita:Savaş Melegi', N'Robert Rodriguez', N'Bilim Kurgu', N' 2 saat 2 dakika', N'21.05.2020', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\alita.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (6, N'Avengers Endgame', N'Joe Russo', N'Fantastik', N'3 saat 1 dakika', N'May  8 2020 12:00AM', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\avengers.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (12, N'Ayla', N'Can Ulkay', N'Dram', N'2 saat 5 dakika', N'May 25 2020 12:00AM', N'2017', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\ayla.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (16, N'Hababam Sınıfı', N'Ertem Eğilmez', N'Komedi', N'1 saat 30 dakika', N'May 21 2020 12:00AM', N'1975', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\Hababam-sinifi.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (14, N'Joker', N'Todd Philips', N'Dram', N'2 saat 2 dakika', N'21.05.2020', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\joker.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (4, N'Naim Süleymanoğlu', N'Hilal Saral', N'Dram', N'2 saat 21 dakika', N'May  8 2020 12:00AM', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\Naim-Süleymanoğlı.jpeg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (17, N'Organize İşler', N'Yılmaz Erdoğan', N'Komedi', N'2 saat 1 dakika', N'May 21 2020 12:00AM', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\organize_işler.jpg')
INSERT [dbo].[Film_Bilgileri] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (5, N'Recep İvedik 6', N'Togan Gökbakar', N'Komedi', N'1 saat 50 dakika', N'May  8 2020 12:00AM', N'2019', N'C:\Users\aygün\Desktop\Sinema bilet Proje\FilmAfişleri\recepivedik6.jpeg')
SET IDENTITY_INSERT [dbo].[Film_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Kasiyer_Bilgileri] ON 

INSERT [dbo].[Kasiyer_Bilgileri] ([id], [KullaniciAdi], [Sifre]) VALUES (1, N'aygün', N'12345')
INSERT [dbo].[Kasiyer_Bilgileri] ([id], [KullaniciAdi], [Sifre]) VALUES (2, N'orhan', N'12345')
INSERT [dbo].[Kasiyer_Bilgileri] ([id], [KullaniciAdi], [Sifre]) VALUES (3, N'yigit', N'12345')
SET IDENTITY_INSERT [dbo].[Kasiyer_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] ON 

INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (11, N'Salon-1')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (6, N'Salon-2')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (7, N'Salon-3')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (8, N'Salon-4')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (9, N'Salon-5')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (10, N'Salon-6')
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] ON 

INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (1, N'25', N'Salon-1', N'Film-1', N'09.05.2020', N'11:00:00', N'Aygün', N'Çalışkan', N'15', N'08.05.2020', NULL)
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (2, N'21', N'Salon-1', N'Avengers Endgame', N'12.05.2020', N'10:00:00', N'Aygün', N'Çalışkan', N'15', N'11.05.2020 10:05:21', NULL)
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (3, N'13', N'Salon-1', N'Avengers Endgame', N'12.05.2020', N'10:00:00', N'Mehmet', N'Obuz', N'15', N'11.05.2020 10:05:46', NULL)
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (4, N'29', N'Salon-2', N'Avengers Endgame', N'20.05.2020', N'10:00:00', N'Aygün', N'Çalışkan', N'15', N'13.05.2020 05:13:18', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (5, N'13', N'Salon-2', N'Avengers Endgame', N'20.05.2020', N'10:00:00', N'Mehmet', N'Çalışkan', N'15', N'13.05.2020 23:46:23', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (7, N'18', N'Salon-2', N'Avengers Endgame', N'19.05.2020', N'21:00:00', N'Mehmet', N'Binici', N'15', N'19.05.2020 20:02:04', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (8, N'20', N'Salon-1', N'Alita:Savaş Melegi', N'3.06.2020', N'14:00:00', N'Ali', N'Çabuk', N'15', N'21.05.2020 14:26:59', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (9, N'34', N'Salon-1', N'Alita:Savaş Melegi', N'3.06.2020', N'14:00:00', N'Hasan', N'Çabuk', N'15', N'21.05.2020 14:27:15', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (10, N'39', N'Salon-1', N'Alita:Savaş Melegi', N'3.06.2020', N'14:00:00', N'Mehmet', N'Çabuk', N'15', N'21.05.2020 14:27:37', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (11, N'4', N'Salon-2', N'Alita:Savaş Melegi', N'4.06.2020', N'13:00:00', N'Ayşe', N'Harman', N'15', N'21.05.2020 14:28:12', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (12, N'18', N'Salon-2', N'Alita:Savaş Melegi', N'4.06.2020', N'13:00:00', N'Veli', N'Harman', N'15', N'21.05.2020 14:28:26', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (13, N'43', N'Salon-2', N'Alita:Savaş Melegi', N'4.06.2020', N'13:00:00', N'Nazım', N'Harman', N'15', N'21.05.2020 14:28:38', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (14, N'33', N'Salon-3', N'Alita:Savaş Melegi', N'5.06.2020', N'15:00:00', N'Hüseyin', N'Temiz', N'15', N'21.05.2020 14:28:58', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (15, N'35', N'Salon-3', N'Alita:Savaş Melegi', N'5.06.2020', N'15:00:00', N'Halim', N'Temiz', N'15', N'21.05.2020 14:29:12', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (16, N'11', N'Salon-3', N'Alita:Savaş Melegi', N'5.06.2020', N'15:00:00', N'Nurgül', N'Temiz', N'15', N'21.05.2020 14:29:28', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (17, N'58', N'Salon-4', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'Erbil', N'Sancaktar', N'15', N'21.05.2020 14:30:05', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (18, N'34', N'Salon-4', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'Hamide', N'Sancaktar', N'15', N'21.05.2020 14:30:14', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (19, N'44', N'Salon-4', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'İsranur', N'Sancaktar', N'15', N'21.05.2020 14:30:24', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (20, N'36', N'Salon-5', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'Aygün', N'Çalışkan', N'15', N'21.05.2020 14:30:47', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (21, N'49', N'Salon-5', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'Ayşe', N'Çalışkan', N'15', N'21.05.2020 14:30:57', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (22, N'26', N'Salon-5', N'Alita:Savaş Melegi', N'6.06.2020', N'18:00:00', N'Mümin', N'Çalışkan', N'15', N'21.05.2020 14:31:08', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (23, N'17', N'Salon-6', N'Alita:Savaş Melegi', N'7.06.2020', N'20:00:00', N'Yeliz', N'yerli', N'15', N'21.05.2020 14:31:29', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (24, N'42', N'Salon-6', N'Alita:Savaş Melegi', N'7.06.2020', N'20:00:00', N'Fİliz', N'yerli', N'15', N'21.05.2020 14:31:39', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (25, N'12', N'Salon-6', N'Alita:Savaş Melegi', N'7.06.2020', N'20:00:00', N'Musa', N'Yerli', N'15', N'21.05.2020 14:31:48', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (26, N'41', N'Salon-1', N'Avengers Endgame', N'2.06.2020', N'17:00:00', N'Mehmet', N'Bir', N'15', N'21.05.2020 14:32:46', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (27, N'59', N'Salon-1', N'Avengers Endgame', N'2.06.2020', N'17:00:00', N'Hasan', N'İki', N'15', N'21.05.2020 14:32:57', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (28, N'28', N'Salon-1', N'Avengers Endgame', N'2.06.2020', N'17:00:00', N'Hüseyin', N'Üç', N'15', N'21.05.2020 14:33:05', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (29, N'31', N'Salon-2', N'Avengers Endgame', N'3.06.2020', N'19:00:00', N'Harun', N'Uğraş', N'15', N'21.05.2020 14:33:26', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (30, N'51', N'Salon-2', N'Avengers Endgame', N'3.06.2020', N'19:00:00', N'Mert', N'Uğraş', N'15', N'21.05.2020 14:33:35', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (31, N'18', N'Salon-2', N'Avengers Endgame', N'3.06.2020', N'19:00:00', N'Ergül', N'Uğraş', N'15', N'21.05.2020 14:33:48', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (32, N'40', N'Salon-3', N'Avengers Endgame', N'4.06.2020', N'16:00:00', N'Hamide', N'Yılmaz', N'15', N'21.05.2020 14:34:28', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (33, N'63', N'Salon-3', N'Avengers Endgame', N'4.06.2020', N'16:00:00', N'Nur', N'Yılmaz', N'15', N'21.05.2020 14:34:37', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (34, N'59', N'Salon-3', N'Avengers Endgame', N'4.06.2020', N'16:00:00', N'Ergin', N'Yılmaz', N'15', N'21.05.2020 14:34:48', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (35, N'34', N'Salon-4', N'Avengers Endgame', N'5.06.2020', N'14:00:00', N'Aygün', N'Bir', N'15', N'21.05.2020 14:35:34', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (36, N'60', N'Salon-4', N'Avengers Endgame', N'5.06.2020', N'14:00:00', N'Orhan', N'İki', N'15', N'21.05.2020 14:35:47', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (37, N'12', N'Salon-4', N'Avengers Endgame', N'5.06.2020', N'14:00:00', N'Yigit', N'Üç', N'15', N'21.05.2020 14:36:03', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (38, N'36', N'Salon-6', N'Avengers Endgame', N'7.06.2020', N'19:00:00', N'Ali', N'Pir', N'15', N'21.05.2020 14:36:30', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (39, N'55', N'Salon-6', N'Avengers Endgame', N'7.06.2020', N'19:00:00', N'Veli', N'Pir', N'15', N'21.05.2020 14:36:41', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (40, N'18', N'Salon-6', N'Avengers Endgame', N'7.06.2020', N'19:00:00', N'Abdullah', N'Pir', N'15', N'21.05.2020 14:37:01', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (41, N'47', N'Salon-1', N'Ayla', N'2.06.2020', N'15:00:00', N'Ayla', N'gezgin', N'15', N'21.05.2020 14:37:28', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (42, N'59', N'Salon-1', N'Ayla', N'2.06.2020', N'15:00:00', N'Nuriye', N'Gezgin', N'15', N'21.05.2020 14:37:38', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (43, N'34', N'Salon-1', N'Ayla', N'2.06.2020', N'15:00:00', N'Basri', N'Gezgin', N'15', N'21.05.2020 14:38:01', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (44, N'39', N'Salon-2', N'Ayla', N'3.06.2020', N'18:00:00', N'Veli', N'Kanık', N'15', N'21.05.2020 14:46:00', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (45, N'52', N'Salon-2', N'Ayla', N'3.06.2020', N'18:00:00', N'Ali', N'Kınık', N'15', N'21.05.2020 14:46:10', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (46, N'19', N'Salon-2', N'Ayla', N'3.06.2020', N'18:00:00', N'Veysel ', N'Kınık', N'15', N'21.05.2020 14:46:22', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (47, N'51', N'Salon-3', N'Ayla', N'4.06.2020', N'14:00:00', N'Ertuğrul', N'Sağlam', N'15', N'21.05.2020 14:47:10', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (48, N'39', N'Salon-4', N'Ayla', N'5.06.2020', N'13:00:00', N'Burak', N'Sağlam', N'15', N'21.05.2020 14:47:26', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (49, N'8', N'Salon-4', N'Ayla', N'3.06.2020', N'14:00:00', N'Akile', N'Sağlam', N'15', N'21.05.2020 14:47:47', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (50, N'64', N'Salon-5', N'Ayla', N'6.06.2020', N'12:00:00', N'Buse', N'Sağlam', N'15', N'21.05.2020 14:48:04', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (51, N'4', N'Salon-6', N'Ayla', N'7.06.2020', N'15:00:00', N'Mürsel', N'Gezgin', N'15', N'21.05.2020 14:48:24', N'aygün')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (52, N'43', N'Salon-1', N'Hababam Sınıfı', N'2.06.2020', N'13:00:00', N'Yigit', N'Yanık', N'15', N'21.05.2020 15:19:00', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (53, N'38', N'Salon-2', N'Hababam Sınıfı', N'3.06.2020', N'13:00:00', N'Orhan', N'Özbek', N'15', N'21.05.2020 15:19:22', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (54, N'47', N'Salon-3', N'Hababam Sınıfı', N'4.06.2020', N'12:00:00', N'Aygün', N'Çalışkan', N'15', N'21.05.2020 15:19:41', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (55, N'40', N'Salon-4', N'Hababam Sınıfı', N'5.06.2020', N'19:00:00', N'Mert', N'Sarsılmaz', N'15', N'21.05.2020 15:20:31', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (56, N'47', N'Salon-5', N'Hababam Sınıfı', N'6.06.2020', N'16:00:00', N'Barış', N'Gökdemir', N'15', N'21.05.2020 15:20:53', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (57, N'64', N'Salon-6', N'Hababam Sınıfı', N'7.06.2020', N'12:00:00', N'Berk', N'Keçili', N'15', N'21.05.2020 15:21:06', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (58, N'24', N'Salon-1', N'Joker', N'2.06.2020', N'11:00:00', N'Batuhan', N'Erdoğuş', N'15', N'21.05.2020 15:21:29', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (59, N'42', N'Salon-2', N'Joker', N'3.06.2020', N'11:00:00', N'Ahmet', N'Karadağ', N'15', N'21.05.2020 15:24:15', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (60, N'48', N'Salon-3', N'Joker', N'4.06.2020', N'15:00:00', N'Batuhan', N'Yaşar', N'15', N'21.05.2020 15:24:30', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (61, N'7', N'Salon-4', N'Joker', N'5.06.2020', N'16:00:00', N'Hasan', N'Çalık', N'15', N'21.05.2020 15:25:17', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (62, N'48', N'Salon-5', N'Joker', N'6.06.2020', N'20:00:00', N'Batuhan', N'Yaşar', N'15', N'21.05.2020 15:25:37', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (63, N'18', N'Salon-1', N'Naim Süleymanoğlu', N'2.06.2020', N'16:00:00', N'Arif', N'Öztürk', N'15', N'21.05.2020 15:26:49', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (64, N'39', N'Salon-2', N'Naim Süleymanoğlu', N'3.06.2020', N'10:00:00', N'Melis', N'Genç', N'15', N'21.05.2020 15:27:11', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (65, N'39', N'Salon-3', N'Naim Süleymanoğlu', N'4.06.2020', N'17:00:00', N'Oğulcan', N'Baki', N'15', N'21.05.2020 15:27:33', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (66, N'16', N'Salon-4', N'Naim Süleymanoğlu', N'4.06.2020', N'17:00:00', N'Tunahan', N'Kavuşan', N'15', N'21.05.2020 15:28:20', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (67, N'2', N'Salon-5', N'Naim Süleymanoğlu', N'5.06.2020', N'15:00:00', N'Enes', N'Kavuşan', N'15', N'21.05.2020 15:28:36', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (68, N'32', N'Salon-6', N'Naim Süleymanoğlu', N'7.06.2020', N'10:00:00', N'Hasan', N'Yıldırım', N'15', N'21.05.2020 15:29:03', N'yigit')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (69, N'32', N'Salon-1', N'Organize İşler', N'2.06.2020', N'10:00:00', N'Hasan', N'Sabit', N'15', N'21.05.2020 15:38:43', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (70, N'17', N'Salon-1', N'Organize İşler', N'2.06.2020', N'10:00:00', N'Derya', N'Ercan', N'15', N'21.05.2020 15:38:59', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (71, N'54', N'Salon-2', N'Organize İşler', N'3.06.2020', N'17:00:00', N'Yusuf', N'Bedir', N'15', N'21.05.2020 15:39:27', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (72, N'15', N'Salon-4', N'Organize İşler', N'5.06.2020', N'17:00:00', N'Ali', N'Bedir', N'15', N'21.05.2020 15:39:46', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (73, N'55', N'Salon-5', N'Organize İşler', N'6.06.2020', N'15:00:00', N'Şebnem', N'Ejder', N'15', N'21.05.2020 15:40:06', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (74, N'24', N'Salon-6', N'Organize İşler', N'7.06.2020', N'16:00:00', N'Lara', N'Tavaslı', N'15', N'21.05.2020 15:40:21', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (75, N'32', N'Salon-1', N'Recep İvedik 6', N'2.06.2020', N'14:00:00', N'Siray', N'Ecebay', N'15', N'21.05.2020 15:40:37', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (76, N'13', N'Salon-2', N'Recep İvedik 6', N'3.06.2020', N'16:00:00', N'İnanç', N'Ortanca', N'15', N'21.05.2020 15:40:56', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (77, N'15', N'Salon-3', N'Recep İvedik 6', N'4.06.2020', N'18:00:00', N'Ahmet', N'Akkuş', N'15', N'21.05.2020 15:41:09', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (78, N'16', N'Salon-4', N'Recep İvedik 6', N'5.06.2020', N'18:00:00', N'Fatma', N'Hacılar', N'15', N'21.05.2020 15:41:52', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (79, N'16', N'Salon-5', N'Recep İvedik 6', N'6.06.2020', N'21:00:00', N'Gamze', N'İçli', N'15', N'21.05.2020 15:42:11', N'orhan')
INSERT [dbo].[Satis_Bilgileri] ([SatısId], [KoltukNO], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2], [KullaniciAdi]) VALUES (80, N'57', N'Salon-6', N'Recep İvedik 6', N'7.06.2020', N'18:00:00', N'Kenan', N'Pars', N'15', N'21.05.2020 15:42:25', N'orhan')
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] ON 

INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (6, N'Avengers Endgame', N'Salon-2', N'20.05.2020', N'10:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (7, N'Avengers Endgame', N'Salon-4', N'14.05.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (8, N'Avengers Endgame', N'Salon-5', N'19.05.2020', N'21:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (9, N'Avengers Endgame', N'Salon-2', N'19.05.2020', N'21:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (10, N'Ayla', N'Salon-4', N'3.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (11, N'Alita:Savaş Melegi', N'Salon-1', N'3.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (12, N'Alita:Savaş Melegi', N'Salon-2', N'4.06.2020', N'13:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (13, N'Alita:Savaş Melegi', N'Salon-3', N'5.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (14, N'Alita:Savaş Melegi', N'Salon-4', N'6.06.2020', N'18:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (15, N'Alita:Savaş Melegi', N'Salon-5', N'6.06.2020', N'18:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (16, N'Alita:Savaş Melegi', N'Salon-6', N'7.06.2020', N'20:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (17, N'Avengers Endgame', N'Salon-1', N'2.06.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (18, N'Avengers Endgame', N'Salon-2', N'3.06.2020', N'19:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (19, N'Avengers Endgame', N'Salon-3', N'4.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (20, N'Avengers Endgame', N'Salon-4', N'5.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (21, N'Avengers Endgame', N'Salon-6', N'7.06.2020', N'19:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (22, N'Ayla', N'Salon-1', N'2.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (23, N'Ayla', N'Salon-2', N'3.06.2020', N'18:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (24, N'Ayla', N'Salon-3', N'4.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (25, N'Ayla', N'Salon-4', N'5.06.2020', N'13:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (26, N'Ayla', N'Salon-5', N'6.06.2020', N'12:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (27, N'Ayla', N'Salon-6', N'7.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (28, N'Hababam Sınıfı', N'Salon-1', N'2.06.2020', N'13:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (29, N'Hababam Sınıfı', N'Salon-2', N'3.06.2020', N'13:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (30, N'Hababam Sınıfı', N'Salon-3', N'4.06.2020', N'12:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (31, N'Hababam Sınıfı', N'Salon-4', N'5.06.2020', N'19:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (32, N'Hababam Sınıfı', N'Salon-5', N'6.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (33, N'Hababam Sınıfı', N'Salon-6', N'7.06.2020', N'12:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (34, N'Joker', N'Salon-1', N'2.06.2020', N'11:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (35, N'Joker', N'Salon-2', N'3.06.2020', N'11:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (36, N'Joker', N'Salon-3', N'4.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (37, N'Joker', N'Salon-4', N'5.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (38, N'Joker', N'Salon-5', N'6.06.2020', N'20:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (39, N'Joker', N'Salon-6', N'7.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (40, N'Naim Süleymanoğlu', N'Salon-1', N'2.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (41, N'Naim Süleymanoğlu', N'Salon-2', N'3.06.2020', N'10:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (42, N'Naim Süleymanoğlu', N'Salon-3', N'4.06.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (43, N'Naim Süleymanoğlu', N'Salon-4', N'4.06.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (44, N'Naim Süleymanoğlu', N'Salon-5', N'5.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (45, N'Naim Süleymanoğlu', N'Salon-6', N'7.06.2020', N'10:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (46, N'Organize İşler', N'Salon-1', N'2.06.2020', N'10:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (47, N'Organize İşler', N'Salon-2', N'3.06.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (48, N'Organize İşler', N'Salon-4', N'5.06.2020', N'17:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (49, N'Organize İşler', N'Salon-5', N'6.06.2020', N'15:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (50, N'Organize İşler', N'Salon-6', N'7.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (51, N'Recep İvedik 6', N'Salon-1', N'2.06.2020', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (52, N'Recep İvedik 6', N'Salon-2', N'3.06.2020', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (53, N'Recep İvedik 6', N'Salon-3', N'4.06.2020', N'18:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (54, N'Recep İvedik 6', N'Salon-4', N'5.06.2020', N'18:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (55, N'Recep İvedik 6', N'Salon-5', N'6.06.2020', N'21:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (56, N'Recep İvedik 6', N'Salon-6', N'7.06.2020', N'18:00:00')
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] OFF
GO
ALTER TABLE [dbo].[Satis_Bilgileri]  WITH CHECK ADD  CONSTRAINT [FK_Satis_Bilgileri_Kasiyer_Bilgileri] FOREIGN KEY([KullaniciAdi])
REFERENCES [dbo].[Kasiyer_Bilgileri] ([KullaniciAdi])
GO
ALTER TABLE [dbo].[Satis_Bilgileri] CHECK CONSTRAINT [FK_Satis_Bilgileri_Kasiyer_Bilgileri]
GO
ALTER TABLE [dbo].[Seans_Bilgileri]  WITH CHECK ADD  CONSTRAINT [FK_Seans_Bilgileri_Film_Bilgileri] FOREIGN KEY([FilmAdi])
REFERENCES [dbo].[Film_Bilgileri] ([FilmAdi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seans_Bilgileri] CHECK CONSTRAINT [FK_Seans_Bilgileri_Film_Bilgileri]
GO
ALTER TABLE [dbo].[Seans_Bilgileri]  WITH CHECK ADD  CONSTRAINT [FK_Seans_Bilgileri_Salon_Bilgileri] FOREIGN KEY([SalonAdi])
REFERENCES [dbo].[Salon_Bilgileri] ([SalonAdi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seans_Bilgileri] CHECK CONSTRAINT [FK_Seans_Bilgileri_Salon_Bilgileri]
GO
