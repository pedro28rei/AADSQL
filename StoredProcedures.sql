CREATE PROCEDURE AdicionarClienteEContactos @Cnome nvarchar(255), @CNIF integer, @CDataNasc date,@CCDados varchar(255), @DescricaoTC varchar(255)
AS
Begin
	--Query Cliente

	insert into Cliente(Cnome,CNIF,CDataNasc) values(@Cnome,@CNIF,@CDataNasc)

	--Query Contactos
	DECLARE @ClientId INT;
	DECLARE @TipoContactoID INT;

	SET @ClientId = SCOPE_IDENTITY();

	SELECT @TipoContactoID = TipoContacto.TCID
	FROM TipoContacto
	WHERE TipoContacto.DescricaoTC = @DescricaoTC;

	IF @TipoContactoId IS NULL
	BEGIN
	   INSERT INTO TipoContacto (DescricaoTC)
	   VALUES (@DescricaoTC);
	   SET @TipoContactoId = SCOPE_IDENTITY();
	END;

	insert into ContactoCliente(CID,TCID,CCDados) values(@ClientId,@TipoContactoID,@DescricaoTC)
END;
