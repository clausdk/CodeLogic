Codelogic
Codelogic is a .NET 6 framework for developing applications that includes a set of common functionality that can be reused across different projects.

Folder Structure
The Codelogic framework follows a recommended folder structure to make it easy to organize and find your files. The recommended folder structure is as follows:

css
Copy code
Codelogic/
├── src/
│   ├── Codelogic/
│   │   ├── Codelogic.csproj
│   │   ├── Configuration/
│   │   │   ├── ConfigurationManager.cs
│   │   │   └── ...
│   │   ├── Extensions/
│   │   │   ├── ExtensionManager.cs
│   │   │   └── ...
│   │   ├── Logging/
│   │   │   ├── Logger.cs
│   │   │   └── ...
│   │   ├── Utils/
│   │   │   ├── Encryption/
│   │   │   │   ├── AesEncryption.cs
│   │   │   │   └── ...
│   │   │   ├── FileHandling/
│   │   │   │   ├── FileUtils.cs
│   │   │   │   └── ...
│   │   │   ├── Networking/
│   │   │   │   ├── HttpUtils.cs
│   │   │   │   └── ...
│   │   │   ├── Serialization/
│   │   │   │   ├── JsonSerializer.cs
│   │   │   │   └── ...
│   │   │   ├── StringUtils/
│   │   │   │   ├── StringUtils.cs
│   │   │   │   ├── StringValidator.cs
│   │   │   │   └── ...
│   │   │   └── ...
│   │   └── ...
│   └── Codelogic.SampleExtension/
│       ├── Codelogic.SampleExtension.csproj
│       ├── Models/
│       │   ├── SampleConfig.cs
│       │   └── ...
│       ├── SampleExtension/
│       │   ├── SampleExtension.cs
│       │   └── ...
│       └── ...
└── ...
This folder structure includes separate subfolders for different types of functionality, such as configuration, extensions, logging, and utilities. Within each subfolder, you can organize your files as needed.

Functionality
The Codelogic framework includes the following functionality:

Configuration
The ConfigurationManager class provides a simple and consistent way to read and write configuration files for both Codelogic extensions and applications that use the framework. Configuration files are stored in the Storage/Configs directory in JSON format, with the file name being the name of the extension. The ConfigurationManager also provides the ability to initialize default configuration values on application startup.

Extensions
The ExtensionManager class provides a way to manage Codelogic extensions. Extensions are loaded as separate DLL files in the Extensions directory, and the ExtensionManager provides a way to load and unload extensions, as well as access their functionality.

Logging
The Logger class provides a simple way to log messages to files. Log files are stored in the Storage/Logs directory, with separate log files for each extension and a main Codelogic.log file that contains all log messages.

Utilities
The Utils folder contains various utility classes for common tasks such as file handling, networking,
