SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[Usuario](
	[Usuario] [nvarchar](20) NOT NULL,
	[Contraseņa] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


INSERT [dbo].[Usuario] ([Usuario], [Contraseņa]) VALUES (N'juan', N'pepito')



SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

SELECT * FROM Usuario


CREATE PROCEDURE [dbo].[NuevoUsuario]
	@usuario nvarchar(20),
	@contraseņa nvarchar(20)
AS
BEGIN
insert into Usuario(Usuario, Contraseņa) values (@usuario, @contraseņa)
END



CREATE PROCEDURE [dbo].[Validausuario]
	@usuario nvarchar(20),
	@contraseņa nvarchar(20)
AS
BEGIN
	select usuario 
	from usuario
	where Usuario=@usuario and Contraseņa=@contraseņa

END


ALTER DATABASE [AplicacionCapas] SET  READ_WRITE