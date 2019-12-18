CREATE TABLE [dbo].[products]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[name] [nvarchar] (max) NOT NULL,
[definition] [xml] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


