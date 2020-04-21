IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

EXEC sp_rename N'[Topic].[answer1]', N'answer', N'COLUMN';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200409065357_newu1', N'2.2.6-servicing-10079');

GO

ALTER TABLE [Topic] ADD [Answer2] nvarchar(1000) NOT NULL DEFAULT N'';

GO

ALTER TABLE [Topic] ADD [Answer3] nvarchar(1000) NOT NULL DEFAULT N'';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200409065535_new2', N'2.2.6-servicing-10079');

GO

