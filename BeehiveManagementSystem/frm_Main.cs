using BeehiveManagementSystem.Classes;
using System.Windows.Forms;

namespace BeehiveManagementSystem
{
    public partial class frm_Main : Form
    {
        private Queen queen;

        public frm_Main()
        {
            InitializeComponent();
            // Устанавливаем активным первый элемент выпадающего списка с работами
            comBx_workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Сбор нектара", "Производство меда" });
            workers[1] = new Worker(new string[] { "Забота о яйцах", "Обучение маленьких пчел" });
            workers[2] = new Worker(new string[] { "Обслуживание улья", "Патрулирование" });
            workers[3] = new Worker(new string[] { "Сбор нектара", "Производство меда",
"Забота о яйцах", "Обучение маленьких пчел", "Обслуживание улья", "Патрулирование" });
            // Массив Worker нужно передать конструктору объекта Queen
            queen = new Queen(workers);
            //queen.AssignWork();
        }

        private void btn_assignJob_Click(object sender, System.EventArgs e)
        {
            if (queen.AssignWork(comBx_workerBeeJob.Text, (int)numUpd_shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет ‘" + comBx_workerBeeJob.Text + "’", "Матка говорит...");
            else
                MessageBox.Show("Задание ‘" + comBx_workerBeeJob.Text + "’ будет закончено через " + numUpd_shifts.Value + " смен", "Матка говорит...");
        }

        private void btn_nextShift_Click(object sender, System.EventArgs e)
        {
            txtBx_report.Text = queen.WorkTheNextShift();
        }
    }
}
