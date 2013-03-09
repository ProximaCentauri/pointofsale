!include LogicLib.nsh
!include MUI2.nsh
!include nsProcess.nsh
!include Sections.nsh

!define APPNAME "Laundry_Refill_Applicaton"
!define COMPANYNAME "NOW Solutions"

!define VERSIONMAJOR 1
!define VERSIONMINOR 0
!define VERSIONHOTFIX 0
!define VERSIONBUILD 0
;!define INSDIR "C:\LaundryRefill"
!define APPEXE "../lib"

!define DOT_MAJOR "3"
!define DOT_MINOR "5"

!define LVM_GETITEMCOUNT 0x1004
!define LVM_GETITEMTEXT 0x102D

!define SHELLFOLDERS "Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders"
# Name of our application
Name "Laundry and Refill Application"

# define name of installer
outFile "LaundryRefill${VERSIONMAJOR}.${VERSIONMINOR}.${VERSIONHOTFIX}.${VERSIONBUILD}.exe"
 
# define installation directory

;installDir "c:\Laundry and Refill Application"


# Set the text which prompts the user to enter the installation directory
DirText "Please choose a directory to which you'd like to install this application."

# Adds an XP manifest to the installer
XPStyle on

#Interface Configuration
!define MUI_HEADERIMAGE

!define MUI_HEADERIMAGE_BITMAP "../images\nowsolutions.bmp" /resizetofit; optional

!define MUI_ABORTWARNING

# Add branding image to the installer (an image placeholder on the side).
# It is not enough to just add the placeholder, we must set the image too...
# We will later set the image in every pre-page function.
# We can also set just one persistent image in .onGUIInit
AddBrandingImage top 100

# show install details
ShowInstDetails show

# show uninstall details
ShowUninstDetails show

# Pages
!insertmacro MUI_PAGE_LICENSE "license.txt"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

#Languages
!insertmacro MUI_LANGUAGE "English"

#This macro checks if user rights is admin
!macro VerifyUserIsAdmin
UserInfo::GetAccountType
pop $0
${If} $0 != "admin" ;Require admin rights on NT4+
        messageBox mb_iconstop "Administrator rights required!"
        setErrorLevel 740 ;ERROR_ELEVATION_REQUIRED
        quit
${EndIf}
!macroend

