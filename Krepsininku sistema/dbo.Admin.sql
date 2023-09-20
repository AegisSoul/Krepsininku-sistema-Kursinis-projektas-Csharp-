CREATE TABLE [dbo].[Admin] (
    [Username] VARCHAR(30) NOT NULL,
    [Password] VARCHAR(30) NOT NULL, 
    [ConfirmPassword] VARCHAR(30) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

