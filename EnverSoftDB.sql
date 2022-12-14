USE [EnverSoftDB]
GO
/****** Object:  Table [dbo].[SupplierTable]    Script Date: 2022/12/01 14:44:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierTable](
	[Code] [smallint] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Telephone_No] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SupplierTable] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
