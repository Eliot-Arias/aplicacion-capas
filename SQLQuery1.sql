USE [master]
GO
/****** Object:  Database [BDPERMISOS]    Script Date: 24/06/2020 10:35:14 ******/
CREATE DATABASE [BDPERMISOS]
GO
USE [BDPERMISOS]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[nom_user] [nchar](30) NOT NULL,
	[ape_user] [nchar](40) NOT NULL,
	[login_user] [nchar](12) NOT NULL,
	[passw_user] [varchar](max) NOT NULL,
	[fech_user] [datetime] NOT NULL,
	[fechup_user] [datetime] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_rol]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_rol](
	[id_rol] [int] NOT NULL,
	[id_user] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[nom_Rol] [nchar](20) NOT NULL,
	[permisos_Rol] [nvarchar](max) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[PERMISOS]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PERMISOS]
AS
SELECT        dbo.usuarios.id_user
FROM            dbo.usuarios_rol INNER JOIN
                         dbo.usuarios ON dbo.usuarios_rol.id_user = dbo.usuarios.id_user INNER JOIN
                         dbo.roles ON dbo.usuarios_rol.id_rol = dbo.roles.id_Rol
GO
SET IDENTITY_INSERT [dbo].[roles] ON 
GO
INSERT [dbo].[roles] ([id_Rol], [nom_Rol], [permisos_Rol]) VALUES (1, N'Administrador       ', N'�e����{���{�������{���{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ч�������Ϙ��Ȏ���k�{����ue�Ǯ�ȁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ê������ӽ�ɠ��ʛ��Ɓwg����w�k��Ѵ�{g�����{���θ�o�t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g��Ȯ��η��Ů����ɢӰ�{g����v�����ũ��tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�����ƙ�ľ���Ȼ�����ɷ�v����Ƹg}w����ì�y����tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�Ѵ�ͧ�������Ϙ��Ȏ���k�{����ue�����̴�{g�����{���θ �t��{�m�¿�����v����Ƹg}w�������{g�����{���θ�o�t�ɻ����u��t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g�ö���η��Ů����ɢӰ�{g����v����̻����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���ȧ�������Ϙ��Ȏ���k�{����ue�����Ľg�u���Ǯv�ӽ���q�w����ί�{���w����ί�{����t��{�m�������{�m����e�t�E�ô�{g�����{���θ�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ����Ȫ���k�������g}��uv��m{�������wg����w�k��ȸ�Ǵ�e�t���԰g�Ƿ��Ϧ�{��g�u��ɦ��Ų���Ò��ǒȾ�mq{����t�v�ν���gow�����m�ź��~�v�ԭ�ȷ�e���v�ԭ�ȷ�e����{��g�u��ē���Ƚg�u��·k�{�<����e�t���԰g�Ƿ���u�{����©�w�������{�g������Ӭ�{g����v�����Ǧ�w~k�����{���ʷƀԁ�������t����m��ueö���ȸ�{g����v����������k�{���θg}�ľ�ּwg��g}w���ҳ��Ŧ�����Ԕ���gow������g�µ���k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���͸��ľ���Ȼ�����ɷ�v����Ƹg}w�����mq{���ʷk�����ְqe��k�{���͠���tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ƺ�ǻ�ǭκ��Ƿ�ş��Ψ���uqe����{�m��Ȧ����v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ÿ�������Ѵ������Ʈ�{�m����e�t���ľg�u���Ǯv�ӽ��Тow��v����ǹ������{�m����e�t���Ŵ��Ŧ��E�v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k��֢�Ƿ�������ӽ�ɠ��ʛ��Ɓwg����w�k�����y���ɳ��{�m�����w������q�u������ȁ���g��t�v�������������Ѵ������Ʈ�{�m����e�t���¬��uqe���ɾ����Ȫ���k�������g}��uv��m{��������Ȯ�ŧ�������Ϙ��Ȏ���k�{����ue�����ºe��������{�m�����w������q�u������ȁ���g��t�v�ȷ��·����Ⱥ˟�ȿ��ǻ������͸�e�t����m{�������y����ʹ�ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k��ξ����������Ѵ������Ʈ�{�m����e�t���Ѭ�y����tuv�����u��Ǯх�m�ε����k���wg��g}w��ƺͲ�����Ȧ��Ų���Ò��ǒȾ�mq{����t�v�Ѳ�Ǽ���r���ͺ�{g�����{���θ �t��{�m������Ŗ���mq{����t�v�Ĺ�����w~k�����{���ʷƱ����{�����uv����{�����uv�����u������')
GO
INSERT [dbo].[roles] ([id_Rol], [nom_Rol], [permisos_Rol]) VALUES (2, N'Supervisor          ', N'�e����{���{�������{���{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ч�������Ϙ��Ȏ���k�{����ue�Ǯ�ȁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ê������ӽ�ɠ��ʛ��Ɓwg����w�k��Ѵ�{g�����{���θ�o�t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g��Ȯ��η��Ů����ɢӰ�{g����v�����ũ��tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�����ƙ�ľ���Ȼ�����ɷ�v����Ƹg}w����ì�y����tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�Ѵ�ͧ�������Ϙ��Ȏ���k�{����ue�����̴�{g�����{���θ �t��{�m�¿�����v����Ƹg}w�������{g�����{���θ�o�t�ɻ����u��t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g�ö���η��Ů����ɢӰ�{g����v����̻����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���ȧ�������Ϙ��Ȏ���k�{����ue�����Ľg�u���Ǯv�ӽ���q�w����ί�{���w����ί�{����t��{�m�������{�m����e�t�E�ô�{g�����{���θ�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ����Ȫ���k�������g}��uv��m{�������wg����w�k��ȸ�Ǵ�e�t���԰g�Ƿ��Ϧ�{��g�u��ɦ��Ų���Ò��ǒȾ�mq{����t�v�ν���gow�����m�ź��~�v�ԭ�ȷ�e���v�ԭ�ȷ�e����{��g�u��ē���Ƚg�u��·k�{�<����e�t���԰g�Ƿ���u�{����©�w�������{�g������Ӭ�{g����v�����Ǧ�w~k�����{���ʷƀԁ�������t����m��ueö���ȸ�{g����v����������k�{���θg}�ľ�ּwg��g}w���ҳ��Ŧ�����Ԕ���gow������g�µ���k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���͸��ľ���Ȼ�����ɷ�v����Ƹg}w�����mq{���ʷk�����ְqe��k�{���͠���tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ƺ�ǻ�ǭκ��Ƿ�ş��Ψ���uqe����{�m��Ȧ����v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ÿ�������Ѵ������Ʈ�{�m����e�t���ľg�u���Ǯv�ӽ��Тow��v����ǹ������{�m����e�t���Ŵ��Ŧ��E�v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k��֢�Ƿ�������ӽ�ɠ��ʛ��Ɓwg����w�k�����y���ɳ��{�m�����w������q�u������ȁ���g��t�v�������������Ѵ������Ʈ�{�m����e�t���¬��uqe���ɾ����Ȫ���k�������g}��uv��m{��������Ȯ�ŧ�������Ϙ��Ȏ���k�{����ue�����ºe��������{�m�����w������q�u������ȁ���g��t�v�ȷ��·����Ⱥ˟�ȿ��ǻ������͸�e�t����m{�������y����ʹ�ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k��ξ����������Ѵ������Ʈ�{�m����e�t���Ѭ�y����tuv�����u��Ǯх�m�ε����k���wg��g}w��ƺͲ�����Ȧ��Ų���Ò��ǒȾ�mq{����t�v�Ѳ�Ǽ���r���ͺ�{g�����{���θ �t��{�m������Ŗ���mq{����t�v�Ĺ�����w~k�����{���ʷƱ����{�����uv����{�����uv�����u������')
GO
INSERT [dbo].[roles] ([id_Rol], [nom_Rol], [permisos_Rol]) VALUES (3, N'Cajero              ', N'�e����{���{�������{���{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ч�������Ϙ��Ȏ���k�{����ue�Ǯ�ȁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ê������ӽ�ɠ��ʛ��Ɓwg����w�k��Ѵ�{g�����{���θ�o�t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g��Ȯ��η��Ů����ɢӰ�{g����v�����ũ��tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�����ƙ�ľ���Ȼ�����ɷ�v����Ƹg}w����ì�y����tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�Ѵ�ͧ�������Ϙ��Ȏ���k�{����ue�����̴�{g�����{���θ �t��{�m�¿�����v����Ƹg}w�������{g�����{���θ�o�t�ɻ����u��t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g�ö���η��Ů����ɢӰ�{g����v����̻����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���ȧ�������Ϙ��Ȏ���k�{����ue�����Ľg�u���Ǯv�ӽ���q�w����ί�{���w����ί�{����t��{�m�������{�m����e�t�E�ô�{g�����{���θ�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ����Ȫ���k�������g}��uv��m{�������wg����w�k��ȸ�Ǵ�e�t���԰g�Ƿ��Ϧ�{��g�u��ɦ��Ų���Ò��ǒȾ�mq{����t�v�ν���gow�����m�ź��~�v�ԭ�ȷ�e���v�ԭ�ȷ�e����{��g�u��ē���Ƚg�u��·k�{�<����e�t���԰g�Ƿ���u�{����©�w�������{�g������Ӭ�{g����v�����Ǧ�w~k�����{���ʷƀԁ�������t����m��ueö���ȸ�{g����v����������k�{���θg}�ľ�ּwg��g}w���ҳ��Ŧ�����Ԕ���gow������g�µ���k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���͸��ľ���Ȼ�����ɷ�v����Ƹg}w�����mq{���ʷk�����ְqe��k�{���͠���tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ƺ�ǻ�ǭκ��Ƿ�ş��Ψ���uqe����{�m��Ȧ����v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ÿ�������Ѵ������Ʈ�{�m����e�t���ľg�u���Ǯv�ӽ��Тow��v����ǹ������{�m����e�t���Ŵ��Ŧ��E�v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k��֢�Ƿ�������ӽ�ɠ��ʛ��Ɓwg����w�k�����y���ɳ��{�m�����w������q�u������ȁ���g��t�v�������������Ѵ������Ʈ�{�m����e�t���¬��uqe���ɾ����Ȫ���k�������g}��uv��m{��������Ȯ�ŧ�������Ϙ��Ȏ���k�{����ue�����ºe��������{�m�����w������q�u������ȁ���g��t�v�ȷ��·����Ⱥ˟�ȿ��ǻ������͸�e�t����m{�������y����ʹ�ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k��ξ����������Ѵ������Ʈ�{�m����e�t���Ѭ�y����tuv�����u��Ǯх�m�ε����k���wg��g}w��ƺͲ�����Ȧ��Ų���Ò��ǒȾ�mq{����t�v�Ѳ�Ǽ���r���ͺ�{g�����{���θ �t��{�m������Ŗ���mq{����t�v�Ĺ�����w~k�����{���ʷƱ����{�����uv����{�����uv�����u������')
GO
INSERT [dbo].[roles] ([id_Rol], [nom_Rol], [permisos_Rol]) VALUES (4, N'Vendedor            ', N'�e����{���{�������{���{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ч�������Ϙ��Ȏ���k�{����ue�Ǯ�ȁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ê������ӽ�ɠ��ʛ��Ɓwg����w�k��Ѵ�{g�����{���θ�o�t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g��Ȯ��η��Ů����ɢӰ�{g����v�����ũ��tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�����ƙ�ľ���Ȼ�����ɷ�v����Ƹg}w����ì�y����tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�Ѵ�ͧ�������Ϙ��Ȏ���k�{����ue�����̴�{g�����{���θ �t��{�m�¿�����v����Ƹg}w�������{g�����{���θ�o�t�ɻ����u��t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g�ö���η��Ů����ɢӰ�{g����v����̻����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���ȧ�������Ϙ��Ȏ���k�{����ue�����Ľg�u���Ǯv�ӽ���q�w����ί�{���w����ί�{����t��{�m�������{�m����e�t�E�ô�{g�����{���θ�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ����Ȫ���k�������g}��uv��m{�������wg����w�k��ȸ�Ǵ�e�t���԰g�Ƿ��Ϧ�{��g�u��ɦ��Ų���Ò��ǒȾ�mq{����t�v�ν���gow�����m�ź��~�v�ԭ�ȷ�e���v�ԭ�ȷ�e����{��g�u��ē���Ƚg�u��·k�{�<����e�t���԰g�Ƿ���u�{����©�w�������{�g������Ӭ�{g����v�����Ǧ�w~k�����{���ʷƀԁ�������t����m��ueö���ȸ�{g����v����������k�{���θg}�ľ�ּwg��g}w���ҳ��Ŧ�����Ԕ���gow������g�µ���k�{���θg}�ľ�֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ��Ǧ�w~k��̰g�u���ƪ�{�m�����w������q�u������ȁ���g��t�v�ú�ż��w~k��̰g�u�����º�mq{���ʷk�����ְqe��k�{���͸��ľ���Ȼ�����ɷ�v����Ƹg}w�����mq{���ʷk�����ְqe��k�{���͠���tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ƺ�ǻ�ǭκ��Ƿ�ş��Ψ���uqe����{�m��Ȧ����v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ÿ�������Ѵ������Ʈ�{�m����e�t���ľg�u���Ǯv�ӽ��Тow��v����ǹ������{�m����e�t���Ŵ��Ŧ��E�v�����Ȫe�ƻɾ�w�{�������{���{�������{����u��w�k��֢�Ƿ�������ӽ�ɠ��ʛ��Ɓwg����w�k�����y���ɳ��{�m�����w������q�u������ȁ���g��t�v�������������Ѵ������Ʈ�{�m����e�t���¬��uqe���ɾ����Ȫ���k�������g}��uv��m{��������Ȯ�ŧ�������Ϙ��Ȏ���k�{����ue�����ºe��������{�m�����w������q�u������ȁ���g��t�v�ȷ��·����Ⱥ˟�ȿ��ǻ������͸�e�t����m{�������y����ʹ�ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k��ξ����������Ѵ������Ʈ�{�m����e�t���Ѭ�y����tuv�����u��Ǯх�m�ε����k���wg��g}w��ƺͲ�����Ȧ��Ų���Ò��ǒȾ�mq{����t�v�Ѳ�Ǽ���r���ͺ�{g�����{���θ �t��{�m������Ŗ���mq{����t�v�Ĺ�����w~k�����{���ʷƱ����{�����uv����{�����uv�����u������')
GO
INSERT [dbo].[roles] ([id_Rol], [nom_Rol], [permisos_Rol]) VALUES (6, N'Despachador         ', N'�e����{���{�������{���{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���԰�g�ʴ�ý�m��qe��k�{ͯ������tuv����{�g��������g�u���Ǯv�ӽ��Тow��v����Ч�������Ϙ��Ȏ���k�{����ue�Ǯ�ȁwg�����t���԰�g�ʴ�ý�m��g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue�C����mq{���ʷk�������e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�ӽ���q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ����Ȫ��~k����g�ê������ӽ�ɠ��ʛ��Ɓwg����w�k��Ѵ�{g�����{���θ�o�t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ����Ȫ���k�������g}��uv��m{������Ⱥ�mq{����t�v�ô���gow�����m�ź��~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{���ʷƱ����{�g��Ȯ��η��Ů����ɢӰ�{g����v�����ũ��tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�����ƙ�ľ���Ȼ�����ɷ�v����Ƹg}w����ì�y����tuv�����u��Ǯх�m�ε����k���m�ε����k���wg��g}w��Úͬ���gow������g�D����k�{���θg}�ľ�֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��ʹ�e�t����m{���ɳ�v�����Ȫe�ƻɾ�w�{�������{����u��w�k½ΐ����e�t����m{���»��ˁwg�����t���԰¶g��t�v�Ѵ�ͧ�������Ϙ��Ȏ���k�{����ue�����̴�{g�����{���θ �t��{�m�¿�����v����Ƹg}w�������{g�����{���θ�o�t�ɻ����u��t�ɻ����u��t�ɻ����u��~k����gǷ��ó��ˁwg����w�k�J����uqe���ɾ��������~�v�ԭ�ȷ�e����{��g�u��ė�����g�u��·k�{���ʹ�e�t���԰g����ȷƀԁ�������t����m��ueö���ȸ�{g����v����������k�{���θg}���Ǿܨq{��e�t�½Ο�ȿ��ǻ������͸�e�t����m{�������ˁwg�����t���˾���e�ǫ��úg���e�ǫ��úg���ow��v����Ȕ�����v����Ƹg}w�:��Ƚg�u���Ǯv�Ŭ�̸�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ��������~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{����ŮѶ�m��ue���íκ��Ƿ�ş��Ψ���uqe����{�m�������k�{���θg}���Ǿ�w�{�������{���{�������{����u��w�k½Ό�����w~k��̰g�u�4����{�m�����w����Ұ�g�ʴ�ý�m��qe��k�{ͯ�������k�{����ue���Ⱥ�mq{���ʷk�������q�w����ί�{����t��{�m������v����Ƹg}w����ȹ��uqe���ɾ�������үuv��m{��������ӽ�ɠ��ʛ��Ɓwg����w�k��ѿ��uqe���ɾ��������~�v�ԭ�ȷ�e���v�ԭ�ȷ�e����{��g�u��ē���Ƚg�u��·k�{�<����e�t���԰g����ȷƀԁ�������t����m��ueö���ȿ��uqe����{�m������tuv�����u�����֋�g�ȧ�Ķ�v���q{��e�t��Ȥ��Ƽgow������g��������{�m�����w����Ұ¶g��t�v�λ��´��ƻ�ɬ��Μ���tuv����{�g��²�ˁwg�����t���˾���e�ǫ��úg���e�ǫ��úg���ow��v����Ȕ�����v����Ƹg}w�:��Ƚg�u���Ǯv�Ŭ�̸�o�t�ɻ����u��~k����gǷ������ˁwg����w�k��ȿ��uqe���ɾ��������~�v�ԭ�ȷ�e����{��g�u��ė����mq{����t�v�˴�����w~k�����{����ŮѶ�m��ue���Ⱦ���Ŧ�����Ԕ���gow������g�����tuv�����u�����ּwg��g}w���ͬ���uqe����{�m������tuv�����u�����֋�g�ȧ�Ķ�v���g�ȧ�Ķ�v���g�ȧ�Ķ�v���q{��e�t��Ƞ�����e�t����m{�6����v�����Ȫe�������q�u������ȁ���g��t�v�ú������tuv����{�g�����ˁwg�����t���˾���e�ǫ��úg���ow��v����Ș��»k�{����ue�����ͬ�{g�����{����ƪ��~k����g�ƺ�ǻ�ǭκ��Ƿ�ş��Ψ���uqe����{�m��Ȧ����v�����Ȫe�������q�u������ȁ���u������ȁ���g��t�v�ú�Ǵ���tuv����{�g�F���ˁwg�����t���˾���e�ǫ��úg���ow��v����Ș��ɳ�v����Ƹg}w������g�u���Ǯv�Ŭ�̸�o�t�ɻ����u��~k����gǷ������{�m����e�t���̴���gow�����m�����Ϧ�{��g�u�������η��Ů����ɢӰ�{g����v����Ÿ�e�t���԰g����ȷƱ����{�g����������uqe����{�m������ǻ���>�{g�����{����ƪ���k�������g}��k�������g}��uv��m{��������֟�ȿ��ǻ������͸�e�t����m{���˳i��Ϳ�Ǵgow�����m������u�{����©�w�������{�g��Ŭ��ğ�ȿ��ǻ������͸�e�t����m{�������{�m�����w����Ұ�g�ʴ�ý�m��qe��k�{�������ɻ��ų��Ŧ�����Ԕ���gow������g�¸����t�Ľ�¶��w~k�����{����Ůх�m�ε����k���wg��g}w��������ʹ�ɳ���η��Ů����ɢӰ�{g����v����̴���r����Ŵ�Ǧ�w~k�����{����Ůх�m�ε����k���wg��g}w����Č�ŧ�������Ϙ��Ȏ���k�{����ue���ƺ�k�ȷ�e�t���԰g����ȷƀԁ�������t����m��ue�Ļ��ư��³������ӽ�ɠ��ʛ��Ɓwg����w�k��Ƭ��ͦ�u����ξg�u���Ǯv�Ŭ�̸ �t��{�m������Ŗ���mq{����t�v�Ĺ�����w~k�����{����ŮѶ�m��u�ʾ��{����u�ʾ��{���θg}���Ǿ�')
GO
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 
GO
INSERT [dbo].[usuarios] ([id_user], [nom_user], [ape_user], [login_user], [passw_user], [fech_user], [fechup_user]) VALUES (1, N'USUARIO 3                     ', N'USER 3                                  ', N'usuario3    ', N'e10adc3949ba59abbe56e057f20f883e', CAST(N'2020-03-22T09:37:24.420' AS DateTime), CAST(N'2020-05-31T19:07:34.127' AS DateTime))
GO
INSERT [dbo].[usuarios] ([id_user], [nom_user], [ape_user], [login_user], [passw_user], [fech_user], [fechup_user]) VALUES (10, N'USUARIO 2                     ', N'USER 2                                  ', N'usuario2    ', N'e10adc3949ba59abbe56e057f20f883e', CAST(N'2020-04-05T19:51:31.147' AS DateTime), CAST(N'2020-05-31T19:07:14.377' AS DateTime))
GO
INSERT [dbo].[usuarios] ([id_user], [nom_user], [ape_user], [login_user], [passw_user], [fech_user], [fechup_user]) VALUES (11, N'USUARIO 1                     ', N'USER 1                                  ', N'usuario1    ', N'25f9e794323b453885f5181f1b624d0b', CAST(N'2020-04-05T19:53:53.270' AS DateTime), CAST(N'2020-05-31T19:06:56.587' AS DateTime))
GO
INSERT [dbo].[usuarios] ([id_user], [nom_user], [ape_user], [login_user], [passw_user], [fech_user], [fechup_user]) VALUES (14, N'USUARIO 4                     ', N'USER 4                                  ', N'usuario4    ', N'e10adc3949ba59abbe56e057f20f883e', CAST(N'2020-04-05T20:01:37.127' AS DateTime), CAST(N'2020-05-31T19:07:49.577' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (1, 10)
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (1, 1)
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (3, 11)
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (1, 12)
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (1, 13)
GO
INSERT [dbo].[usuarios_rol] ([id_rol], [id_user]) VALUES (2, 14)
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_INSERT]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_USU_INSERT]
@LOG NCHAR(12),
@NOM NCHAR(30),
@APE NCHAR(40),
@PASS VARCHAR(MAX),
@IDROL INT,
@RESULT INT OUTPUT -- 0=YA EXISTE USUARIO  1=SE INSERTO   2=ERROR SQL
AS
BEGIN TRAN
	DECLARE @COUNTUSU INT, @IDUSER INT
		SET @COUNTUSU = (SELECT COUNT(login_user) FROM [dbo].usuarios WHERE login_user=@LOG)
		IF @COUNTUSU = 0
		BEGIN
			INSERT INTO usuarios (login_user
				   ,nom_user
				   ,ape_user
				   ,passw_user
				   ,fech_user)
			VALUES ( @LOG, @NOM,@APE, @PASS,GETDATE())
			-- EN CASO DE ERROR 
			 IF @@ERROR <> 0 
			  BEGIN
				ROLLBACK TRAN
				RETURN 2
			  END
			SET @IDUSER = (SELECT id_user FROM [dbo].usuarios WHERE login_user=@LOG)
			INSERT INTO [dbo].usuarios_rol(id_user,id_rol) VALUES (@IDUSER, @IDROL)
			IF @@ERROR <> 0 
			  BEGIN
				ROLLBACK TRAN
				RETURN 2
			  END
			SET @RESULT = 1
		END
		ELSE
		BEGIN
			SET @RESULT = 0
		END
