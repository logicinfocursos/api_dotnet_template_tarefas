migration

Add-Migration InitialDb -Context SistemaTarefasDBContex
Update-Database -Context SistemaTarefasDBContex


"DataBase": "Server=./;Database=DB_SistemaTarefas;User Id=sa;Password=123"

Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False