namespace structa_front
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Executa async antes de abrir a UI
            ServiceProvider.InitializeServices()
                           .GetAwaiter()
                           .GetResult();

            Application.Run(new CriarConta());
        }
    }
}
