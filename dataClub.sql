USE [db_club]
GO
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (1, N'Natación', 5000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (2, N'Fútbol', 4000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (3, N'Tenis', 6000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (4, N'Yoga', 300)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (5, N'Baloncesto', 4500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (6, N'Voleibol', 3500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (7, N'Hockey', 5500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (8, N'Rugby', 2500)
GO
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (1, N'Piscina Olímpica', 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (2, N'Cancha de Fútbol 1', 2)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (3, N'Cancha de Tenis', 3)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (4, N'Sala de Yoga', 4)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (5, N'Cancha de Hockey', 7)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (6, N'Cancha de Baloncesto', 5)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (7, N'Cancha de Voleibol', 6)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (8, N'Cancha de Rugby', 8)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad]) VALUES (9, N'Cancha de Fútbol 2', 2)
GO
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (2, N's', N's', N's', N's', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (5, N'e', N'e', N'e', N'e', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (9, N'p', N'p', N'p', N'p', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (10, N'aa', N'aa', N'aa', N'aa', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (11, N'tomas', N'broda', N'tomasbroda@gmail.com', N'asd', N'admin')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (2277738, N'Philipa', N'Prest', N'pprest8@chronoengine.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (3868035, N'Sigfrid', N'Hiley', N'shiley0@noaa.gov', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (10101010, N'Alejandro', N'Foresi', NULL, N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (14662575, N'Binny', N'Tullis', N'btullis4@answers.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (20202020, N'Robbert', N'Coulson', N'rcoulson3@reverbnation.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (30303030, N'Nom', N'asa', N'sdds', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (36337493, N'Gay', N'Cleatherow', N'gcleatherow6@ustream.tv', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (37893642, N'Melessa', N'Fidler', N'mfidler9@prweb.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (42927655, N'Margit', N'Haggus', N'mhaggus1@cdbaby.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (43590396, N'Guillema', N'Josiah', N'gjosiah7@accuweather.com', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (45728170, N'Corrie', N'Ohm', N'cohm2@themeforest.net', N'asd', N'user')
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol]) VALUES (46351505, N'Jasun', N'Birden', N'jbirden5@tmall.com', N'asd', NULL)
GO
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (1, N'Completada', 1, 10101010, CAST(N'2023-10-10T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (2, N'Pendiente', 2, 10101010, CAST(N'2023-10-11T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (3, N'Cancelada', 3, 10101010, CAST(N'2023-10-12T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (4, N'Completada', 4, 10101010, CAST(N'2023-10-13T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (5, N'Pendiente', 4, 10101010, CAST(N'2023-11-11T10:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (6, N'Pendiente', 1, 10101010, CAST(N'2023-11-09T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (7, N'Pendiente', 1, 10101010, CAST(N'2023-11-11T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (8, N'Pendiente', 7, 10101010, CAST(N'2023-11-12T12:00:00.000' AS DateTime), CAST(N'12:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (9, N'Pendiente', 6, 10101010, CAST(N'2023-11-21T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (10, N'Pendiente', 8, 10101010, CAST(N'2023-11-17T08:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (11, N'Pendiente', 9, 10101010, CAST(N'2023-11-17T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (12, N'Pendiente', 5, 10101010, CAST(N'2023-11-14T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[cuotas] ON 

INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (1, 10101010, 2, 2023, CAST(5000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (2, 2277738, 5, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (3, 10101010, 4, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (5, 10101010, 6, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (6, 10101010, 12, 2022, CAST(1000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (7, 10101010, 11, 2022, CAST(900.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[cuotas] OFF
GO
