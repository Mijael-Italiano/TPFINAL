USE [Gimnasio]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 10/6/2025 15:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases](
	[Id_Clase] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Clase] [varchar](50) NOT NULL,
	[Cantidad_Inscriptos] [int] NOT NULL,
	[CuotaMensual] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clases] PRIMARY KEY CLUSTERED 
(
	[Id_Clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Clase]    Script Date: 10/6/2025 15:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Clase](
	[Id_Detalle_Clases] [int] IDENTITY(1,1) NOT NULL,
	[Dia] [varchar](50) NOT NULL,
	[Horario_Inicio] [time](0) NOT NULL,
	[Horario_Fin] [time](0) NOT NULL,
	[ID_Profesor] [int] NULL,
	[ID_Clase] [int] NULL,
 CONSTRAINT [PK_Detalle_Clase] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Clases] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscriptos]    Script Date: 10/6/2025 15:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscriptos](
	[ID_Inscripto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[ID_Clase] [int] NULL,
	[DNI] [int] NOT NULL,
 CONSTRAINT [PK_Inscriptos] PRIMARY KEY CLUSTERED 
(
	[ID_Inscripto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 10/6/2025 15:12:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[ID_Profesor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sueldo] [int] NOT NULL,
	[Disciplina] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[ID_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clases] ON 

INSERT [dbo].[Clases] ([Id_Clase], [Nombre_Clase], [Cantidad_Inscriptos], [CuotaMensual]) VALUES (1, N'Gimnasio', 0, N'30000')
INSERT [dbo].[Clases] ([Id_Clase], [Nombre_Clase], [Cantidad_Inscriptos], [CuotaMensual]) VALUES (2, N'Spinning', 0, N'20000')
INSERT [dbo].[Clases] ([Id_Clase], [Nombre_Clase], [Cantidad_Inscriptos], [CuotaMensual]) VALUES (3, N'Funcional', 0, N'35000')
INSERT [dbo].[Clases] ([Id_Clase], [Nombre_Clase], [Cantidad_Inscriptos], [CuotaMensual]) VALUES (4, N'Yoga', 0, N'32000')
INSERT [dbo].[Clases] ([Id_Clase], [Nombre_Clase], [Cantidad_Inscriptos], [CuotaMensual]) VALUES (5, N'Zumba', 0, N'23000')
SET IDENTITY_INSERT [dbo].[Clases] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_Clase] ON 

INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (1, N'Lunes', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (2, N'Martes', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (3, N'Miercoles', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (4, N'Jueves', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (5, N'Viernes', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (6, N'Sabado', CAST(N'07:00:00' AS Time), CAST(N'13:00:00' AS Time), 1, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (7, N'Lunes', CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), 2, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (8, N'Martes', CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), 2, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (9, N'Miercoles', CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), 2, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (10, N'Jueves', CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), 2, 1)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (11, N'Viernes', CAST(N'14:00:00' AS Time), CAST(N'22:00:00' AS Time), 2, 1)
SET IDENTITY_INSERT [dbo].[Detalle_Clase] OFF
GO
SET IDENTITY_INSERT [dbo].[Inscriptos] ON 

INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (1, N'Mateo', N'Fernandez', NULL, 40250109)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (2, N'Camila', N'Rodriguez', NULL, 39248294)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (3, N'Lautaro', N'Gomez', NULL, 31535393)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (4, N'Valentina ', N'Morales', NULL, 42042421)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (5, N'Thiago ', N'Perez', NULL, 28929139)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (6, N'Julieta', N'Sanchez', NULL, 31341341)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (7, N'Martina', N'Diaz', NULL, 22399949)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (8, N'Benjamin', N'Herrera', NULL, 43199192)
SET IDENTITY_INSERT [dbo].[Inscriptos] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesores] ON 

INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [Disciplina]) VALUES (1, N'Joaquin', N'Romero', 500000, N'Gimnasio')
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [Disciplina]) VALUES (2, N'Abril', N'Torres', 500000, N'Gimnasio')
SET IDENTITY_INSERT [dbo].[Profesores] OFF
GO
ALTER TABLE [dbo].[Inscriptos]  WITH CHECK ADD  CONSTRAINT [FK_Inscriptos_Clases] FOREIGN KEY([ID_Clase])
REFERENCES [dbo].[Clases] ([Id_Clase])
GO
ALTER TABLE [dbo].[Inscriptos] CHECK CONSTRAINT [FK_Inscriptos_Clases]
GO
