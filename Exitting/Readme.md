# Exiting from a Dotnet Application

Use "Environment.Exit(code);" for exit dotnet application.

## Exiting Types

There are 2 main exiting types. One for success and other for failed scenerios.

### Successfully Exiting

```c#
Environment.Exit(0);
```

### Failed Exiting

```c#
Environment.Exit(1);
```

## Running Project

Successfully exiting:
```sh
dotnet run 0 || echo "Failed"
```

Failed exiting:
```sh
dotnet run 1 || echo "Failed"
```