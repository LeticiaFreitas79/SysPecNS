using SysPecNSLib;

namespace SysPecNSDesk
{
    internal static class Program
    {
        public static Usuario UsuarioLogado = new(); //Propriedade estatica do tipo usu�rio.
        //uma classe est�tica s� pode ter membros est�ticos.

    
        ///  The main entry point for the application.   
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }
    }
}