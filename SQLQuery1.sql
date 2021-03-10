USE [p2516172]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblstock_Management_SelectAll]

SELECT	@return_value as 'Return Value'

GO
