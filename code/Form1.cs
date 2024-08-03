using CP_1;
using static CP_1.Program;

namespace CP_1
{
    public partial class Form1 : Form
    {
        // ����� ��'����
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
            // ������ �������� ��䳿 ��� ������
            showDataButton.Click += ShowDataButton_Click;

            // ³��������� ��� �����������
            userTypeLabel.Text = $"����������: {LoginForm.UserType}";

            // ���� ���������� - �������, ������ ������ "�������� ������"
            if (LoginForm.UserType == "�������")
            {
                Button buyTicketButton = new Button();
                buyTicketButton.Text = "�������� ������";
                buyTicketButton.Location = new System.Drawing.Point(12, 480);
                buyTicketButton.Click += BuyTicketButton_Click;
                this.Controls.Add(buyTicketButton);

                // ������ ������ "�� ������"
                Button myTicketsButton = new Button();
                myTicketsButton.Text = "�� ������";
                myTicketsButton.Location = new System.Drawing.Point(150, 480);
                myTicketsButton.Click += MyTicketsButton_Click;
                myTicketsButton.Visible = false; // �������� ��������
                this.Controls.Add(myTicketsButton);
            }
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            TicketPurchaseForm purchaseForm = new TicketPurchaseForm(schedule);
            if (purchaseForm.ShowDialog() == DialogResult.OK)
            {
                // ������ ��������� ������ �� �������������� ������
                userTickets.AddTicket(purchaseForm.SelectedDay, purchaseForm.SelectedTrainNumber);

                // ������ ������ "�� ������" �������
                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button.Text == "�� ������")
                    {
                        button.Visible = true;
                        break;
                    }
                }

                MessageBox.Show("������ �������� ������.");
            }
        }

        private void MyTicketsButton_Click(object sender, EventArgs e)
        {
            // ³��������� ������ �����������
            string ticketsInfo = userTickets.GetTicketsInfo();
            MessageBox.Show(ticketsInfo, "�� ������");
        }

        // �������� ��䳿 ���������� �� ������
        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            // ������� ListBox ����� ���������� ����� �����
            dataListBox.Items.Clear();

            // ������ ��� � ������ �� ListBox
            for (int i = 0; i < schedule.Length; i++)
            {
                var scheduleNode = schedule[i];
                dataListBox.Items.Add($"�{i + 1}: Train Today: {scheduleNode.IsTrainToday}, Train Number: {scheduleNode.TrainNumber}, Day: {scheduleNode.Destination}");
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
    // ���� ��� ��������� ������ �����������
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
                return "� ��� ���� ��������� ������.";
            }

            string info = "���� ������:\n";
            foreach (var ticket in tickets)
            {
                info += $"����: {ticket.day}, ����� ������: {ticket.trainNumber}\n";
            }
            return info;
        }
    }
}