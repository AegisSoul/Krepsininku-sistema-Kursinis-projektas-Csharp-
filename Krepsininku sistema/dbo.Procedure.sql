CREATE PROC PridetiVartotoja
@vartotojoVardas nchar(35),
@slaptazodis nchar(35)
AS
    INSERT INTO Admin(Username, Password)
    VALUES (@vartotojoVardas, @slaptazodis)