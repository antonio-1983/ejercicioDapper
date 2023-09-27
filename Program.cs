

using Dapper;
using EjercicioDapper;
using MySql.Data.MySqlClient;


string connection = @"Server=localhost; Database=ejercicioDapper; Uid=root;";


using (var db = new MySqlConnection(connection))
{
    var sql = "select Id,Nombre from Usuarios";
    var sqlId = "select Id, Nombre, Edad from Usuarios where Id = @Id;";
    var result2 = db.QueryFirstOrDefault<Usuario>(sqlId, new { Id = 1 });
    var result = db.Query<Usuario>(sql);

    Console.WriteLine("Lista de usuarios");
    foreach (var usuario in result)
    {
        Console.WriteLine(usuario.Id + " " + usuario.Nombre + " " + usuario.Edad);
    }
    Console.WriteLine("*********************");
   
    Console.WriteLine("Usuario 1");
    Console.WriteLine(result2.Id+" "+result2.Edad+" "+result2.Nombre);
}


