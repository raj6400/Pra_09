# Pra_09 – ASP.NET Web Forms Practical

## Overview
Pra_09 is an ASP.NET Web Forms application built with C# and the .NET Framework. It demonstrates a multi-page website using ASPX pages, code-behind files, shared master pages, and application configuration.

## Features
- Multiple pages, including **About**, **Company Details**, **Contact**, and **Default/Home**.
- ASP.NET Web Forms pages (`.aspx`) with C# code-behind files (`.aspx.cs`).
- Shared layout using master pages (`Site.Master` and `Site.Mobile.Master`).
- Application-level configuration through `Web.config`.
- Project settings and assembly information in the `Properties` folder.
- Package configuration through `packages.config`.

## Technologies Used
- **Language:** C#
- **Framework:** ASP.NET Web Forms
- **Frontend:** ASPX, HTML, CSS, JavaScript
- **Configuration:** Web.config
- **Project type:** .NET Framework web application

## Project Structure
```text
Pra_09/
├── App_Start/
├── Content/
├── Properties/
│   ├── AssemblyInfo.cs
│   └── Scripts/
├── About.aspx
├── About.aspx.cs
├── CompanyDetails.aspx
├── CompanyDetails.aspx.cs
├── Contact.aspx
├── Contact.aspx.cs
├── Default.aspx
├── Global.asax
├── Global.asax.cs
├── Site.Master
├── Site.Master.cs
├── Site.Mobile.Master
├── Site.Mobile.Master.cs
├── ViewSwitcher.ascx
├── Web.config
├── Web.Debug.config
├── Web.Release.config
├── Pra_9.csproj
├── packages.config
└── Pra_9.slnx
```

> The exact files and folders may vary slightly depending on the version of the project.

## Requirements
- Windows
- Visual Studio with the **ASP.NET and web development** workload
- A compatible .NET Framework Developer Pack/Targeting Pack for the project
- NuGet package restore enabled

## How to Run
1. Clone or download this repository.
2. Open `Pra_9.slnx` in a compatible version of Visual Studio. If your Visual Studio version does not support `.slnx`, open `Pra_9.csproj` instead.
3. Allow NuGet packages to restore.
4. In Solution Explorer, right-click the `Pra_9` web project and select **Set as Startup Project**, if needed.
5. Press **F5** to run with debugging, or **Ctrl + F5** to run without debugging.
6. The website should open in the configured browser using the development server selected by Visual Studio.

## Main Pages
| Page | Purpose |
|---|---|
| `Default.aspx` | Home/default page |
| `About.aspx` | About page |
| `CompanyDetails.aspx` | Company details page |
| `Contact.aspx` | Contact page |

## Configuration Notes
- Check `Web.config` for application settings and connection strings.
- Do not commit passwords, API keys, or other secrets to a public repository.
- The `packages/` directory may be restored by NuGet; avoid committing generated build output such as `bin/` and `obj/` unless your course specifically requires it.

## Author
Student practical project – update this section with your name, university, and semester if required.

## License
This project is provided for educational and practical-learning purposes. Add a specific license if you intend to distribute or reuse the code publicly.
