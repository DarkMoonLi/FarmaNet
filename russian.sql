USE master;
GO

-- ��������� �� � single-user mode
ALTER DATABASE farmanet
SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

-- ������ ��������� COLLATION
ALTER DATABASE farmanet
COLLATE Cyrillic_General_CI_AS ;
GO

-- ��������� �� ������� � multi-user mode
ALTER DATABASE farmanet
SET MULTI_USER WITH ROLLBACK IMMEDIATE;
GO  
 
--��������� ��������� COLLATION.
SELECT name, collation_name
FROM sys.databases
WHERE name = '���_����_������';
GO