DROP TABLE [dbo].[MATCH];
DROP TABLE [dbo].[TOURNOI];
DROP TABLE [dbo].[STADE];
DROP TABLE [dbo].[UTILISATEUR];
DROP TABLE [dbo].[DRESSEUR];
DROP TABLE [dbo].[POKEMON];
DROP TABLE [dbo].[TYPE];


CREATE TABLE [dbo].[TYPE] (
    [IdType]   	  INT           NOT NULL,
    [NomType]	  VARCHAR (225) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdType] ASC)
);

CREATE TABLE [dbo].[POKEMON] (
    [IdPokemon]   INT           NOT NULL,
    [NomPokemon]  VARCHAR (225) NOT NULL,
    [IdType]      INT		DEFAULT ((0)) NOT NULL,
    [Vie]         INT           DEFAULT ((0)) NOT NULL,
    [Force]       INT           DEFAULT ((0)) NOT NULL,
    [Agilite]     INT           DEFAULT ((0)) NOT NULL,
    [ENDURANCE]   INT           DEFAULT ((0)) NOT NULL,
    [VITESSE]     INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPokemon] ASC),
    FOREIGN KEY ([IdType]) REFERENCES [dbo].[TYPE] ([IdType])
);
CREATE TABLE [dbo].[DRESSEUR] (
    [IdDresseur]  INT           NOT NULL,
    [NomDresseur] VARCHAR (225) NOT NULL,
    [Score]	  INT		DEFAULT ((0)) NOT NULL
    PRIMARY KEY CLUSTERED ([IdDresseur] ASC)
);

CREATE TABLE [dbo].[UTILISATEUR] (
    [IdUtilisateur]     INT           NOT NULL,
    [NomUtilisateur]    VARCHAR (225) NOT NULL,
    [PrenomUtilisateur] VARCHAR (225) NOT NULL,
    [LoginUtilisateur]  VARCHAR (225) NOT NULL,
    [Password]          VARCHAR (225) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUtilisateur] ASC)
);

CREATE TABLE [dbo].[STADE] (
    [IdStade]          INT           NOT NULL,
    [NomStade]         VARCHAR (225) NOT NULL,
    [NbPlaces]         INT           DEFAULT ((0)) NOT NULL,
    [Vie]              INT           DEFAULT ((0)) NOT NULL,
    [Force]            INT           DEFAULT ((0)) NOT NULL,
    [Agilite]          INT           DEFAULT ((0)) NOT NULL,
    [ENDURANCE]        INT           DEFAULT ((0)) NOT NULL,
    [VITESSE]          INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdStade] ASC)
);

CREATE TABLE [dbo].[TOURNOI] (
    [IdTournoi] 	INT           NOT NULL,
    [NomTournoi]  	VARCHAR (225) NOT NULL,
    [NbMatchs]  	INT	      DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdTournoi] ASC)
);

CREATE TABLE [dbo].[MATCH] (
    [IdMatch]		 INT	       NOT NULL,
    [IdPokemonVainqueur] INT           NOT NULL,
    [PhaseTournoi]       VARCHAR (225) NOT NULL,
    [IdPokemon1]         INT           NOT NULL,
    [IdPokemon2]         INT           NOT NULL,
    [IdStade]            INT           NOT NULL,
    [IdTournoi]		 INT	       NOT NULL,
    PRIMARY KEY CLUSTERED ([IdMatch] ASC),
    FOREIGN KEY ([IdPokemon1]) REFERENCES [dbo].[POKEMON] ([IdPokemon]),
    FOREIGN KEY ([IdPokemon2]) REFERENCES [dbo].[POKEMON] ([IdPokemon]),
    FOREIGN KEY ([IdStade]) REFERENCES [dbo].[STADE] ([IdStade]),
    FOREIGN KEY ([IdTournoi]) REFERENCES [dbo].[TOURNOI] ([IdTournoi])
);


