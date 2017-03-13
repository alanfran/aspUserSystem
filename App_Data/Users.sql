CREATE TABLE Users
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(64) NOT NULL, 
    [Email] NVARCHAR(128) NOT NULL, 
    [Password] NVARCHAR(256) NOT NULL, 
    [Country] NVARCHAR(64) NULL
)
