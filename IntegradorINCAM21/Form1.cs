namespace IntegradorINCAM21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string dbPath = "TuBaseDeDatos.sqlite"; // Ruta de tu base de datos

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
                    string createTableQuery = "CREATE TABLE IF NOT EXISTS Usuarios (Id INTEGER PRIMARY KEY, Nombre TEXT)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("¡Tabla creada!");
                    }
                }
            }
            else
            {
                Console.WriteLine("La base de datos ya existe.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
