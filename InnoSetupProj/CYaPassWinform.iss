; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9CB16870-C5EB-45BD-BD2E-0F6FFC1D0F55}
AppName=CYaPass
AppVersion=1.1.0
;AppVerName=CYaPass 1.0.0
AppPublisher=100 Percent Accountability, LLC
AppPublisherURL=http://www.cyapass.com
AppSupportURL=http://www.cyapass.com
AppUpdatesURL=http://www.cyapass.com
DefaultDirName={pf}\CYaPass
DisableProgramGroupPage=yes
LicenseFile=C:\Users\roger.deutsch\Dev\WinForm\CYaPass\cyapassLicense.txt
OutputDir=C:\Users\roger.deutsch\Dev\WinForm\CYaPass\InnoSetupProj
OutputBaseFilename=CYaPassInstall
SetupIconFile=C:\Users\roger.deutsch\Dev\WinForm\CYaPass\CYaPass\CYaPass.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\roger.deutsch\Dev\WinForm\CYaPass\CYaPass\bin\Release\CYaPass.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\roger.deutsch\Dev\WinForm\CYaPass\CYaPass\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\CYaPass"; Filename: "{app}\CYaPass.exe"
Name: "{commondesktop}\CYaPass"; Filename: "{app}\CYaPass.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\CYaPass.exe"; Description: "{cm:LaunchProgram,CYaPass}"; Flags: nowait postinstall skipifsilent

