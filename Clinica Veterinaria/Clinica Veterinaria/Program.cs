namespace Clinica_Veterinaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuraci�n inicial de la aplicaci�n
            ApplicationConfiguration.Initialize();

            // Crear instancia de Form1
            Form1 mainForm = new Form1();

            // Mostrar Form1
            mainForm.Show();

            // Reducir la opacidad de Form1
            mainForm.Opacity = 0.9; // Ajustar opacidad para oscurecer

            // Crear instancia de FormLogin
            FormLogin loginForm = new FormLogin
            {
                TopMost = true // Asegurar que siempre est� encima
            };

            // Mostrar FormLogin
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Restaurar la opacidad de Form1 si el login es exitoso
                mainForm.Opacity = 1.0;
                Application.Run(mainForm); // Ejecutar la aplicaci�n principal
            }
            else
            {
                // Cerrar la aplicaci�n si el login falla o se cancela
                mainForm.Close();
                Application.Exit();
            }
        }
    }
}

