USE Uczelnia;
-- Struktura bazy danych
CREATE TABLE Uczniowie (
    UczenID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    NrIndeksu NVARCHAR(10),
    Semestr INT
	-- dodaæ co siê uczy (jaki zak³ad)
);

CREATE TABLE Wykladowcy (
    WykladowcaID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    Stopien NVARCHAR(50),
    Specjalizacja NVARCHAR(100)
);

CREATE TABLE HR (
    HRID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    Stanowisko NVARCHAR(50)
);

CREATE TABLE Wydzialy (
    WydzialID INT PRIMARY KEY IDENTITY(1,1),
    Nazwa NVARCHAR(50),
    Zaklad NVARCHAR(50)
);

CREATE TABLE KierownicyWydzialu (
    KierownikID INT PRIMARY KEY IDENTITY(1,1),
    Imie NVARCHAR(50),
    Nazwisko NVARCHAR(50),
    WydzialID INT,
    FOREIGN KEY (WydzialID) REFERENCES Wydzialy(WydzialID)
);

CREATE TABLE Oceny (
    OcenaID INT PRIMARY KEY IDENTITY(1,1),
    UczenID INT,
    Przedmiot NVARCHAR(50),
    Ocena INT,
    FOREIGN KEY (UczenID) REFERENCES Uczniowie(UczenID)
);

-- Dodanie indeksów
CREATE INDEX idx_NrIndeksu ON Uczniowie(NrIndeksu);
CREATE INDEX idx_Specjalizacja ON Wykladowcy(Specjalizacja);

