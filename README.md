# NetDb2Example

<!-- TABLE OF CONTENTS -->
## Table of Contents

- [NetDb2Example](#netdb2example)
  - [Table of Contents](#table-of-contents)
  - [About The Project](#about-the-project)
    - [Built With](#built-with)
  - [Getting Started](#getting-started)
    - [IBM DB2 Client](#ibm-db2-client)
    - [IBM Windows Groups & Execution Permissions](#ibm-windows-groups--execution-permissions)
  - [Connection Methods](#connection-methods)
    - [Microsoft Open Database Connectivity (ODBC)](#microsoft-open-database-connectivity-odbc)
    - [IBM.Data.DB2](#ibmdatadb2)
  - [Data Clients](#data-clients)
    - [Visual Studio Add-in](#visual-studio-add-in)
    - [IBM DB2 Data Studio](#ibm-db2-data-studio)
  - [IIS Configuration](#iis-configuration)
  - [Contributing](#contributing)
  - [License](#license)
  - [Contact](#contact)

<!-- ABOUT THE PROJECT -->
## About The Project

This is an example for how to connect to and use an IBM DB2 database with the .Net Framework.  Went through a lot of pain figuring out the quirks/nuances of DB2 in a Windows .Net environment...so I put this sample project together to hopefully help you avoid most of the pain.  This project does not outline how to set up a DB2 database, only how to connect and consume it's data.  
> Disclaimer: I do not reccomend using IBM DB2 if you are working in a Windows environment...use only if required.

### Built With

- [Microsoft Open Database Connectivity (ODBC)](https://docs.microsoft.com/en-us/sql/odbc/microsoft-open-database-connectivity-odbc?view=sql-server-ver15)
- [Ibm.Data.DB2](https://www.nuget.org/packages/IBM.Data.DB2/10.0.5.5?_src=template)
- [CSharp MVC Web Api](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

<!-- GETTING STARTED -->
## Getting Started

### IBM DB2 Client

An IBM DB2 client must be installed on the host machine.  Get install files from IBM or your IT administrator.  Follow the prompts in the wizard leave the defaults.  I also recommend installing the Visual Studio Plugin for data viewing (just check the box on install).

### IBM Windows Groups & Execution Permissions

After installing the client, you will notice two new Windows groups. You have to add users to the DB2ADMNS or DB2USERS groups that will execute local DB2 applications and tools on the host machine.

1. Open Local Users and Groups
```console
lusrmgr.msc
```
2. Select Groups folder
3. Add users who will be executing DB2 command to the DB2ADMNS or DB2USERS groups

## Connection Methods

### Microsoft Open Database Connectivity (ODBC)

This method is the easiest to set up, though is slower with query execution.  This is to be expected since it is a generic database driver.  No extra Nuget packages are required with this route.  The only real differences are in the connection string and the classes used when querying the database.

### IBM.Data.DB2

This method is more difficult to set up, though is faster with query execution once configured correctly.

## Data Clients

### Visual Studio Add-in

The Visual Studio Add-in can be included in the install of the IBM DB2 Client.  Just be sure to check the box.  After installing the add-in and restarting Visual Studio, you should be able to use the Server Explorer (Ctrl-Alt-S) to connect to an IBM DB2 Database instance.

### IBM DB2 Data Studio

IBM DB2 Data Studio is IBM's take on SQL Server Management Studio (SSMS).  It's built in a gutted version of the Eclipse IDE.  It works...it's just clunky.  You can download and install it from [IBM's site.](https://www.ibm.com/products/ibm-data-studio)

## IIS Configuration

The only real thing you will need to do is give your ApplicationPoolIdentity access to one of the DB2 Windows groups.  This can be an account you specify, or the default IIS ApplicationPoolIdentity (ex. IISAppPool\DefaultAppPool)

<!-- CONTRIBUTING -->
## Contributing

If you'd like to contribute or help me add more examples, I encourage it!  Please fork the project and make your changes.  I'd love to see see/merge them with mine.  See the [open issues](https://github.com/cmilius/NetDb2Example/issues) for a list of proposed features (and known issues).

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

Project Link: [https://github.com/cmilius/NetDb2Example](https://github.com/cmilius/NetDb2Example)