# start default section
section "install" SEC_1

	# Check to see if already installed
	IfFileExists $INSTDIR 0 +2
	MessageBox MB_YESNO "Directory already exist. Would you like to overwrite the existing directory? $\n$\nPress Yes to continue installation else Press No to stop installation" IDNO end
	
	Call Today
	Pop $2 ;"day"
	Pop $3 ;"month"
	Pop $4 ;"year"
	DetailPrint "Installation Date: $2/$3/$4"
	
	Push start ;signifies to start counting
	Push 0 ;output mode (finish only)
	Call CompletionTime
	Pop $0 ;current time (xx:xx:xx)
	Pop $1 ;current time (xx:xx:xx)
	DetailPrint "Start Time: $1"
	
	ReadRegStr $0 HKCU "${SHELLFOLDERS}" AppData
	StrCmp $0 "" 0 +2
	  ReadRegStr $0 HKLM "${SHELLFOLDERS}" "Common AppData"
	StrCmp $0 "" 0 +2
	  StrCpy $0 "$WINDIR\Application Data"

	Delete $INSTDIR\images\*.*
	RMDir $INSTDIR\images
	Delete $INSTDIR\docs\*.*
	RMDir $INSTDIR\docs
	Delete $INSTDIR\bin\*.*
	RMDir $INSTDIR\bin
	Delete $INSTDIR\db\script\*.*
	RMDir $INSTDIR\db\script
	RMDir $INSTDIR\db
	Delete $INSTDIR\*.*
	RMDir $INSTDIR
	
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\LaundryRefillApplication"
	DeleteRegKey HKCU "LaundryRefill"
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\AppCompatFlags\Layers"
	
	# set the installation directory as the destination for the following actions
	setOutPath $INSTDIR
	
	File ../lib\*.dll*
	File ../lib\app.config
	File ${APPEXE}\LaundryRefill.exe
	File ${APPEXE}\LaundryRefill.exe.config
	setOutPath $INSTDIR\docs
	File ../docs\*.*
	setOutPath $INSTDIR\bin
	File ../db\BackupData.bat
	File ../db\CreateDatabase.bat
	setOutPath $INSTDIR\db\script
	File ../db\create_db_laundry_refilling.sql
	File ../db\insert_default_livedata.sql
	File ../db\insert_default_testdata.sql
	
	;CreateDirectory $0\logs
	setOutPath $INSTDIR
	File ../docs\*.*

	CreateDirectory "$SMPROGRAMS\Laundry Refill Application"
	CreateShortCut "$SMPROGRAMS\Laundry Refill Application\LaundryRefill.lnk" "$INSTDIR\LaundryRefill.exe"
	CreateShortCut "$SMPROGRAMS\Laundry Refill Application\Users_Guide.lnk" "$INSTDIR\User Manual.docx"
	CreateShortCut "$SMPROGRAMS\Laundry Refill Application\LaundryRefillUninstall.lnk" "$INSTDIR\LaundryRefillUninstall.exe"
	
	# set the installation directory as the destination for the following actions
	;setOutPath $INSTDIR\dictionaries

	setOutPath $INSTDIR\images
	File ../images\*.*

	# create the uninstaller
	WriteUninstaller "$INSTDIR\LaundryRefillUninstall.exe"
 
	# create a shortcut in the start menu programs directory
	# point the new shortcut at the program uninstaller
	
		
	# create registry keys for add/remove programs in control panel
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Laundry Refill Application" "DisplayName" ${APPNAME}
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Laundry Refill Application" "DisplayVersion" ${VERSIONMAJOR}.${VERSIONMINOR}.${VERSIONHOTFIX}.${VERSIONBUILD}
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Laundry Refill Application" "UninstallString" $INSTDIR\LaundryRefillUninstall.exe
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\AppCompatFlags\Layers" "$INSTDIR" "WINXPSP2"


	Push finish ;signifies to finish & report completion time
	Push 3 ;output mode (1=secs only|2=secs+mins only|3=all)
	Call CompletionTime
	Pop $0 ;completed time (x hours, x mins, x secs.)
	Pop $1 ;current time (xx:xx:xx)
	DetailPrint "Finish Time: $1"

	#Create install.log
	StrCpy $0 "$INSTDIR\install.log"
	Push $0
	Call DumpLog
	
	end:
		Pop $R0
	
sectionEnd
 
# uninstaller section start
section "uninstall" SEC_2

	ReadRegStr $0 HKCU "${SHELLFOLDERS}" AppData
	StrCmp $0 "" 0 +2
	  ReadRegStr $0 HKLM "${SHELLFOLDERS}" "Common AppData"
	StrCmp $0 "" 0 +2
	  StrCpy $0 "$WINDIR\Application Data"
	;IfFileExists "$0\PerfCheck\reports\*.csv" 0 +4
;	MessageBox MB_ICONEXCLAMATION|MB_YESNO "Existing reports found. $\r$\nWould you like to keep reports folder?" IDYES +2 IDNO 0
	;	Delete $0\PerfCheck\reports\*.*
	
	;Delete $0\PerfCheck\reports\*.*
	Delete $0\NJournals\logs\*.*
	
	RMDir $0\NJournals\logs
	RMDir $0\NJournals
	
    # first, delete the uninstaller
	;Delete "${APPDIR}\PerfCheckUninstall.exe"
    Delete $INSTDIR\images\*.*
	RMDir $INSTDIR\images
	Delete $INSTDIR\docs\*.*
	RMDir $INSTDIR\docs
	Delete $INSTDIR\bin\*.*
	RMDir $INSTDIR\bin
	Delete $INSTDIR\db\script\*.*
	RMDir $INSTDIR\db\script
	RMDir $INSTDIR\db
	Delete $INSTDIR\*.*
	RMDir $INSTDIR
	;Delete $INSTDIR\NCRSelfServCheckoutApplicationPerformanceAssessmentToolVersion1.0.0UsersGuide.doc
	
		
    # second, remove the link from the start menu
	Delete "$SMPROGRAMS\Laundry Refill Application\LaundryRefill.lnk"
	Delete "$SMPROGRAMS\Laundry Refill Application\Users_Guide.lnk"
    Delete "$SMPROGRAMS\Laundry Refill Application\LaundryRefillUninstall.lnk"

	RMDir "$SMPROGRAMS\Laundry Refill Application"
	
	# Remove uninstaller information from the registry
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Laundry Refill Application"
	DeleteRegKey HKCU "LaundryRefill"
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\AppCompatFlags\Layers"


