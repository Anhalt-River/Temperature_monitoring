using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_monitoring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butProcess_Click(object sender, EventArgs e)
        {
            ClearReport();

            string[] maxTemp = new string[2];
            maxTemp[0] = textBoxMaxTemp.Text;
            maxTemp[1] = textBoxTimeMax.Text;

            string[] minTemp = new string[2];
            minTemp[0] = textBoxMinTemp.Text;
            minTemp[1] = textBoxMinTime.Text;

            string rowDate = textBoxDataStart.Text;
            string rowTime = textBoxTimeStartcv.Text;

            string tempList = textBoxTempList.Text;

            string[] report = ProcessingInput.Recycle(maxTemp, minTemp, rowDate, rowTime, tempList);

            if (report != null)
            {
                InfoAnalysing(report[0]);
                ResultOutput(report[3], Convert.ToInt32(report[1]), Convert.ToInt32(report[2]));
            }
            else
            {
                DialogResult result = MessageBox.Show(
                 "Ошибка форматирования. Проверьте верность указанной информации");
            }
        }

        private void InfoAnalysing(string taked_text)
        {
            string[] new_text = taked_text.Split('/');
            foreach (string line in new_text)
            {
                string[] new_line = line.Split('|');
                string fin_line = "";
                foreach (string piece in new_line)
                {
                    fin_line += (piece + "    ");
                }
                richTextBoxReport.AppendText(fin_line);
                richTextBoxReport.SelectedText += "\r";
            }

        }

        private void ResultOutput(string result, int maxCounter, int minCounter)
        {
            switch (result)
            {
                case "Max":
                    textBoxResult.Text += "Порог максимально допустимой температуры превышен на" + ($"{maxCounter}");
                    break;
                case "Min":
                    textBoxResult.Text += "Порог минимально допустимой температуры превышен на" + ($"{minCounter}");
                    break;
                case "MaxMin":
                    textBoxResult.Text += "Порог минимально допустимой температуры превышен на" + ($"{minCounter}, ") +
                        "Порог максимально допустимой температуры превышен на" + ($"{maxCounter}");
                    break;
                case "No":
                    textBoxResult.Text += "Отклонени в ходе проверки не выявлено";
                    break;
            }
                
        }

        private void ClearReport()
        {
            richTextBoxReport.Clear();
            textBoxResult.Clear();
        }
    }
}
