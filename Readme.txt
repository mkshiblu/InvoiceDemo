Fix Code First Migrations error
--------------------------------
1. Open Package Manager Console from Tools-> Library Package Manager
2. Enter the command 
	Enable-Migrations
3. Then 
	Update-Database –Verbose

Note: Sometimes running Update-Database –Verbose is enough