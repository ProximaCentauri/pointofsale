
@echo off
REM 03072013 
REM Start : Create database using create_db_laundry_refilling.sql
REM Start mysql service first before executing this script

set currentPath=%~dp0
set sqlscriptPath=%currentPath:bin=db%script

IF NOT EXIST %sqlscriptPath% (
	echo SQL scripts needed to create database do not exist. Please ensure you have the SQL scripts placed in %sqlscriptPath%.
	exit /B
)
goto backupData

REM ================= START Perform backup of data ======================
:backupData
echo Performing backup
call %currentPath%\BackupData.bat
IF %ERRORLEVEL%==0 (
	echo Performing backup - DONE
	goto runCreateDBScript
)
goto errorHandler
REM ================= END Perform backup of data ========================



REM ================= START Create database script ======================
:runCreateDBScript
echo Creating database
mysql -h localhost -u root -proot < %sqlscriptPath%\create_db_laundry_refilling.sql
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Creating database - DONE
goto insertDefaultData
REM ================= END Create database script ========================



REM ================= START Insert default data =========================
:insertDefaultData
echo Inserting default data
mysql -h localhost -u root -proot < %sqlscriptPath%\insert_default_livedata.sql
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Inserting default data - DONE
goto createBackupSchedJob
REM ================= END Insert default data ===========================



REM ================= START Create backup scheduled job =================
:createBackupSchedJob
echo Creating backup schedule job
schtasks /create /RU runasuser /SC DAILY /TN runMySQLbackupjob /TR %currentPath%\BackupData.bat /ST 18:00:00
goto successHandler
REM ================= END Create backup scheduled job ===================



REM ================= START Return handlers =============================
:errorHandler
@echo Error in creating database; please check if you have mysql installed and mysql service running, and set the correct path in the script.
@echo ERRORLEVEL %ERRORLEVEL% 
exit /B

:successHandler
@echo Successful!
exit /B
REM ================= END Return handlers ================================