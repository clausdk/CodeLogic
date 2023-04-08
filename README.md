# Codelogic

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Build Status](https://travis-ci.com/your_username/repo_name.svg?branch=main)](https://travis-ci.com/your_username/repo_name)
[![Coverage Status](https://coveralls.io/repos/github/your_username/repo_name/badge.svg?branch=main)](https://coveralls.io/github/your_username/repo_name?branch=main)

`Codelogic` is a .NET 6 framework for developing applications that includes a set of common functionality that can be reused across different projects.

## Functionality

The `Codelogic` framework includes the following functionality:

### Configuration

The `ConfigurationManager` class provides a simple and consistent way to read and write configuration files for both `Codelogic` extensions and applications that use the framework. Configuration files are stored in the `Storage/Configs` directory in JSON format, with the file name being the name of the extension. The `ConfigurationManager` also provides the ability to initialize default configuration values on application startup.

### Extensions

The `ExtensionManager` class provides a way to manage `Codelogic` extensions. Extensions are loaded as separate DLL files in the `Extensions` directory, and the `ExtensionManager` provides a way to load and unload extensions, as well as access their functionality.

### Logging

The `Logger` class provides a simple way to log messages to files. Log files are stored in the `Storage/Logs` directory, with separate log files for each extension and a main `Codelogic.log` file that contains all log messages.

### Utilities

The `Utils` folder contains various utility classes for common tasks such as file handling, networking, encryption, serialization, and string manipulation. By organizing your utility functions into subfolders like this, you can keep related functions together and make it easier to find and use the specific functionality you need.

## Contributing

Contributions to `Codelogic` are welcome! If you find a bug or want to suggest a new feature, please open an issue on the GitHub repository. If you want to contribute code, please fork the repository, create a new branch for your changes, and submit a pull request.
