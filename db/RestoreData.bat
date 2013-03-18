
@echo off

REM 03152013 
REM Start : restore data and schema in db_laundry_refilling
REM Start mysql service first before executing this script

set backupPath=C:\Documents and Settings\%USERNAME%\Application Data\LaundryRefill\Data\
set backupSchemaFile=%~1
set backupDataFile=%~2
set dbname=db_laundry_refilling
set dbfound=null

if "%backupSchemaFile%"=="" (
	for /f %%a in ('dir "%backupPath%%dbname%_schema*.sql" /od /a-d /b') do set backupSchemaFile=%%a
)
if "%backupDataFile%"=="" (
	for /f %%a in ('dir "%backupPath%%dbname%_data*.sql" /od /a-d /b') do set backupDataFile=%%a
)

if not "%backupSchemaFile%"=="" (	
	set backupSchemaFile=%backupSchemaFile: =%
)
if not "%backupDataFile%"=="" (
	set backupDataFile=%backupDataFile: =%
)


for /f %%a in ('mysql.exe -u root -proot -s -N -e "SHOW DATABASES LIKE '%dbname%'"') do set dbfound=%%a
if %dbfound%==%dbname% (
	goto verifyBackupFile
)
goto successHandler


REM ================= START Verify backup file ===========================
:verifyBackupFile
echo Verifying backup file
IF NOT EXIST %backupPath%%backupSchemaFile% goto errorHandler
IF "%backupSchemaFile%"=="" goto errorHandler
IF NOT EXIST %backupPath%%backupDataFile% goto errorHandler
IF "%backupDataFile%"=="" goto errorHandler
goto restoreSchema
REM ================= END Verify backup file =============================



REM ================= START Verify restore of schema =======================
:restoreSchema
echo Performing restore of schema
mysql -u root -proot %dbname% < "%backupPath%%backupSchemaFile%"
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Performing restore of schema - DONE
goto restoreData
REM ================= END Perform restore of schema ========================



REM ================= START Perform restore of data ====================
:restoreData
echo Performing restore of data
mysql -uroot -proot %dbname% < "%backupPath%%backupDataFile%"
IF %ERRORLEVEL% NEQ 0 goto errorHandler
echo Performing restore of schema - DONE
@echo Restore schema and data successful
goto successHandler
REM ================= END Perform restore of data ======================



REM ================= START Return handlers =============================
:errorHandler
@echo Error in performing the restore of data; please verify if you have the data file to restore and if you have mysql installed and mysql service running.
@echo ERRORLEVEL %ERRORLEVEL% 
exit /B

:successHandler
exit /B 0
REM ================= END Return handlers ===============================