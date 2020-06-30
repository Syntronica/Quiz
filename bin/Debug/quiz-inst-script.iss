; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Quiz"
#define MyAppVersion "1.5"
#define MyAppPublisher "Dietmar Schneidewind"
#define MyAppURL "https://www.d-sch.com"
#define MyAppExeName "Quiz.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{62DA012A-B6F9-437C-9EA1-7D28F79F788A}
ArchitecturesInstallIn64BitMode=X64
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}

AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\lizenz.txt
InfoBeforeFile=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\liesmich.txt
InfoAfterFile=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\machher.txt
WizardSmallImageFile=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\klein.bmp
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\installation
OutputBaseFilename=quiz-setup
SetupIconFile=C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\fotowand-wir.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
MinVersion=10.0.18363	

[Languages]
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
;Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\AccessDatabaseEngine_X64.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\Quiz.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\Quiz.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\Quiz.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\Quiz.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\Quiz.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Dietmar\source\repos\Quiz\Quiz\bin\Debug\quiz_db.accdb"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
;Filename: "{app}\AccessDatabaseEngine_X64.exe"; 
;Parameters: "/quiet"
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

