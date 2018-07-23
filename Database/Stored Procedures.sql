USE [MURK]
GO
/****** Object:  StoredProcedure [dbo].[ALTA_CATEGORIA]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ALTA_CATEGORIA]
@cat varchar(50)
as insert into Categoria
values(@cat,'1')
GO
/****** Object:  StoredProcedure [dbo].[ALTA_COMPAÑIA]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_COMPAÑIA]
@NOM VARCHAR(50),
@DIRECCION VARCHAR(50),@MUN VARCHAR(50),
@EST VARCHAR (50),
@CP VARCHAR(10), 
@PAIS VARCHAR(50),
@RFC VARCHAR(50)
AS INSERT INTO COMPAÑIA
VALUES(@NOM,@DIRECCION,@MUN,@EST,@CP,@PAIS,@RFC,'1')
GO
/****** Object:  StoredProcedure [dbo].[ALTA_GENERO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_GENERO]
@GEN VARCHAR(50)
AS INSERT INTO Genero
VALUES(@GEN,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_LIBRO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ALTA_LIBRO]
@ISBN VARCHAR(50),
@TIT VARCHAR(50),
@EDIT VARCHAR(50),
@AUTOR VARCHAR(50),
@ID_GEN INT,
@NO_P INT,
@EDICION INT, 
@IDIOMA  VARCHAR(50),
@PRECIO MONEY,
@STOCK INT
AS INSERT INTO Libro
VALUES(@ISBN,@TIT,@EDIT,@AUTOR,@ID_GEN,@NO_P,@EDICION,@IDIOMA,@PRECIO,@STOCK,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_PERSONA]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_PERSONA]
@NOM VARCHAR(50),@AP VARCHAR(50),@AM VARCHAR(50),@FN DATE,@DIR VARCHAR(50),@COL VARCHAR(50),
@MUN VARCHAR(50),@EST VARCHAR(50),@EMAIL VARCHAR(50),@TEL BIGINT
AS INSERT INTO Personas VALUES(@NOM,@AP,@AM,@FN,@DIR,@COL,@MUN,@EST,@EMAIL,@TEL,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_PROVEEDOR]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_PROVEEDOR]
@NOM VARCHAR(50),@AP VARCHAR(50),@EMAIL VARCHAR(50),@TEL BIGINT,@COMP int
AS INSERT INTO Provedor VALUES(@NOM,@AP,@EMAIL,@TEL,@COMP,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_RECARGO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_RECARGO]
@ID_PRESTAMO INT,
@DIAS INT,
@RECARGO MONEY,
@ESTADO VARCHAR(50)
AS INSERT INTO Recargos
VALUES(@ID_PRESTAMO,@DIAS,@RECARGO,@ESTADO,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_RFID_LIBRO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_RFID_LIBRO]
@RFID  VARCHAR(50),
@ID_LIBRO INT
AS INSERT INTO Libro_rfid 
VALUES(@RFID,@ID_LIBRO,'1','1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_TIPO_USUARIO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_TIPO_USUARIO]
@TIPO VARCHAR(50)
AS INSERT INTO Tipo_usuario
VALUES (@TIPO,'1')


GO
/****** Object:  StoredProcedure [dbo].[ALTA_USUARIO]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ALTA_USUARIO]
@RFID VARCHAR(50),
@IDP INT,
@IDT INT
AS INSERT INTO Usuarios 
VALUES(@RFID,@IDP,@IDT,'1')


GO
/****** Object:  StoredProcedure [dbo].[BuscarLogin]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarLogin]
@rfid varchar(50)
as
SELECT Usuarios.Id_tipo_usuario, Usuarios.Status, Personas.Nombre FROM Usuarios, Tipo_usuario, Personas WHERE Personas.Id = Usuarios.Id_persona AND Usuarios.Id_tipo_usuario = Tipo_usuario.Id AND Usuarios.Rfid = @rfid

GO
/****** Object:  StoredProcedure [dbo].[LISTAR_COMPAÑIAS]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_COMPAÑIAS]
AS
SELECT ID, NOMBRE FROM Compañia

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 23/07/2018 01:59:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Login]
@RFID varchar(50)
as
select * from Usuarios where Usuarios.Rfid like @RFID
GO
