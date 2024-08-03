using CP_1;
using static CP_1.Program;

namespace CP_1
{
    public partial class Form1 : Form
    {
        // Масив об'єктів
        private Schedule_Nod[] schedule =
        {
            new Schedule_Nod(true, 123, "Monday"),
            new Schedule_Nod(true, 456, "Tuesday"),
            new Schedule_Nod(false, 789, "Wednesday"),
            new Schedule_Nod(true, 101, "Thursday")
        };

        private UserTickets userTickets = new UserTickets();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Додаємо обробник події для кнопки
            showDataButton.Click += ShowDataButton_Click;

            // Відображаємо тип користувача
            userTypeLabel.Text = $"Користувач: {LoginForm.UserType}";

            // Якщо користувач - Пасажир, додаємо кнопку "Придбати квиток"
            if (LoginForm.UserType == "Пасажир")
            {
                Button buyTicketButton = new Button();
                buyTicketButton.Text = "Придбати квиток";
                buyTicketButton.Location = new System.Drawing.Point(12, 480);
                buyTicketButton.Click += BuyTicketButton_Click;
                this.Controls.Add(buyTicketButton);

                // Додаємо кнопку "Мої квитки"
                Button myTicketsButton = new Button();
                myTicketsButton.Text = "Мої квитки";
                myTicketsButton.Location = new System.Drawing.Point(150, 480);
                myTicketsButton.Click += MyTicketsButton_Click;
                myTicketsButton.Visible = false; // Спочатку невидима
                this.Controls.Add(myTicketsButton);
            }
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            TicketPurchaseForm purchaseForm = new TicketPurchaseForm(schedule);
            if (purchaseForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо придбаний квиток до користувацьких квитків
                userTickets.AddTicket(purchaseForm.SelectedDay, purchaseForm.SelectedTrainNumber);

                // Робимо кнопку "Мої квитки" видимою
                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button.Text == "Мої квитки")
                    {
                        button.Visible = true;
                        break;
                    }
                }

                MessageBox.Show("Квиток придбано успішно.");
            }
        }

        private void MyTicketsButton_Click(object sender, EventArgs e)
        {
            // Відображаємо квитки користувача
            string ticketsInfo = userTickets.GetTicketsInfo();
            MessageBox.Show(ticketsInfo, "Мої квитки");
        }

        // Обробник події натискання на кнопку
        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            // Очищуємо ListBox перед додаванням нових даних
            dataListBox.Items.Clear();

            // Додаємо дані з масиву до ListBox
            for (int i = 0; i < schedule.Length; i++)
            {
                var scheduleNode = schedule[i];
                dataListBox.Items.Add($"№{i + 1}: Train Today: {scheduleNode.IsTrainToday}, Train Number: {scheduleNode.TrainNumber}, Day: {scheduleNode.Destination}");
            }
        }
    }

    public class Schedule_Nod
    {
        public bool IsTrainToday { get; set; }
        public int TrainNumber { get; set; }
        public string Destination { get; set; }

        public Schedule_Nod(bool isTrainToday, int trainNumber, string destination)
        {
            IsTrainToday = isTrainToday;
            TrainNumber = trainNumber;
            Destination = destination;
        }
        public Schedule_Nod()
        {
            IsTrainToday = false;
            TrainNumber = -1;
            Destination = "final";
        }
    }
    // Клас для зберігання квитків користувача
    public class UserTickets
    {
        private List<(string day, string trainNumber)> tickets = new List<(string day, string trainNumber)>();

        public void AddTicket(string day, string trainNumber)
        {
            tickets.Add((day, trainNumber));
        }

        public string GetTicketsInfo()
        {
            if (tickets.Count == 0)
            {
                return "У вас немає придбаних квитків.";
            }

            string info = "Ваші квитки:\n";
            foreach (var ticket in tickets)
            {
                info += $"День: {ticket.day}, Номер потягу: {ticket.trainNumber}\n";
            }
            return info;
        }
    }
}