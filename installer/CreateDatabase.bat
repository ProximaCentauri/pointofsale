
@echo off
REM 03072013 
REM Start : Create database using create_db_laundry_refilling.sql
REM Start mysql service first before executing this script

set currentPath=%~dp0
set sqlscriptPath=%currentPath:~bin=db\script%
goto backupData

REM ================= START Perform backup of data ======================
:backupData
echo Performing backup
call %currentPath%\BackupData.bat
IF %ERRORLEVEL% NEQ 0 goto errorHandler
goto runCreateDBScript
REM ================= END Perform backup of data ========================



REM ================= START Create database script ======================
:runCreateDBScript
echo Creating database
mysql -h localhost -u root -proot < %sqlscriptPath%\create_db_laundry_refilling.sql
IF %ERRORLEVEL% NEQ 0 goto errorHandler
goto successHandler
REM ================= END Create database script ========================



REM ================= START Create backup scheduled job =================
:createBackupSchedJob
echo Creating backup schedule job
schtasks /create /RU "system" /SC DAILY /TN runMySQLbackupjob /TR %currentPath%\BackupData.bat /ST 18:00:00
REM ================= END Create backup scheduled job ===================



REM ================= START Return handlers =============================
:errorHandler
@echo Error in creating database; please check if you have mysql installed and mysql service running, and set the correct path in the script.
@echo ERRORLEVEL %ERRORLEVEL% 
exit /B

:successHandler
@echo Create database successful!
exit /B
REM ================= END Return handlers ================================