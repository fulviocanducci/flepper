![Flepper Logo](https://s26.postimg.org/u1hn213qh/frog_128.png)


| Branch  | status(windows) | status(unix) | coverage
| ------- | ------ | ------ |------ |
| Master | [![Build status](https://ci.appveyor.com/api/projects/status/81gjbxxtwit9uqkx/branch/master?svg=true)](https://ci.appveyor.com/project/AlbertoMonteiro/flepper/branch/master) | ![](https://travis-ci.org/nicolastakashi/flepper.svg?branch=master) | [![Coverage Status](https://coveralls.io/repos/github/nicolastakashi/flepper/badge.svg?branch=master)](https://coveralls.io/github/nicolastakashi/flepper?branch=master) 
| Development | [![Build status](https://ci.appveyor.com/api/projects/status/81gjbxxtwit9uqkx/branch/development?svg=true)](https://ci.appveyor.com/project/AlbertoMonteiro/flepper/branch/development) | ![](https://travis-ci.org/nicolastakashi/flepper.svg?branch=development)  | [![Coverage Status](https://coveralls.io/repos/github/nicolastakashi/flepper/badge.svg?branch=development)](https://coveralls.io/github/nicolastakashi/flepper?branch=development) 

# Flepper
> A SQL query builder that is flexible and fun to use!

Flepper is a library to facilitate some database interactions that we need to perform in our applications.
The initial idea of Flepper is to provide a query builder for writing SQL queries fluently, improving the readability of your code.

## Installing / Getting started

A quick introduction of the minimal setup you need to get a hello world up &
running.

Package Manager
```shell
Install-Package Flepper
```
.NET CLI
```shell
dotnet add package Flepper
```

After executing one of the commands above you will have the Flepper installed and ready to be used.

### More about

Access [Wiki](https://github.com/nicolastakashi/flepper/wiki/Get-Started#creating-queries) to learn more.

## Developing

Here's a brief intro about what a developer must do in order to start developing
the project further:

```shell
git clone https://github.com/nicolastakashi/flepper
cd flepper/
dotnet restore
dotnet build
```

## Features
Functionality implemented
* Query Builder

### Database support
Currently supported databases
* MSSQL 2008 or greater

## Contributing

Hey, are you in the mood to contribute to Flepper? Then take a look at our file where it explains how to [contribute](https://github.com/nicolastakashi/flepper/blob/contributing-md/CONTRIBUTING.md) and we love receiving feedback and pull requests.

## Licensing
"The code in this project is licensed under [MIT] license."

[MIT]:<https://github.com/nicolastakashi/flepper/blob/master/LICENSE>
