SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[Usuario](
	[Usuario] [nvarchar](20) NOT NULL,
	[Contrase�a] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


INSERT [dbo].[Usuario] ([Usuario], [Contrase�a]) VALUES (N'juan', N'pepito')



SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

SELECT * FROM Usuario


CREATE PROCEDURE [dbo].[NuevoUsuario]
	@usuario nvarchar(20),
	@contrase�a nvarchar(20)
AS
BEGIN
insert into Usuario(Usuario, Contrase�a) values (@usuario, @contrase�a)
END



CREATE PROCEDURE [dbo].[Validausuario]
	@usuario nvarchar(20),
	@contrase�a nvarchar(20)
AS
BEGIN
	select usuario 
	from usuario
	where Usuario=@usuario and Contrase�a=@contrase�a

END


ALTER DATABASE [AplicacionCapas] SET  READ_WRITE