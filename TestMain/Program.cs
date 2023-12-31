using CG.Web.MegaApiClient;
namespace LCMedalpatcher
{
    internal class Patcher
    {
        [STAThread]
        public static void Main()
        {
            MegaApiClient MyClient = new();


            try
            {
                MyClient.LoginAnonymous();

                Console.WriteLine(MyClient.IsLoggedIn);
                Console.WriteLine(MyClient.IsLoggedIn.GetType().ToString());

            }
            catch (Exception ex)


            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                MyClient.Login();

                Console.WriteLine(MyClient.IsLoggedIn);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            Console.Write("\t\tPress Any Key to leave...\n");
            Console.ReadKey();
        }
    }
}