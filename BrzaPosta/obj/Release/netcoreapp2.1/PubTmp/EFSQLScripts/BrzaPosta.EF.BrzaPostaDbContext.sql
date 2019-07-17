IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [aktivacije] (
        [AktivacijaId] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        CONSTRAINT [PK_aktivacije] PRIMARY KEY ([AktivacijaId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [regioni] (
        [RegionId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        CONSTRAINT [PK_regioni] PRIMARY KEY ([RegionId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [vrsteStavki] (
        [VrstaId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        CONSTRAINT [PK_vrsteStavki] PRIMARY KEY ([VrstaId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [zaposlenici] (
        [ZaposlenikId] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Telefon] nvarchar(max) NULL,
        [Username] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [Aktivan] bit NOT NULL,
        [Tip] int NOT NULL,
        CONSTRAINT [PK_zaposlenici] PRIMARY KEY ([ZaposlenikId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [administratori] (
        [AdminId] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [AktivacijaId] int NULL,
        CONSTRAINT [PK_administratori] PRIMARY KEY ([AdminId]),
        CONSTRAINT [FK_administratori_aktivacije_AktivacijaId] FOREIGN KEY ([AktivacijaId]) REFERENCES [aktivacije] ([AktivacijaId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [drzave] (
        [DrzavaId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [RegionId] int NOT NULL,
        CONSTRAINT [PK_drzave] PRIMARY KEY ([DrzavaId]),
        CONSTRAINT [FK_drzave_regioni_RegionId] FOREIGN KEY ([RegionId]) REFERENCES [regioni] ([RegionId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [vozila] (
        [VoziloId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [DostavljacId] int NOT NULL,
        CONSTRAINT [PK_vozila] PRIMARY KEY ([VoziloId]),
        CONSTRAINT [FK_vozila_zaposlenici_DostavljacId] FOREIGN KEY ([DostavljacId]) REFERENCES [zaposlenici] ([ZaposlenikId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [gradovi] (
        [GradId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [DrzavaId] int NOT NULL,
        CONSTRAINT [PK_gradovi] PRIMARY KEY ([GradId]),
        CONSTRAINT [FK_gradovi_drzave_DrzavaId] FOREIGN KEY ([DrzavaId]) REFERENCES [drzave] ([DrzavaId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [adrese] (
        [AdresaId] int NOT NULL IDENTITY,
        [Ulica] nvarchar(max) NULL,
        [BrUlice] nvarchar(max) NULL,
        [PostnskiBroj] nvarchar(max) NULL,
        [Aktivna] bit NOT NULL,
        [GradId] int NOT NULL,
        CONSTRAINT [PK_adrese] PRIMARY KEY ([AdresaId]),
        CONSTRAINT [FK_adrese_gradovi_GradId] FOREIGN KEY ([GradId]) REFERENCES [gradovi] ([GradId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [korisnici] (
        [KorisnikId] int NOT NULL IDENTITY,
        [Ime] nvarchar(max) NULL,
        [Prezime] nvarchar(max) NULL,
        [Aktivan] bit NOT NULL,
        [Registrovan] bit NOT NULL,
        [AdresaId] int NOT NULL,
        [AktivacijaId] int NULL,
        CONSTRAINT [PK_korisnici] PRIMARY KEY ([KorisnikId]),
        CONSTRAINT [FK_korisnici_adrese_AdresaId] FOREIGN KEY ([AdresaId]) REFERENCES [adrese] ([AdresaId]) ON DELETE CASCADE,
        CONSTRAINT [FK_korisnici_aktivacije_AktivacijaId] FOREIGN KEY ([AktivacijaId]) REFERENCES [aktivacije] ([AktivacijaId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [skladista] (
        [SkladisteId] int NOT NULL,
        [Naziv] nvarchar(max) NULL,
        [Opis] nvarchar(max) NULL,
        CONSTRAINT [PK_skladista] PRIMARY KEY ([SkladisteId]),
        CONSTRAINT [FK_skladista_adrese_SkladisteId] FOREIGN KEY ([SkladisteId]) REFERENCES [adrese] ([AdresaId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [dostave] (
        [DostavaId] int NOT NULL IDENTITY,
        [DatumDostave] datetime2 NOT NULL,
        [DatumKreiranja] datetime2 NOT NULL,
        [DatumIzmjene] datetime2 NOT NULL,
        [Prioritet] int NOT NULL,
        [Aktivna] bit NOT NULL,
        [BrojDostave] nvarchar(max) NULL,
        [Tezina] float NOT NULL,
        [Cijena] float NOT NULL,
        [DostavljacId] int NOT NULL,
        [PosiljalacId] int NOT NULL,
        [PrimalacId] int NOT NULL,
        [PlatilacId] int NOT NULL,
        CONSTRAINT [PK_dostave] PRIMARY KEY ([DostavaId]),
        CONSTRAINT [FK_dostave_zaposlenici_DostavljacId] FOREIGN KEY ([DostavljacId]) REFERENCES [zaposlenici] ([ZaposlenikId]) ON DELETE CASCADE,
        CONSTRAINT [FK_dostave_korisnici_PlatilacId] FOREIGN KEY ([PlatilacId]) REFERENCES [korisnici] ([KorisnikId]) ON DELETE CASCADE,
        CONSTRAINT [FK_dostave_korisnici_PosiljalacId] FOREIGN KEY ([PosiljalacId]) REFERENCES [korisnici] ([KorisnikId]),
        CONSTRAINT [FK_dostave_korisnici_PrimalacId] FOREIGN KEY ([PrimalacId]) REFERENCES [korisnici] ([KorisnikId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [ocjene] (
        [OcjenaId] int NOT NULL IDENTITY,
        [OcjenaDostave] int NOT NULL,
        [OpisOcjene] nvarchar(max) NULL,
        [KorisnikId] int NOT NULL,
        [DostavaId] int NOT NULL,
        CONSTRAINT [PK_ocjene] PRIMARY KEY ([OcjenaId]),
        CONSTRAINT [FK_ocjene_dostave_DostavaId] FOREIGN KEY ([DostavaId]) REFERENCES [dostave] ([DostavaId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ocjene_korisnici_KorisnikId] FOREIGN KEY ([KorisnikId]) REFERENCES [korisnici] ([KorisnikId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [statusi] (
        [StatusId] int NOT NULL IDENTITY,
        [StatusDostave] nvarchar(max) NULL,
        [Opis] nvarchar(max) NULL,
        [DatumIzmjene] datetime2 NOT NULL,
        [DostavaId] int NOT NULL,
        CONSTRAINT [PK_statusi] PRIMARY KEY ([StatusId]),
        CONSTRAINT [FK_statusi_dostave_DostavaId] FOREIGN KEY ([DostavaId]) REFERENCES [dostave] ([DostavaId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE TABLE [stavkeDostave] (
        [StavkaId] int NOT NULL IDENTITY,
        [Naziv] nvarchar(max) NULL,
        [Opis] nvarchar(max) NULL,
        [BrojStavke] nvarchar(max) NULL,
        [Tezina] float NOT NULL,
        [DostavaId] int NOT NULL,
        [VrstaId] int NOT NULL,
        CONSTRAINT [PK_stavkeDostave] PRIMARY KEY ([StavkaId]),
        CONSTRAINT [FK_stavkeDostave_dostave_DostavaId] FOREIGN KEY ([DostavaId]) REFERENCES [dostave] ([DostavaId]) ON DELETE CASCADE,
        CONSTRAINT [FK_stavkeDostave_vrsteStavki_VrstaId] FOREIGN KEY ([VrstaId]) REFERENCES [vrsteStavki] ([VrstaId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_administratori_AktivacijaId] ON [administratori] ([AktivacijaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_adrese_GradId] ON [adrese] ([GradId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_dostave_DostavljacId] ON [dostave] ([DostavljacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_dostave_PlatilacId] ON [dostave] ([PlatilacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_dostave_PosiljalacId] ON [dostave] ([PosiljalacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_dostave_PrimalacId] ON [dostave] ([PrimalacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_drzave_RegionId] ON [drzave] ([RegionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_gradovi_DrzavaId] ON [gradovi] ([DrzavaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_korisnici_AdresaId] ON [korisnici] ([AdresaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_korisnici_AktivacijaId] ON [korisnici] ([AktivacijaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_ocjene_DostavaId] ON [ocjene] ([DostavaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_ocjene_KorisnikId] ON [ocjene] ([KorisnikId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_statusi_DostavaId] ON [statusi] ([DostavaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_stavkeDostave_DostavaId] ON [stavkeDostave] ([DostavaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_stavkeDostave_VrstaId] ON [stavkeDostave] ([VrstaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    CREATE INDEX [IX_vozila_DostavljacId] ON [vozila] ([DostavljacId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506093722_init db')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190506093722_init db', N'2.1.11-servicing-32099');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    ALTER TABLE [administratori] DROP CONSTRAINT [FK_administratori_aktivacije_AktivacijaId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    ALTER TABLE [korisnici] DROP CONSTRAINT [FK_korisnici_aktivacije_AktivacijaId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    DROP TABLE [aktivacije];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    CREATE TABLE [korisnickiNalog] (
        [korisnickiNalogId] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        CONSTRAINT [PK_korisnickiNalog] PRIMARY KEY ([korisnickiNalogId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    ALTER TABLE [administratori] ADD CONSTRAINT [FK_administratori_korisnickiNalog_AktivacijaId] FOREIGN KEY ([AktivacijaId]) REFERENCES [korisnickiNalog] ([korisnickiNalogId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    ALTER TABLE [korisnici] ADD CONSTRAINT [FK_korisnici_korisnickiNalog_AktivacijaId] FOREIGN KEY ([AktivacijaId]) REFERENCES [korisnickiNalog] ([korisnickiNalogId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190506095217_promjena imena tabele aktivacija u korisnickiNalog', N'2.1.11-servicing-32099');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513091941_dodavanje veze izmedju zaposelnika i korisnickog naloga')
BEGIN
    ALTER TABLE [zaposlenici] ADD [AktivacijaId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513091941_dodavanje veze izmedju zaposelnika i korisnickog naloga')
BEGIN
    CREATE INDEX [IX_zaposlenici_AktivacijaId] ON [zaposlenici] ([AktivacijaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513091941_dodavanje veze izmedju zaposelnika i korisnickog naloga')
BEGIN
    ALTER TABLE [zaposlenici] ADD CONSTRAINT [FK_zaposlenici_korisnickiNalog_AktivacijaId] FOREIGN KEY ([AktivacijaId]) REFERENCES [korisnickiNalog] ([korisnickiNalogId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513091941_dodavanje veze izmedju zaposelnika i korisnickog naloga')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190513091941_dodavanje veze izmedju zaposelnika i korisnickog naloga', N'2.1.11-servicing-32099');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513132718_dodavanje tabele AutoritzacijskiToken')
BEGIN
    CREATE TABLE [autorizacijskiToken] (
        [Id] int NOT NULL IDENTITY,
        [Vrijednost] nvarchar(max) NULL,
        [VrijemeEvidentiranja] datetime2 NOT NULL,
        [IpAdresa] nvarchar(max) NULL,
        [KorisnickiNalogId] int NOT NULL,
        CONSTRAINT [PK_autorizacijskiToken] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_autorizacijskiToken_korisnickiNalog_KorisnickiNalogId] FOREIGN KEY ([KorisnickiNalogId]) REFERENCES [korisnickiNalog] ([korisnickiNalogId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513132718_dodavanje tabele AutoritzacijskiToken')
BEGIN
    CREATE INDEX [IX_autorizacijskiToken_KorisnickiNalogId] ON [autorizacijskiToken] ([KorisnickiNalogId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190513132718_dodavanje tabele AutoritzacijskiToken')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190513132718_dodavanje tabele AutoritzacijskiToken', N'2.1.11-servicing-32099');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190517133457_dodavanje veze dostava - adresa')
BEGIN
    ALTER TABLE [dostave] ADD [AdresaId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190517133457_dodavanje veze dostava - adresa')
BEGIN
    CREATE INDEX [IX_dostave_AdresaId] ON [dostave] ([AdresaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190517133457_dodavanje veze dostava - adresa')
BEGIN
    ALTER TABLE [dostave] ADD CONSTRAINT [FK_dostave_adrese_AdresaId] FOREIGN KEY ([AdresaId]) REFERENCES [adrese] ([AdresaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190517133457_dodavanje veze dostava - adresa')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190517133457_dodavanje veze dostava - adresa', N'2.1.11-servicing-32099');
END;

GO