-- Dodanie procedury do dodawania ucznia
GO
CREATE OR ALTER PROCEDURE DodajUcznia
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @NrIndeksu NVARCHAR(10),
    @Semestr INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        IF LEN(@NrIndeksu) = 4
		BEGIN
        INSERT INTO Uczniowie (Imie, Nazwisko, NrIndeksu, Semestr)
        VALUES (@Imie, @Nazwisko, @NrIndeksu, @Semestr);
        
        COMMIT;
		END
		ELSE
		BEGIN
		   THROW 50000, 'Numer indeksu musi mieæ dok³adnie 4 cyfry.', 1;
		END
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania wyk³adowcy
GO
CREATE or ALTER PROCEDURE DodajWykladowce
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @Stopien NVARCHAR(10),
    @Specjalizacja NVARCHAR(100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO Wykladowcy(Imie, Nazwisko, Stopien, Specjalizacja)
        VALUES (@Imie, @Nazwisko, @Stopien, @Specjalizacja);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania HR
GO
CREATE or ALTER PROCEDURE DodajHR
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @Stanowisko NVARCHAR(50)
 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO HR(Imie, Nazwisko, Stanowisko)
        VALUES (@Imie, @Nazwisko, @Stanowisko);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania Wydzia³y
GO
CREATE or ALTER PROCEDURE DodajWydzial
    @Nazwa NVARCHAR(50),
    @Zaklad NVARCHAR(50)
 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        INSERT INTO Wydzialy(Nazwa, Zaklad)
        VALUES (@Nazwa, @Zaklad);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
-- Dodanie procedury do dodawania Kierownika wydzialu 
GO
CREATE OR ALTER PROCEDURE DodajKierownikaWydzialu
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @WydzialID INT
AS
BEGIN
    BEGIN TRY
        -- Sprawdzenie, czy istnieje taki wydzia³
        IF NOT EXISTS (SELECT 1 FROM Wydzialy WHERE WydzialID = @WydzialID)
        BEGIN
            THROW 50000, 'Podany Wydzia³ID nie istnieje.', 1;
        END

        -- Walidacja minimalnej iloœci znaków dla imienia
        IF LEN(@Imie) < 3
        BEGIN
            THROW 50000, 'Imiê musi mieæ co najmniej 3 znaki.', 1;
        END

        -- Walidacja minimalnej iloœci znaków dla nazwiska
        IF LEN(@Nazwisko) < 3
        BEGIN
            THROW 50000, 'Nazwisko musi mieæ co najmniej 3 znaki.', 1;
        END

        BEGIN TRANSACTION;
        
        INSERT INTO KierownicyWydzialu(Imie, Nazwisko, WydzialID)
        VALUES (@Imie, @Nazwisko, @WydzialID);
        
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;



Select * From Wydzialy;

-- Procedura do odczytu danych z tabeli Uczniowie
GO
CREATE OR ALTER PROCEDURE PobierzUczniow
AS
BEGIN
    SELECT *
    FROM Uczniowie;
END;

-- Procedura do odczytu danych z tabeli Wykladowcy
GO
CREATE OR ALTER PROCEDURE PobierzWykladowcow
AS
BEGIN
    SELECT *
    FROM Wykladowcy;
END;
-- Procedura do odczytu danych z tabeli HR
GO
CREATE OR ALTER PROCEDURE PobierzHR
AS
BEGIN
    SELECT *
    FROM HR;
END;

-- Procedura do odczytu danych z tabeli Wydzial
GO
CREATE OR ALTER PROCEDURE PobierzWydzial
AS
BEGIN
    SELECT *
    FROM Wydzialy;
END;
-- Procedura do odczytu danych z tabeli kierownik wydzia³u
GO
CREATE OR ALTER PROCEDURE PobierzKierownikWydzial
AS
BEGIN
    SELECT Imie, Nazwisko, WydzialID
    FROM KierownicyWydzialu;
END;

-- Procedura do aktualizacji danych ucznia
GO
CREATE or ALTER PROCEDURE AktualizujUcznia
    @IdUczniowie INT,
    @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @NrIndeksu NVARCHAR(10),
    @Semestr INT
AS
BEGIN
    UPDATE Uczniowie
    SET Imie = @Imie,
        Nazwisko = @Nazwisko,
        NrIndeksu = @NrIndeksu,
        Semestr = @Semestr
    WHERE UczenID = @IdUczniowie;
END;
--procedura pobierania danych konkretnego ucznia
GO
CREATE OR ALTER PROCEDURE PobierzDaneUcznia
    @IdUczniowie INT
AS
BEGIN
    SELECT UczenID, Imie, Nazwisko, NrIndeksu, Semestr
    FROM Uczniowie
    WHERE UczenID = @IdUczniowie;
END;
-- Procedura do usuwania danych z tabeli Wykladowcy
GO
CREATE OR ALTER PROCEDURE UsunWykladowce
    @WykladowcaID INT
AS
BEGIN
    DELETE FROM Wykladowcy
    WHERE WykladowcaID = @WykladowcaID;
END;
--Aktualizacja kierownika
GO
CREATE OR ALTER PROCEDURE AktualizujKierownikaWydzialu
    @KierownikID INT,
    @NoweImie NVARCHAR(50),
    @NoweNazwisko NVARCHAR(50),
    @NoweWydzialID INT
AS
BEGIN
    IF LEN(@NoweImie) < 3 OR LEN(@NoweNazwisko) < 3
    BEGIN
        RAISERROR ('Imiê i nazwisko musz¹ zawieraæ co najmniej 3 litery.', 16, 1)
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Wydzialy WHERE WydzialID = @NoweWydzialID)
    BEGIN
        RAISERROR ('Wydzia³ o podanym identyfikatorze nie istnieje.', 16, 1)
        RETURN;
    END

    UPDATE KierownicyWydzialu
    SET Imie = @NoweImie,
        Nazwisko = @NoweNazwisko,
        WydzialID = @NoweWydzialID
    WHERE KierownikID = @KierownikID;
END;

-- usuwanie kierownika
GO
CREATE PROCEDURE UsunKierownikaWydzialu
     @Imie NVARCHAR(50),
    @Nazwisko NVARCHAR(50),
    @WydzialID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM KierownicyWydzialu WHERE @Imie = Imie AND @Nazwisko = Nazwisko AND @WydzialID = WydzialID;
END





-- Dodanie triggera do aktualizacji semestru ucznia po dodaniu oceny
GO
CREATE TRIGGER AktualizujSemestr
ON Oceny
AFTER INSERT
AS
BEGIN
    UPDATE Uczniowie
    SET Semestr = Semestr + 1
    FROM Uczniowie
    JOIN inserted ON Uczniowie.UczenID = inserted.UczenID;
END;

-- Pozosta³e procedury, triggery itp. mo¿na dodawaæ podobnie
Select * From Uczniowie;
 Select * From HR;
Select * From Wydzialy;
Select * From KierownicyWydzialu;

-- Dodanie nowej kolumny Zaklad