# uninstaller section end
sectionEnd


Function .onInit
	setShellVarContext all
	#Check if user rights is admin.
	!insertmacro VerifyUserIsAdmin
	#Check if .Net Framework is installed.
	Call IsDotNetInstalled
	#Check if product is running.
	App_Running_Check:
	${nsProcess::FindProcess} "LaundryRefill.exe" $R0
	${If} $R0 == 0

		MessageBox MB_RETRYCANCEL|MB_ICONEXCLAMATION "Laundry Refill Application is running. $\nPlease close the application before continuing." /SD IDCANCEL IDRETRY App_Running_Check

		Quit
	${EndIf}
	#Check if product is already installed.
	Call IsProductInstalled
FunctionEnd

Function un.onInit
	SetShellVarContext all
 
	#Verify the uninstaller - last chance to back out

	MessageBox MB_OKCANCEL "Permanantly remove Laundry Refill Application?" IDOK next

		Abort
	next:
	!insertmacro VerifyUserIsAdmin

	App_Running_Check:
	${nsProcess::FindProcess} "LaundryRefill.exe" $R0
	${If} $R0 == 0

		MessageBox MB_RETRYCANCEL|MB_ICONEXCLAMATION "Laundry Refill Application is running. $\nPlease close the application before continuing." /SD IDCANCEL IDRETRY App_Running_Check

		Quit
	${EndIf} 
FunctionEnd

Function IsProductInstalled
	;ClearErrors
	;ReadRegDWORD $2 HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SSCO Application Performance Assessment Tool" "DisplayVersion"
	;StrCmp $2 "" exit
	;MessageBox MB_OK|MB_ICONEXCLAMATION "SSCO Log File Analysis Utility v$2 is already installed. Please uninstall it first"  IDOK
	;Abort
	;exit:
	ClearErrors
	ReadRegDWORD $2 HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Laundry Refill Application" "DisplayVersion"
	StrCmp $2 "" exit
	
	Push $2
	Push ${VERSIONMAJOR}.${VERSIONMINOR}.${VERSIONHOTFIX}.${VERSIONBUILD}
	Call VersionCompare
	Pop $R0
	
	${If} $R0 == 0
		MessageBox MB_OKCANCEL "Laundry Refill Application v$2 is already installed. Install anyway?" IDOK exit
		Abort
	${EndIf} 
	${If} $R0 == 1
		MessageBox MB_OKCANCEL|MB_ICONEXCLAMATION "Laundry Refill Application v$2 is installed. $\nDowngrade to v${VERSIONMAJOR}.${VERSIONMINOR}.${VERSIONHOTFIX}.${VERSIONBUILD}?" IDOK exit
		Abort
	${EndIf} 
	${If} $R0 == 2
		MessageBox MB_OKCANCEL|MB_ICONEXCLAMATION "Laundry Refill Application v$2 is installed. $\nUpgrade to v${VERSIONMAJOR}.${VERSIONMINOR}.${VERSIONHOTFIX}.${VERSIONBUILD}?" IDOK exit
		Abort
	${EndIf} 
			
	exit:
FunctionEnd

