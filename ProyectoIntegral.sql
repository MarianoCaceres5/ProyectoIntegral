USE [ProyectoIntegral]
GO
/****** Object:  User [alumno]    Script Date: 27/10/2022 14:28:15 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Carritos]    Script Date: 27/10/2022 14:28:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carritos](
	[IdCarrito] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[FechaAgregadoACarrito] [datetime] NULL,
	[CantidadUnidades] [int] NULL,
 CONSTRAINT [PK_Carritos] PRIMARY KEY CLUSTERED 
(
	[IdCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 27/10/2022 14:28:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](50) NULL,
	[FotoCategoria] [varchar](100) NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 27/10/2022 14:28:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[IdConsulta] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NULL,
	[FechaConsulta] [datetime] NULL,
	[DescripcionConsulta] [varchar](100) NULL,
	[EmailUsuario] [varchar](50) NULL,
 CONSTRAINT [PK_Consultas] PRIMARY KEY CLUSTERED 
(
	[IdConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 27/10/2022 14:28:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](50) NULL,
	[PrecioProducto] [int] NULL,
	[IdCategoria] [int] NOT NULL,
	[FotoProducto] [varchar](100) NULL,
	[MaterialProducto] [varchar](50) NULL,
	[DescripcionProducto] [varchar](100) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Carritos] ON 

INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (22, 27, CAST(N'2022-10-27T13:33:56.613' AS DateTime), 3)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (23, 3, CAST(N'2022-10-27T13:39:51.453' AS DateTime), 1)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (24, 1, CAST(N'2022-10-27T13:40:06.670' AS DateTime), 3)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (25, 31, CAST(N'2022-10-27T13:40:09.843' AS DateTime), 1)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (26, 11, CAST(N'2022-10-27T13:40:19.220' AS DateTime), 1)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (27, 12, CAST(N'2022-10-27T13:40:28.500' AS DateTime), 1)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (28, 9, CAST(N'2022-10-27T13:42:37.460' AS DateTime), 1)
INSERT [dbo].[Carritos] ([IdCarrito], [IdProducto], [FechaAgregadoACarrito], [CantidadUnidades]) VALUES (30, 46, CAST(N'2022-10-27T14:26:33.137' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Carritos] OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdCategoria], [NombreCategoria], [FotoCategoria]) VALUES (1, N'DIJES', N'https://almacendejoyas.com/img/img_articulos/thumbs/1618600475-4376570.jpg')
INSERT [dbo].[Categorias] ([IdCategoria], [NombreCategoria], [FotoCategoria]) VALUES (2, N'ANILLOS', N'https://almacendejoyas.com/img/img_articulos/thumbs/1657551098-2056645973.jpg')
INSERT [dbo].[Categorias] ([IdCategoria], [NombreCategoria], [FotoCategoria]) VALUES (3, N'PULSERAS', N'https://almacendejoyas.com/img/img_articulos/thumbs/1644351850-1726772900.jpg')
INSERT [dbo].[Categorias] ([IdCategoria], [NombreCategoria], [FotoCategoria]) VALUES (4, N'CADENA', N'https://almacendejoyas.com/img/img_articulos/thumbs/1634921511-1153297678.jpg')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Consultas] ON 

INSERT [dbo].[Consultas] ([IdConsulta], [NombreUsuario], [FechaConsulta], [DescripcionConsulta], [EmailUsuario]) VALUES (1, N'Pedrito', CAST(N'2022-10-27T13:51:30.103' AS DateTime), N'mala mia
', N'as@gmail.com')
INSERT [dbo].[Consultas] ([IdConsulta], [NombreUsuario], [FechaConsulta], [DescripcionConsulta], [EmailUsuario]) VALUES (2, N'Pedrito', CAST(N'2022-10-27T13:52:38.107' AS DateTime), N'mala mia
', N'as@gmail.com')
SET IDENTITY_INSERT [dbo].[Consultas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (1, N'Ala ángel', 14800, 1, N'https://almacendejoyas.com/img/img_articulos/1649427760-1759678283.jpg', N'Plata', N'Colgante ala, 7 cm total. Calidad en materiales')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (2, N'Medalla virgen', 13600, 1, N'https://almacendejoyas.com/img/img_articulos/1649261551-1724549111.jpg', N'Bronce', N'Medalla virgen piedras multicolor, 3,5 cm')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (3, N'Anillo solitario', 8400, 2, N'https://almacendejoyas.com/img/img_articulos/1657813281-1060550454.jpg', N'Oro', N'Anillo solitario, amarillo, piedra ovalada, medio sin fin')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (4, N'Anillo andante', 5200, 2, N'https://almacendejoyas.com/img/img_articulos/1657805769-1630887724.jpg', N'Plata', N'Anillo solitario blanco')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (5, N'Pulsera Esclava linea', 25600, 3, N'https://almacendejoyas.com/img/img_articulos/1651069456-295448413.jpg', N'Plata', N'Esclava linea premium, piedras de distinto tamaños, rosada')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (9, N'Pulsera Reina linea', 25600, 3, N'https://almacendejoyas.com/img/img_articulos/1651069404-551993277.jpg', N'Oro', N'Esclava linea premium, piedras de distinto tamaños, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (10, N'Gargantilla linea premium', 122800, 4, N'https://almacendejoyas.com/img/img_articulos/1644501594-812599517.jpg', N'Oro', N'Gargantilla linea premium, eslabonada, con piedras en el centro, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (11, N'Tic tac toe', 31200, 4, N'https://almacendejoyas.com/img/img_articulos/1618607495-1499908871.jpg', N'Plata', N'Gargantilla eslabonada tic tac toe ( precio x 45 cm)')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (12, N'La A', 21200, 1, N'https://almacendejoyas.com/img/img_articulos/1618605839-760894845.jpg', N'Plata', N'Colgante letra grande, argolla con piedras, platabella. 2,1 cm aprox ( letra sin argolla )')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (13, N'Anillo doble de oro', 10000, 2, N'https://almacendejoyas.com/img/img_articulos/1656952950-1680154902.jpg', N'Oro', N'Anillo doble, amarillo, medio sin fin y solitario de piedras baguettes')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (14, N'Linea premium', 28400, 3, N'https://almacendejoyas.com/img/img_articulos/1651065990-668442358.jpg', N'Oro', N'Pulsera linea premium, esclava, con piedras mas grandes en el centro, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (16, N'Pua de plata', 14400, 4, N'https://almacendejoyas.com/img/img_articulos/1575574835-2008926469.jpg', N'Plata', N'Corbatero tif 2 con corazon mediano')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (21, N'Collar de Bolitas', 24800, 4, N'https://almacendejoyas.com/img/img_articulos/b(15)col5_d35fb4350d648b3e09d45a8ead807be6.jpg', N'Bronce', N'collar bolitas 6 mm ( precio x 40 cms )')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (23, N'Anillo Sin Fin', 7200, 2, N'https://almacendejoyas.com/img/img_articulos/1657548958-1397388836.jpg', N'Oro', N'piedras redondas grandes adelante y doble fila pavee atras')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (24, N'Anillo solitario', 6400, 2, N'https://almacendejoyas.com/img/img_articulos/1539868131-1116181253.jpg', N'Plata', N'piedra baguette azul, y blancas a los costados')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (25, N'Collar Piedra Negra', 6400, 4, N'https://almacendejoyas.com/img/img_articulos/1656688751-1484123159.jpg', N'Oro', N'Collar de oro con pierda negra ')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (26, N'Bonzai', 8400, 1, N'https://almacendejoyas.com/img/img_articulos/AQ51_aq51.jpg.jpg', N'Plata', N'Dije fondo blanco arbol de la vida chico 21 mm')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (27, N'La Llave De Tu Corazón', 8000, 1, N'https://almacendejoyas.com/img/img_articulos/1602000713-1079639318.jpg', N'Oro', N'Colgante llave grande amarilla . 5,6 cm largo total')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (28, N'Rayito', 3588, 1, N'https://almacendejoyas.com/img/img_articulos/1559847874-955691578.jpg', N'Plata', N'Dije rayo con esmalte negro')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (29, N'Black Rosary', 26800, 4, N'https://almacendejoyas.com/img/img_articulos/0(29)004hk4864_0(29)004hk4864.jpg.jpg', N'Plata', N'rosario piedras negras, medalla con piedras blancas')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (30, N'zZimmuZz', 94400, 4, N'https://almacendejoyas.com/img/img_articulos/1644499903-1567984129.jpg', N'Oro', N'Gargantilla linea premium con ovalo pavee central, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (31, N'Cleopatra', 40000, 4, N'https://almacendejoyas.com/img/img_articulos/1556120651-164437830.jpg', N'Oro y Platino', N'Gargantilla linea premium, de piedras blancas, semi rigida, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (32, N'Pulsera Esclava', 37200, 3, N'https://almacendejoyas.com/img/img_articulos/1651063587-1169540752.jpg', N'Plata', N'linea premium, piedras baguettes azules y verdes, y piedras redondas blancas, cierre cajon')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (33, N'Pulsera Mariposa', 4000, 3, N'https://almacendejoyas.com/img/img_articulos/1647284493-827489562.jpg', N'Oro ', N'Pulsera mariposa piedra celeste')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (34, N'Pulsera Doble Cadena', 6400, 3, N'https://almacendejoyas.com/img/img_articulos/1647357434-720091455.jpg', N'Plata', N'Pulsera de Doble Cadena conectada con chapa')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (36, N'Pulsera Top G''s', 86800, 3, N'https://almacendejoyas.com/img/img_articulos/1644420069-192572296.jpg', N'Oro y Pierdas ', N'Pulsera linea premium, grumet, piedras blancas, rosada')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (37, N'Pulsera Mariposa Doble', 14400, 3, N'https://almacendejoyas.com/img/img_articulos/1632146890-1209225552.jpg', N'Oro', N'Pulsera esclava linea premium, abierta, mariposas pavee, amarilla')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (38, N'Pulsera De Campanas', 12800, 3, N'https://almacendejoyas.com/img/img_articulos/1572546004-788068449.jpg', N'Plata', N'Pulsera de plata con colgante de campanas')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (39, N'Pulsera MultiCorazones', 10800, 3, N'https://almacendejoyas.com/img/img_articulos/1572533319-853949697.jpg', N'Plata', N'Pulsera bolitas con corazones')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (40, N'Pulsera Luna y Sol', 10000, 3, N'https://almacendejoyas.com/img/img_articulos/1596486906-277528673.jpg', N'Oro', N'Pulsera eslabonada amarilla con dijes luna y estrella pavee')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (41, N'Anillo triple con cruz', 5200, 2, N'https://almacendejoyas.com/img/img_articulos/1656957763-520126452.jpg', N'Oro y Platino', N'Anillo triple, amarillo, bolitas, con cruz de piedras')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (42, N'Anillo Con Gema Verde', 6000, 2, N'https://almacendejoyas.com/img/img_articulos/1656688606-1875346704.jpg', N'Oro', N'Anillo amarillo doble, eslabonado y medio sin fin con piedra verde')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (43, N'Anillo Sobresalido', 14800, 2, N'https://almacendejoyas.com/img/img_articulos/1556302584-1808897775.jpg', N'Oro y Platino', N'Anillo linea premium, clavo, con piedras, amarillo')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (45, N'Anillo Doble Vuelta Al Mundo', 28000, 2, N'https://almacendejoyas.com/img/img_articulos/1651162507-671807164.jpg', N'Oro', N'Anillo linea premium, cruzado, piedras baguettes azules y verdes, amarillo')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (46, N'Anillo Parrilla', 12800, 2, N'https://almacendejoyas.com/img/img_articulos/1553199648-671922839.jpg', N'Oro', N'Anillo linea Premium, medio sin fin pavee, con piedras en los costados, amarillo')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (47, N'Anillo III', 12800, 2, N'https://almacendejoyas.com/img/img_articulos/1651079291-217080594.jpg', N'Oro Platinado', N'Anillo linea premium, eslabonado, solitario, piedras redondas, baguettes y carre, amarillo')
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [PrecioProducto], [IdCategoria], [FotoProducto], [MaterialProducto], [DescripcionProducto]) VALUES (48, N'Anillo corazon en copa de nieve', 3696, 2, N'https://almacendejoyas.com/img/img_articulos/1601578693-695324090.jpg', N'Plata', NULL)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
ALTER TABLE [dbo].[Carritos]  WITH CHECK ADD  CONSTRAINT [FK_Carritos_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[Carritos] CHECK CONSTRAINT [FK_Carritos_Productos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
