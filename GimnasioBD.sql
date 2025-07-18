USE [GimnasioDB]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 6/7/2025 22:38:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases](
	[Id_Clase] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad_Inscriptos] [int] NOT NULL,
	[CuotaMensual] [varchar](50) NOT NULL,
	[Id_Disciplina] [int] NULL,
	[Maximo_Inscriptos] [int] NULL,
 CONSTRAINT [PK_Clases] PRIMARY KEY CLUSTERED 
(
	[Id_Clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Clase]    Script Date: 6/7/2025 22:38:24 ******/
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
/****** Object:  Table [dbo].[Disciplina]    Script Date: 6/7/2025 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[Id_Disciplina] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Disciplina] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[Id_Disciplina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscriptos]    Script Date: 6/7/2025 22:38:24 ******/
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
/****** Object:  Table [dbo].[Profesores]    Script Date: 6/7/2025 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[ID_Profesor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sueldo] [int] NOT NULL,
	[DNI] [int] NOT NULL,
	[Id_Disciplina] [int] NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[ID_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clases] ON 

INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (1, 5, N'30000', 1, 1000)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (2, 0, N'20000', 2, 30)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (3, 0, N'35000', 3, 25)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (6, 0, N'30000', 5, 30)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (7, 0, N'30000', 5, 30)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (8, 0, N'30000', 5, 15)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (9, 0, N'20000', 2, 15)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (10, 0, N'20000', 2, 15)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (11, 0, N'20000', 2, 15)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (13, 1, N'35000', 3, 25)
INSERT [dbo].[Clases] ([Id_Clase], [Cantidad_Inscriptos], [CuotaMensual], [Id_Disciplina], [Maximo_Inscriptos]) VALUES (18, 0, N'30000', 5, 15)
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
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (12, N'Lunes', CAST(N'13:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 7)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (13, N'Miércoles', CAST(N'13:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 7)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (14, N'Viernes', CAST(N'13:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 7)
INSERT [dbo].[Detalle_Clase] ([Id_Detalle_Clases], [Dia], [Horario_Inicio], [Horario_Fin], [ID_Profesor], [ID_Clase]) VALUES (22, N'Lunes', CAST(N'17:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 8)
SET IDENTITY_INSERT [dbo].[Detalle_Clase] OFF
GO
SET IDENTITY_INSERT [dbo].[Disciplina] ON 

INSERT [dbo].[Disciplina] ([Id_Disciplina], [Nombre_Disciplina]) VALUES (1, N'Gimnasio')
INSERT [dbo].[Disciplina] ([Id_Disciplina], [Nombre_Disciplina]) VALUES (2, N'Spinning')
INSERT [dbo].[Disciplina] ([Id_Disciplina], [Nombre_Disciplina]) VALUES (3, N'Funcional')
INSERT [dbo].[Disciplina] ([Id_Disciplina], [Nombre_Disciplina]) VALUES (4, N'Yoga')
INSERT [dbo].[Disciplina] ([Id_Disciplina], [Nombre_Disciplina]) VALUES (5, N'Zumba')
SET IDENTITY_INSERT [dbo].[Disciplina] OFF
GO
SET IDENTITY_INSERT [dbo].[Inscriptos] ON 

INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (1, N'Mateo', N'Fernandez', 1, 40250109)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (2, N'Camila', N'Rodriguez', 1, 39248294)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (4, N'Valentina ', N'Morales', 1, 42042421)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (5, N'Thiago ', N'Perez', 1, 28929139)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (7, N'Martina', N'Diaz', 1, 22399949)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (8, N'Juan', N'Herrera', NULL, 33431469)
INSERT [dbo].[Inscriptos] ([ID_Inscripto], [Nombre], [Apellido], [ID_Clase], [DNI]) VALUES (9, N'Jose', N'Hernandez', 13, 34134905)
SET IDENTITY_INSERT [dbo].[Inscriptos] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesores] ON 

INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (1, N'Joaquin', N'Romero', 500000, 40253535, 1)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (2, N'Abril', N'Torres', 500000, 29012529, 1)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (7, N'Camila', N'Pedrova', 660000, 28052125, 2)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (8, N'Nicolas', N'O´connor', 700000, 43351135, 3)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (9, N'Agostina ', N'Muller', 550000, 34989080, 3)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (10, N'Mateo', N'Ofakor', 500000, 34314134, 4)
INSERT [dbo].[Profesores] ([ID_Profesor], [Nombre], [Apellido], [Sueldo], [DNI], [Id_Disciplina]) VALUES (11, N'Florecia', N'Haddad', 450000, 43134134, 4)
SET IDENTITY_INSERT [dbo].[Profesores] OFF
GO
ALTER TABLE [dbo].[Clases]  WITH CHECK ADD  CONSTRAINT [FK_Clases_Disciplina] FOREIGN KEY([Id_Disciplina])
REFERENCES [dbo].[Disciplina] ([Id_Disciplina])
GO
ALTER TABLE [dbo].[Clases] CHECK CONSTRAINT [FK_Clases_Disciplina]
GO
ALTER TABLE [dbo].[Detalle_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Clase_Clases] FOREIGN KEY([ID_Clase])
REFERENCES [dbo].[Clases] ([Id_Clase])
GO
ALTER TABLE [dbo].[Detalle_Clase] CHECK CONSTRAINT [FK_Detalle_Clase_Clases]
GO
ALTER TABLE [dbo].[Detalle_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Clase_Profesores] FOREIGN KEY([ID_Profesor])
REFERENCES [dbo].[Profesores] ([ID_Profesor])
GO
ALTER TABLE [dbo].[Detalle_Clase] CHECK CONSTRAINT [FK_Detalle_Clase_Profesores]
GO
ALTER TABLE [dbo].[Inscriptos]  WITH CHECK ADD  CONSTRAINT [FK_Inscriptos_Clases] FOREIGN KEY([ID_Clase])
REFERENCES [dbo].[Clases] ([Id_Clase])
GO
ALTER TABLE [dbo].[Inscriptos] CHECK CONSTRAINT [FK_Inscriptos_Clases]
GO
ALTER TABLE [dbo].[Profesores]  WITH CHECK ADD  CONSTRAINT [FK_Profesores_Disciplina] FOREIGN KEY([Id_Disciplina])
REFERENCES [dbo].[Disciplina] ([Id_Disciplina])
GO
ALTER TABLE [dbo].[Profesores] CHECK CONSTRAINT [FK_Profesores_Disciplina]
GO
