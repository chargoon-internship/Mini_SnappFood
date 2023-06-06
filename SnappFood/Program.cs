namespace SnappFood
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new EditandAddMenu());
<<<<<<< HEAD
=======

            Application.Run(new RestaurantPanel());

            //Application.Run(new Login());

            //Application.Run(new CustomerInvoice());
>>>>>>> 518efb6ec66570b464bc989564284bcf8675e7ee

            Application.Run(new RestaurantPanel());

            //Application.Run(new Login());

            //Application.Run(new CustomerInvoice());
        }
    }
}