Function IsDotNetInstalled
 
  StrCpy $0 "0"
  StrCpy $1 "SOFTWARE\Microsoft\.NETFramework" ;registry entry to look in.
  StrCpy $2 0
 
  StartEnum:
    ;Enumerate the versions installed.
    EnumRegKey $3 HKLM "$1\policy" $2
 
    ;If we don't find any versions installed, it's not here.
    StrCmp $3 "" noDotNet notEmpty
 
    ;We found something.
    notEmpty:
      ;Find out if the RegKey starts with 'v'.  
      ;If it doesn't, goto the next key.
      StrCpy $4 $3 1 0
      StrCmp $4 "v" +1 goNext
      StrCpy $4 $3 1 1
 
      ;It starts with 'v'.  Now check to see how the installed major version
      ;relates to our required major version.
      ;If it's equal check the minor version, if it's greater, 
      ;we found a good RegKey.
      IntCmp $4 ${DOT_MAJOR} +1 goNext yesDotNetReg
      ;Check the minor version.  If it's equal or greater to our requested 
      ;version then we're good.
      StrCpy $4 $3 1 3
      IntCmp $4 ${DOT_MINOR} yesDotNetReg goNext yesDotNetReg
 
    goNext:
      ;Go to the next RegKey.
      IntOp $2 $2 + 1
      goto StartEnum
 
  yesDotNetReg:
    ;Now that we've found a good RegKey, let's make sure it's actually
    ;installed by getting the install path and checking to see if the 
    ;mscorlib.dll exists.
    EnumRegValue $2 HKLM "$1\policy\$3" 0
    ;$2 should equal whatever comes after the major and minor versions 
    ;(ie, v1.1.4322)
    StrCmp $2 "" noDotNet
    ReadRegStr $4 HKLM $1 "InstallRoot"
    ;Hopefully the install root isn't empty.
    StrCmp $4 "" noDotNet
    ;build the actuall directory path to mscorlib.dll.
    StrCpy $4 "$4$3.$2\mscorlib.dll"
    IfFileExists $4 yesDotNet noDotNet
 
  noDotNet:
    ;Nope, something went wrong along the way.  Looks like the 
    ;proper .NET Framework isn't installed.  
    MessageBox MB_OK "This setup requires .NET Framework v${DOT_MAJOR}.${DOT_MINOR} or greater to be installed. $\nPlease install the requirement. Aborting Installation!"
    Abort
 
  yesDotNet:
    ;Everything checks out.  Go on with the rest of the installation.
 
FunctionEnd

Function VersionCompare

	Exch $1
	Exch
	Exch $0
	Exch
	Push $2
	Push $3
	Push $4
	Push $5
	Push $6
	Push $7
 
	begin:
	StrCpy $2 -1
	IntOp $2 $2 + 1
	StrCpy $3 $0 1 $2
	StrCmp $3 '' +2
	StrCmp $3 '.' 0 -3
	StrCpy $4 $0 $2
	IntOp $2 $2 + 1
	StrCpy $0 $0 '' $2
 
	StrCpy $2 -1
	IntOp $2 $2 + 1
	StrCpy $3 $1 1 $2
	StrCmp $3 '' +2
	StrCmp $3 '.' 0 -3
	StrCpy $5 $1 $2
	IntOp $2 $2 + 1
	StrCpy $1 $1 '' $2
 
	StrCmp $4$5 '' equal
 
	StrCpy $6 -1
	IntOp $6 $6 + 1
	StrCpy $3 $4 1 $6
	StrCmp $3 '0' -2
	StrCmp $3 '' 0 +2
	StrCpy $4 0
 
	StrCpy $7 -1
	IntOp $7 $7 + 1
	StrCpy $3 $5 1 $7
	StrCmp $3 '0' -2
	StrCmp $3 '' 0 +2
	StrCpy $5 0
 
	StrCmp $4 0 0 +2
	StrCmp $5 0 begin newer2
	StrCmp $5 0 newer1
	IntCmp $6 $7 0 newer1 newer2
 
	StrCpy $4 '1$4'
	StrCpy $5 '1$5'
	IntCmp $4 $5 begin newer2 newer1
 
	equal:
	StrCpy $0 0
	goto end
	newer1:
	StrCpy $0 1
	goto end
	newer2:
	StrCpy $0 2
 
	end:
	Pop $7
	Pop $6
	Pop $5
	Pop $4
	Pop $3
	Pop $2
	Pop $1
	Exch $0
