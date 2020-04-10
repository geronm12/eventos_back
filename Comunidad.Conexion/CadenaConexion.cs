namespace Comunidad.Conexion
{
    public static class CadenaConexion
    {
        private const string Servidor = @"DESKTOP-54CPJDQ\DBSQL";
        private const string BaseDatos ="Evento1";
        private const string Usuario = "";
        private const string Password = "";

        public static string ObtenerCadenaConexionSql => $"Data Source={Servidor}; " +
                                                      $"Initial Catalog={BaseDatos}; " +
                                                      $"User Id={Usuario}; " +
                                                      $"Password={Password};";
        public static string ObtenerCadenaConexionWin => $"Data Source={Servidor}; " +
                                                      $"Initial Catalog={BaseDatos}; " +
                                                      $"Integrated Security = true";
    }
}
