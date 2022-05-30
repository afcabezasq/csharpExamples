# CSharp

## Create Project

```powershell
	dotnet new console --output myProject 
```

## Run a project

```powershell
dotnet run --project myProject
```

## Build a project

```powershell
dotnet build
```
## Run a project

```powershell
dotnet run
```

## Generate windows executable

```powershell
dotnet build -c Realease -r win10-x64 
```


## Structure of a cs file

```c#
namespace MyFirstProject
{
	class Program
	{
		static void Main(string[] args)
		{
			return;
		} 
	}


}

```