using structa_front.Services;

namespace structa_front
{
    public static class ServiceProvider
    {
        public static DatabaseService? Database { get; private set; }

        public static async Task InitializeServices()
        {
            Database = new DatabaseService();
            await Database.InicializarAsync();
        }
    }
}
