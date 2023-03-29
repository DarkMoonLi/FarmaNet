USE master;
GO

-- Переводим БД в single-user mode
ALTER DATABASE farmanet
SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

-- Меняем кодировку COLLATION
ALTER DATABASE farmanet
COLLATE Cyrillic_General_CI_AS ;
GO

-- Переводим БД обратно в multi-user mode
ALTER DATABASE farmanet
SET MULTI_USER WITH ROLLBACK IMMEDIATE;
GO  
 
--Проверяем настройки COLLATION.
SELECT name, collation_name
FROM sys.databases
WHERE name = 'имя_базы_данных';
GO