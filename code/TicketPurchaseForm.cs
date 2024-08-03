using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CP_1.Program;

namespace CP_1
{
    public partial class TicketPurchaseForm : Form
    {
        public string SelectedDay { get; private set; }
        public string SelectedTrainNumber { get; private set; }

        public TicketPurchaseForm(Schedule_Nod[] schedule)
        {
            InitializeComponent();

            // Заповнюємо ComboBox днями з розкладу
            foreach (var scheduleNode in schedule)
            {
                if (scheduleNode.IsTrainToday)
                {
                    daysComboBox.Items.Add(scheduleNode.Destination);
                }
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (daysComboBox.SelectedItem != null)
            {
                SelectedDay = daysComboBox.SelectedItem.ToString();
                SelectedTrainNumber = "Train 123"; // Задаємо номер потягу
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть день.");
            }
        }
    }
}

