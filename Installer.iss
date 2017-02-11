; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EDDI"
#define MyAppVersion "2.2.0"
#define MyAppPublisher "Cmdr McDonald"
#define MyAppURL "https://github.com/cmdrmcdonald/EliteDangerousDataProvider/"
#define MyAppExeName "EDDI.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{830C0324-30D8-423C-B5B4-D7EE8D007A79}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\Program Files (x86)\VoiceAttack\Apps\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename={#MyAppName}-{#MyAppVersion}
Compression=lzma
SolidCompression=yes
WizardImageFile={#SourcePath}\graphics\logo.bmp
WizardSmallImageFile={#SourcePath}\graphics\logo.bmp
UninstallDisplayIcon={app}\EDDI\EDDI.ico
UsePreviousTasks=False
DisableWelcomePage=False
DisableDirPage=no
AllowUNCPath=False

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "{#SourcePath}EDDI\bin\Debug\EDDI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "{#SourcePath}EDDI\bin\Debug\x86\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "{#SourcePath}EDDI\bin\Debug\AsyncIO.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\CommonMark.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Cottle.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\CredentialManagement.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\CSCore.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\eddi.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiCompanionAppService.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiDataDefinitions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiDataProviderService.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiEddnResponder.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiEddpMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiEdsmResponder.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiEvents.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiGalnetMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiJournalMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiNetLogMonitor.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiSpeechResponder.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiSpeechService.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiStarMapService.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Exceptionless.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Exceptionless.Wpf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Help.md"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\MathNet.Numerics.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Microsoft.Expression.Controls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Microsoft.Expression.Drawing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\NetMQ.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\RestSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\SimpleFeedReader.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\System.Data.SQLite.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\System.Data.SQLite.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Utilities.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\Variables.md"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}VoiceAttackResponder\EDDI.vap"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}EDDI\bin\Debug\EddiVoiceAttackResponder.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

; Remove outdated files
[InstallDelete]
Type: files; Name: "{app}\Eddi.exe"
Type: files; Name: "{app}\EDDI.ico"

; Remove sensitive data on uninstall
[UninstallDelete]
Type: files; Name: "{userappdata}\EDDI\credentials.json"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[ThirdParty]
UseRelativePaths=True

[Messages]
SelectDirBrowseLabel=To continue, click Next.  If you have a custom VoiceAttack installation location, or would like to put the EDDI files in a different location, click Browse.