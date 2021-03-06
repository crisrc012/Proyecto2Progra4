--Select
    create procedure [dbo].[sp_select_TB_Servicio]
    as
    select [IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio] ,[FechaRegistro] from [dbo].[TB_Servicio]
    go
--Insert
    create procedure [dbo].[sp_insert_TB_Servicio]
    (
        @IdCliente smallint ,@IdEstado char ,@IdTipoServicio tinyint ,@FechaRegistro datetime
    )
    as
    IF NOT EXISTS (SELECT [IdCliente] ,[IdEstado] ,[IdTipoServicio] ,[FechaRegistro]
                    FROM [dbo].[TB_Servicio]
                    WHERE [IdCliente] = @IdCliente
AND [IdTipoServicio] = @IdTipoServicio)
    BEGIN
        INSERT INTO [dbo].[TB_Servicio]
                ([IdCliente] ,[IdEstado] ,[IdTipoServicio] ,[FechaRegistro])
        VALUES (@IdCliente ,@IdEstado ,@IdTipoServicio ,@FechaRegistro)
    END
    -- Devuelve la ultima llave generada
    SELECT MAX ([IdServicio])
    FROM [dbo].[TB_Servicio]
    go
--Update
    create procedure [dbo].[sp_update_TB_Servicio]
    (
        @IdServicio smallint ,@IdCliente smallint ,@IdEstado char ,@IdTipoServicio tinyint ,@FechaRegistro datetime
    )
    as
    update [dbo].[TB_Servicio]
    set [IdCliente] = @IdCliente,[IdEstado] = @IdEstado,[IdTipoServicio] = @IdTipoServicio,[FechaRegistro] = @FechaRegistro
    where [IdServicio] = @IdServicio
    go
--Delete
    create procedure [dbo].[sp_delete_TB_Servicio]
    (
        @IdServicio smallint
    )
    as
    delete from [dbo].[TB_Servicio]
    where [IdServicio] = @IdServicio
    go
-- Filtrar
    create procedure [dbo].[sp_search_TB_Servicio]
    (
        @IdServicio smallint ,@IdCliente smallint ,@IdEstado char ,@IdTipoServicio tinyint ,@FechaRegistro datetime
    )
    as
    SELECT [IdServicio] ,[IdCliente] ,[IdEstado] ,[IdTipoServicio] ,[FechaRegistro]
    FROM [dbo].[TB_Servicio]
    WHERE [IdServicio] LIKE '%' + ISNULL(@IdServicio, [IdServicio]) + '%'
AND [IdCliente] LIKE '%' + ISNULL(@IdCliente, [IdCliente]) + '%'
AND [IdEstado] LIKE '%' + ISNULL(@IdEstado, [IdEstado]) + '%'
AND [IdTipoServicio] LIKE '%' + ISNULL(@IdTipoServicio, [IdTipoServicio]) + '%'
AND [FechaRegistro] LIKE '%' + ISNULL(@FechaRegistro, [FechaRegistro]) + '%'
    go
