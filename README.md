## Create Project

dotnet new console --output myProject 
dotnet run --project myProject
dotnet build
dotnet run
dotnet build -c Realease -r win10-x64 

##structure of a cs file

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