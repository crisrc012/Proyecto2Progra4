@echo off
CHCP 65001
SET file="DB_Vistas_SP_Inserts.sql"
type ClubCampestre.sql > %file%
type Otros\Login.sql >> %file%
type Vistas\Vistas.sql >> %file%
cmd /c Generar_Store_Procedures.bat
type SP_Unificado.sql >> %file%
type Otros\Inserts.sql >> %file%
exit