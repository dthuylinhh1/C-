CREATE TABLE [dbo].[pets] (
    [pet_id]      INT           IDENTITY(1,1) NOT NULL,
    [pet_name]    NVARCHAR (50) NOT NULL,
    [pet_price]   MONEY         NOT NULL,
    [pet_species] NVARCHAR (50) NOT NULL,
    [pet_breed]   NVARCHAR (50) NULL,
    [pet_age]     SMALLINT      NOT NULL,
    [pet_gender]  NCHAR (10)    NOT NULL,
    PRIMARY KEY  CLUSTERED ([pet_id] ASC)
);

