
@echo off
REM 03072013 
REM Start : backup data and schema in db_laundry_refilling
REM Start mysql service first before executing this script

set backupPath="C:\Documents and Settings\%USERNAME%\Application Data\LaundryRefill\Data\"
set month=%DATE:~4,2%
set day=%DATE:~7,2%
set year=%DATE:~-4%
set currentdate=%month%%day%%year%  
set dbname=db_laundry_refilling

set result=mysql --skip-column-names -e "SHOW DATABASES LIKE '%dbname%'"
if result==%dbname% (
	goto createBackupDir
)
goto successHandler


REM ================= START Create backup directory =====================
:createBackupDir
echo Verifying backup directory
IF NOT EXIST %backupPath% mkdir %backupPath%
goto backupData
REM ================= END Create backup directory =======================



REM ================= START Perform backup of data ======================
:backupData
echo Performing backup of data


mysqldump -uroot -proot --no-create-info %dbname% > %backupPath%%dbname%_data_%currentdate%.sql
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Performing backup of data - DONE
goto backupSchema
REM ================= END Perform backup of data ========================



REM ================= START Perform backup of schema ====================
:backupSchema
echo Performing backup of schema
mysqldump -uroot -proot --no-data %dbname% > %backupPath%%dbname%_schema_%currentdate%.sql
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Performing backup of schema - DONE
@echo Backup data and schema successful
goto successHandler
REM ================= END Perform backup of schema ======================



REM ================= START Return handlers =============================
:errorHandler
@echo Error in performing the backup of data/schema; please check if you have mysql installed and mysql service running
@echo ERRORLEVEL %ERRORLEVEL% 
exit /B

:successHandler
exit /B 0
REM ================= END Return handlers ===============================