
Probleem

.NET MAUI mobiilirakenduse arendamisel on vaikimisi sätted seadistatud nii, et projekti debugimisel/käivitamisel installitakse kasutaja alla kompileeritud Windows store app mistõttu käivitub õpilase kontole rakendatud Software Restriction Policy ning keelab antud tegevuse.

Lahendus

1. Installida NuGet pakk, kirjutades järgmine rida Package Manager Console: NuGet\Install-Package Microsoft.UI.Xaml -Version 2.8.2.
2. Valida menüüreast Project → Properties → Build → Output ning muuta Base output path C:\Users\opilane\projects\OmaProjektiNimi .
3. Solution Explorerist ava projekti C# leht, ning sektsioon Versions alla kirjutada järgmine rida: <WindowsPackageType Condition=“$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'”>None</WindowsPackageType>.
4. Ava MauiProgram.cs ning kontrolli, et üleval vasakus nurgas oleks valitud MauiApp2 (Net6.0-windows10.0.19.041.0). Antud valikus võivad numbrid erineda, vastavalt frameworki versioonile aga oluline on see, et oleks valikus mainitud windows.
5. Teha projektile Clean Solution, Rebuild Solution, Build Solution ning käivitada projekt.
6. Antud olukorras projekt läbi Visual Studio tööle ei lähe, vaid see kompileeritakse Base output Pathi .exe failina: C:\Users\opilane\projects\OmaProjektiNimi\Debug\net6.0-windows10.0.19.041.0\Win10-x64\AppiNimi.exe.
7. Käivitada eelnevas punktis mainitud asukohas olev exe fail. App avaneb.

Alternatiivne lahendus

1. Avada võrgukataloogist virtuaalmasina image \\tthk.ee\home\ITOPE\VM_Base_Images\Windows\Windows_10_Pro_Visual_Studio_inc.ova.
2. Avaneb VirtualBox ning vajutades Finish nuppu, alustatakse image importimisega, mis võtab ligikaudu 10 minutit aega.
3. Pärast importimist käivitada virtuaalmasin.
4. Nüüd on võimalus ehitada oma projekt üles antud virtuaalmasinas, või saab kasutada seda ainult oma projekti testimiseks.
5. Ainult testimiseks võib arvutist Drag & Droppida oma Visual Studio projektikaust Virutaalmasinasse ning käivitada projekt sealt.
6. Juhul kui Drag & Drop ei tööta, siis tuleb minna Virtuaalmasinas My Computer alla ning käivitada: CD-draiv (D:) VirtualBox Guest Additions\VboxWindowsAdditions.exe. Pärast installi restartida oma virutaalmasin ning katsetada uuesti. Kui endiselt ei tööta, siis tuleks kontrollida Virutaalmasina menüüribas Devices → Drag and Drop → Bidirectional.

Kõige parem variant:
1.
launchSettings.json 

{
  "profiles": {
    "Windows Machine": {
      "commandName": "Project",
      "nativeDebugging": false
    }
  }
}

2. Installida NuGet pakk, kirjutades järgmine rida Package Manager Console: NuGet\Install-Package Microsoft.UI.Xaml -Version 2.8.2.
3. Solution Explorerist ava projekti C# leht, ning sektsioon Versions alla kirjutada järgmine rida: <WindowsPackageType Condition=“$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'”>None</WindowsPackageType>.
Juhend .NET MAUI jaoks.txt
Üksuse Juhend .NET MAUI jaoks.txt kuvamine.