FunctionEnd

Function DumpLog
	Exch $5
	Push $0
	Push $1
	Push $2
	Push $3
	Push $4
	Push $6
 
	FindWindow $0 "#32770" "" $HWNDPARENT
	GetDlgItem $0 $0 1016
	StrCmp $0 0 exit
	FileOpen $5 $5 "w"
	StrCmp $5 "" exit
		SendMessage $0 ${LVM_GETITEMCOUNT} 0 0 $6
		System::Alloc ${NSIS_MAX_STRLEN}
		Pop $3
		StrCpy $2 0
		System::Call "*(i, i, i, i, i, i, i, i, i) i \
			(0, 0, 0, 0, 0, r3, ${NSIS_MAX_STRLEN}) .r1"
		loop: StrCmp $2 $6 done
			System::Call "User32::SendMessageA(i, i, i, i) i \
				($0, ${LVM_GETITEMTEXT}, $2, r1)"
			System::Call "*$3(&t${NSIS_MAX_STRLEN} .r4)"
			FileWrite $5 "$4$\r$\n"
			IntOp $2 $2 + 1
			Goto loop
		done:
			FileClose $5
			System::Free $1
			System::Free $3
	exit:
		Pop $6
		Pop $4
		Pop $3
		Pop $2
		Pop $1
		Pop $0
		Exch $5
FunctionEnd