COMMIT TRAN

GO
/****** Object:  StoredProcedure [dbo].[SP_USU_INSERT_ROL]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_USU_INSERT_ROL]
@NOMROL AS NCHAR(20),
@RESULT INT OUTPUT
AS
BEGIN TRAN
	DECLARE @COUNT INT
	SET @COUNT = (SELECT COUNT(nom_Rol) FROM roles WHERE nom_Rol=@NOMROL)
	IF @COUNT = 0
	BEGIN
		INSERT INTO [dbo].[roles]
				   ([nom_Rol]
				   ,[permisos_Rol])
			 VALUES
				   (@NOMROL
				   ,'')
		-- EN CASO DE ERROR 
			 IF @@ERROR <> 0 
			  BEGIN
				ROLLBACK TRAN
				RETURN 2
			  END
		SET @RESULT = 1

	END
	ELSE
	BEGIN
		SET @RESULT = 0
	END
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_LIST]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USU_LIST] 

AS
	SELECT        dbo.usuarios.id_user,RTRIM(dbo.usuarios.ape_user) as ape_user, RTRIM(dbo.usuarios.nom_user) as nom_user, RTRIM(dbo.usuarios.login_user) as login_user, dbo.usuarios.fech_user, dbo.usuarios.fechup_user, RTRIM(dbo.roles.nom_Rol) as nom_Rol
	FROM            dbo.usuarios INNER JOIN
								dbo.usuarios_rol ON dbo.usuarios.id_user = dbo.usuarios_rol.id_user INNER JOIN
								dbo.roles ON dbo.usuarios_rol.id_rol = dbo.roles.id_Rol
	  ORDER BY dbo.usuarios.ape_user
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_LISTROL]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USU_LISTROL] 

AS
	SELECT        id_Rol, RTRIM(nom_Rol) as nom_Rol
	FROM            dbo.roles
	  ORDER BY nom_Rol

GO
/****** Object:  StoredProcedure [dbo].[SP_USU_LOGIN]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USU_LOGIN]
@LOGIN Nchar(15),
@PASS NVARCHAR(MAX),
@RESULT varchar(20) OUTPUT
AS
	DECLARE @IDUSUS INT,@IDUSU VARCHAR(10)
	SET @IDUSUS = (SELECT COUNT([id_user]) FROM [usuarios] WHERE [login_user] = @LOGIN AND [passw_user] =@PASS)
	IF (@IDUSUS = 0)
		BEGIN
			SET @RESULT = '0'
		END
	ELSE
		BEGIN
			SET @RESULT = '1'
		END
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_UPDATE]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------------------------------------
create PROCEDURE [dbo].[SP_USU_UPDATE]
@IDUSU INT,
@NOM NCHAR(30),
@APE NCHAR(40),
@PASS VARCHAR(MAX)=NULL,
@TIPOUSU INT,
@RESULT INT OUTPUT -- 0=YA EXISTE USUARIO  1=SE INSERTO   2=ERROR SQL
AS
BEGIN TRAN
IF @PASS = ''
BEGIN
	UPDATE [dbo].[usuarios]
	   SET 
		  [nom_user] = @NOM
		  ,ape_user = @APE
		  ,[fechup_user] = GETDATE()
	 WHERE id_user = @IDUSU
END
ELSE
BEGIN
	UPDATE [dbo].[usuarios]
	   SET 
		  [nom_user] = @nom
		  ,ape_user = @APE
		  ,[fechup_user] = GETDATE()
		  ,passw_user = @PASS
	 WHERE id_user = @IDUSU
END
	IF @@ERROR <> 0 
		BEGIN
		ROLLBACK TRAN
		SET @RESULT = 2
		END
	ELSE
		BEGIN
		SET @RESULT = 1
		END
	----------------------
	UPDATE dbo.usuarios_rol
		SET
			id_rol=@TIPOUSU
		WHERE id_user=@IDUSU	
	----------------------
	IF @@ERROR <> 0 
		BEGIN
		ROLLBACK TRAN
		SET @RESULT = 2
		END
	ELSE
		BEGIN
		SET @RESULT = 1
		END

	-----------------------
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_UPPERMISO]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[SP_USU_UPPERMISO]
@IDROL INT,
@PERMISOS NVARCHAR(MAX),
@RESULT INT OUTPUT -- 0=YA EXISTE USUARIO  1=SE INSERTO   2=ERROR SQL
AS
BEGIN TRAN

	UPDATE [dbo].[roles]
		SET [permisos_Rol] = @PERMISOS
		WHERE id_Rol=@IDROL

	IF @@ERROR <> 0 
		BEGIN
		ROLLBACK TRAN
		SET @RESULT = 2	
		END
	ELSE
		BEGIN
		SET @RESULT = 1
		END
COMMIT TRAN
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_VER]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USU_VER] 
@LOGIN NCHAR(12)
AS
	SELECT        dbo.usuarios.id_user, RTRIM(dbo.usuarios.nom_user) + ' ' + RTRIM(dbo.usuarios.ape_user) AS NomUsu, RTRIM(dbo.roles.nom_Rol) AS Expr1, dbo.roles.permisos_Rol
	FROM            dbo.usuarios_rol INNER JOIN
                         dbo.usuarios ON dbo.usuarios_rol.id_user = dbo.usuarios.id_user INNER JOIN
                         dbo.roles ON dbo.usuarios_rol.id_rol = dbo.roles.id_Rol
	WHERE        (dbo.usuarios.login_user = @LOGIN)
GO
/****** Object:  StoredProcedure [dbo].[SP_USU_VERPERM]    Script Date: 24/06/2020 10:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USU_VERPERM]
@IDROL int
AS
	SELECT [permisos_Rol] FROM [dbo].[roles] WHERE id_Rol=@IDROL

GO
