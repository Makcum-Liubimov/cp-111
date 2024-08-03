using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CP_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // [STAThread]
        


        public class User
        {
            public string userName {  get; set; }
            public string passWord { get; set; }
            public User(string username, string password)
            {
                userName = username;
                passWord = password;
            }
        }

        public class  Admin :User 
        {
            public bool hasAdminRights = true;
            public Admin(string username, string password): base(username, password) { }

            //public void setSchedule(int day, Schedule_Nod[] month, int numberOfTrain)
            //{
                //month[day].DoesTrainCome = true;
                //month[day].NumberOfTrain = numberOfTrain;
                //month[day].NumberOfFreeSeats = 30;
            //}
        }

        public class Passanger :User
        {
            public bool hasAdminRights = false;
            public bool hasTicket;
            public int[] tickets = new int[0];
            public Passanger (string username, string password) : base(username, password) { }

           // public void buyTicket(int day,Schedule_Nod[] month, int numberOfTrain) 
           // {
               
            //}
            public void returnTicket(int day) { }

            public void seeSchedule(int month) { }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}