Function CompletionTime
	Exch $0 ;output mode
	Exch
	Exch $1 ;start or finish
	Push $2 ;universal
	Push $3 ;universal
	Push $4 ;universal
	Push $R0 ;temp
	Push $R1 ;hours
	Push $R2 ;mins
	Push $R3 ;secs
	 
	StrCpy $R0 $0 ;store output mode
	StrCpy $R1 0 ;hours
	StrCpy $R2 0 ;mins
	StrCpy $R3 0 ;secs
	StrCpy $R4 0 ;hours (day)
	 
	StrCmp $1 start 0 finish
	 
	# save start time
	System::Call '*(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) i .r1'
	System::Call 'kernel32::GetLocalTime(i) i(r1)'
	System::Call '*$1(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) \
	(,,,, .r3, .r2, .r1,)'
		StrLen $4 $1
		StrCmp $4 1 0 +2
			StrCpy $1 0$1
		StrLen $4 $2
		StrCmp $4 1 0 +2
			StrCpy $2 0$2
		StrLen $4 $3
		StrCmp $4 1 0 +2
			StrCpy $3 0$3
	StrCpy $0 "$3:$2:$1"
	 
	WriteINIStr "$TEMP\completiontime.tmp" "Time" "Value" "$0"

	Goto done2
	 
	finish:
	# get finish time
	System::Call '*(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) i .r1'
	System::Call 'kernel32::GetLocalTime(i) i(r1)'
	System::Call '*$1(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) \
	(,,,, .r3, .r2, .r1,)'
		StrLen $4 $1
		StrCmp $4 1 0 +2
			StrCpy $1 0$1
		StrLen $4 $2
		StrCmp $4 1 0 +2
			StrCpy $2 0$2
		StrLen $4 $3
		StrCmp $4 1 0 +2
			StrCpy $3 0$3
	StrCpy $0 "$3:$2:$1"
	 
	# get start time
	  ReadINIStr $1 "$TEMP\completiontime.tmp" "Time" "Value"
	   StrCmp $1 "" error
	 
	# get hours
	StrCpy $3 $1 2 -8 ;get start hour chunk
	StrCpy $2 $0 2 -8 ;get finish hour chunk
	 
	IntCmp $2 $3 0 +3 +6
	 StrCpy $R1 0
	Goto +5
	 IntOp $R1 60 - $3
	 IntOp $R1 $2 + $3
	Goto +2
	 IntOp $R1 $2 - $3
	 
	# get minutes
	StrCpy $3 $1 2 -5 ;get start minutes chunk
	StrCpy $2 $0 2 -5 ;get finish minutes chunk
	 
	IntCmp $2 $3 0 +3 +6
	 StrCpy $R2 0
	Goto +5
	 IntOp $R2 60 - $3
	 IntOp $R2 $2 + $3
	Goto +2
	 IntOp $R2 $2 - $3
	 
	# get seconds
	StrCpy $3 $1 2 -2 ;get start seconds chunk
	StrCpy $2 $0 2 -2 ;get finish seconds chunk
	 
	IntCmp $2 $3 0 +3 +6
	 StrCpy $R3 0
	Goto +5
	 IntOp $R3 60 - $3
	 IntOp $R3 $2 + $3
	Goto +2
	 IntOp $R3 $2 - $3
	 
	# check times
	StrCmp $R0 1 0 +6
	 IntOp $R1 $R1 * 60 ;convert to minutes
	 IntOp $R2 $R2 + $R1 ;add to minutes
	 IntOp $R2 $R2 * 60 ;convert to seconds
	 IntOp $R3 $R3 + $R2 ;add to seconds
	Goto +4
	 
	StrCmp $R0 2 0 +3
	 IntOp $R1 $R1 * 60 ;convert to minutes
	 IntOp $R2 $R2 + $R1 ;add to minutes
	 
	# do hours
	StrCmp $R0 2 skip_hours
	StrCmp $R0 1 skip_hours
	IntCmp $R1 0 +6 0 0
	IntCmp $R1 1 0 +3 +3
	 StrCpy $R1 "$R1 hour, "
	Goto +4
	 StrCpy $R1 "$R1 hours, "
	Goto +2
	skip_hours:
	 StrCpy $R1 ""
	 
	# do minutes
	StrCmp $R0 1 skip_minutes
	IntCmp $R2 0 +6 0 0
	IntCmp $R2 1 0 +3 +3
	 StrCpy $R2 "$R2 minute, "
	Goto +4
	 StrCpy $R2 "$R2 minutes, "
	Goto +2
	skip_minutes:
	 StrCpy $R2 ""
	 
	# do seconds
	IntCmp $R3 0 +6 0 0
	IntCmp $R3 1 0 +3 +3
	 StrCpy $R3 "$R3 second. "
	Goto +4
	 StrCpy $R3 "$R3 seconds. "
	Goto +2
	 StrCpy $R3 ""
	 
	StrCpy $0 "$R1$R2$R3"
	 
	Goto done
	 
	error:
	StrCpy $0 "Error: No installation start time found!"
	 
	done:
	SetDetailsPrint none
	 IfFileExists "$TEMP\completiontime.tmp" 0 +2
	  Delete "$TEMP\completiontime.tmp"
	SetDetailsPrint both
	 
	done2:
	 Push $0 ;backup old string
	System::Call '*(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) i .r1'
	System::Call 'kernel32::GetLocalTime(i) i(r1)'
	System::Call '*$1(&i2, &i2, &i2, &i2, &i2, &i2, &i2, &i2) \
	(,,,, .r3, .r2, .r1,)'
	  StrLen $4 $1
	  StrCmp $4 1 0 +2
	   StrCpy $1 0$1
	  StrLen $4 $2
	  StrCmp $4 1 0 +2
	   StrCpy $2 0$2
	  StrLen $4 $3
	  StrCmp $4 1 0 +2
	   StrCpy $3 0$3
	 StrCpy $1 "$3:$2:$1"
	 Pop $0 ;restore backup
	 
	Pop $R3
	Pop $R2
	Pop $R1
	Pop $R0
	Pop $4
	Pop $3
	Pop $2
	Exch $1 ;current time (start and finish)
	Exch
	Exch $0 ;current time (start) or completion time (finish)
FunctionEnd

Function Today
  System::Alloc 128
  Pop $0
  System::Call "Kernel32::GetSystemTime(i) v (r0)"
  System::Call "*$0(&i2 .r1, &i2 .r2, &i2 .r3, &i2 .r4, &i2 .r5, &i2 .r6, &i2 .r7, &i2 .r8)"
  System::Free $0
 
  Push $1
  Push $2
  Push $4
FunctionEnd
