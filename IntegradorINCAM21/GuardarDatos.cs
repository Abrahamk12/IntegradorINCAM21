using System.Data.SQLite;
namespace IntegradorINCAM21
{
    internal class GuardarDatos
    {
        private string datos = "";
        public string dbPath = Path.Combine(Environment.CurrentDirectory, "Integrador.sqlite");
        public GuardarDatos()
        {

        }
        public void crearBD()
        {
            // Verificar si el archivo de la base de datos ya existe
            if (!File.Exists(dbPath))
            {
                // Si no existe, crear la base de datos
                SQLiteConnection.CreateFile(dbPath);
                Console.WriteLine("¡Base de datos creada!");

                // Crear una tabla inicial en la base de datos
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string createTableQuery = "CREATE TABLE IF NOT EXISTS tornillos (Id INTEGER PRIMARY KEY, Largo TEXT," +
                        " Ancho TEXT, Grosor TEXT, Diametro TEXT, Tipo_tornillo TEXT, Herramienta TEXT)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Tabla creada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Console.WriteLine("La base de datos ya existe.");
            }
        }

        public void guardarDatos(string Largo, string Ancho, string Grosor,
                                    string Diametro, string Tipo_tornillo, string Herramienta)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                string insertQuery = "INSERT INTO tornillos (Largo, Ancho, Grosor, Diametro, Tipo_tornillo, Herramienta) " +
                                     "VALUES (@Largo, @Ancho, @Grosor, @Diametro, @Tipo_tornillo, @Herramienta)";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Asignar valores a los parámetros para evitar errores de formato
                    command.Parameters.AddWithValue("@Largo", Largo);
                    command.Parameters.AddWithValue("@Ancho", Ancho);
                    command.Parameters.AddWithValue("@Grosor", Grosor);
                    command.Parameters.AddWithValue("@Diametro", Diametro);
                    command.Parameters.AddWithValue("@Tipo_tornillo", Tipo_tornillo);
                    command.Parameters.AddWithValue("@Herramienta", Herramienta);

                    command.ExecuteNonQuery(); // Ejecutar la consulta
                    //Console.WriteLine("Datos guardados satisfactoriamente.");
                    //MessageBox.Show("Datos guardados satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public string mostrarDatos()
        {

            if (File.Exists(dbPath)) // Verificar existencia del archivo
            {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    // Validar existencia de la tabla
                    string checkTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='tornillos';";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkTableQuery, connection))
                    {
                        if (checkCommand.ExecuteScalar() == null)
                        {
                            MessageBox.Show($"La tabla 'tornillos' no existe.  BRUH", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Ejecutar la consulta SELECT
                    string selectQuery = "SELECT Largo, Ancho, Grosor, Diametro, Tipo_tornillo, Herramienta FROM tornillos";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                datos += $"Largo: {reader["Largo"]}, Ancho: {reader["Ancho"]}, " +
                                    $"Grosor: {reader["Grosor"]}, Diametro: {reader["Diametro"]}, " +
                                    $"Tipo de Tornillo: {reader["Tipo_tornillo"]}, " +
                                    $"Herramienta: {reader["Herramienta"]}\n";
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encuentra el archivo de la base de datos.");
                return "Archivo no encontrado.";
            }

            //MessageBox.Show(datos, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return datos;
        }

    }
}