CREATE TABLE [dbo].[DeviceData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeviceId] [nvarchar](max) NOT NULL,
	[SendDateTime] [datetime] NOT NULL,
	[Temperature] [decimal](5, 1) NOT NULL,
	[Humidity] [decimal](5, 1) NOT NULL,
	[PM25] [decimal](5, 1) NOT NULL,
 CONSTRAINT [PK_DeviceData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

