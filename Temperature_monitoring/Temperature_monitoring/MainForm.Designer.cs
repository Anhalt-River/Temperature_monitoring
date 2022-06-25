
namespace Temperature_monitoring
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panInsert = new System.Windows.Forms.Panel();
            this.labText8 = new System.Windows.Forms.Label();
            this.panUnit7 = new System.Windows.Forms.Panel();
            this.textBoxTimeStartcv = new System.Windows.Forms.TextBox();
            this.labText7 = new System.Windows.Forms.Label();
            this.panUnit5 = new System.Windows.Forms.Panel();
            this.textBoxMinTime = new System.Windows.Forms.TextBox();
            this.labText5 = new System.Windows.Forms.Label();
            this.panUnit6 = new System.Windows.Forms.Panel();
            this.textBoxDataStart = new System.Windows.Forms.TextBox();
            this.labText6 = new System.Windows.Forms.Label();
            this.panUnit4 = new System.Windows.Forms.Panel();
            this.textBoxMinTemp = new System.Windows.Forms.TextBox();
            this.labText4 = new System.Windows.Forms.Label();
            this.panUnit3 = new System.Windows.Forms.Panel();
            this.textBoxTimeMax = new System.Windows.Forms.TextBox();
            this.labText3 = new System.Windows.Forms.Label();
            this.panUnit2 = new System.Windows.Forms.Panel();
            this.textBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.labText2 = new System.Windows.Forms.Label();
            this.panUnit1 = new System.Windows.Forms.Panel();
            this.labText1 = new System.Windows.Forms.Label();
            this.textBoxFishName = new System.Windows.Forms.TextBox();
            this.labTitle1 = new System.Windows.Forms.Label();
            this.panOutput = new System.Windows.Forms.Panel();
            this.labTitle2 = new System.Windows.Forms.Label();
            this.openFFDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFFDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxTempList = new System.Windows.Forms.TextBox();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.panInsert.SuspendLayout();
            this.panUnit7.SuspendLayout();
            this.panUnit5.SuspendLayout();
            this.panUnit6.SuspendLayout();
            this.panUnit4.SuspendLayout();
            this.panUnit3.SuspendLayout();
            this.panUnit2.SuspendLayout();
            this.panUnit1.SuspendLayout();
            this.panOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInsert
            // 
            this.panInsert.Controls.Add(this.butOpenFile);
            this.panInsert.Controls.Add(this.textBoxTempList);
            this.panInsert.Controls.Add(this.labText8);
            this.panInsert.Controls.Add(this.panUnit7);
            this.panInsert.Controls.Add(this.panUnit5);
            this.panInsert.Controls.Add(this.panUnit6);
            this.panInsert.Controls.Add(this.panUnit4);
            this.panInsert.Controls.Add(this.panUnit3);
            this.panInsert.Controls.Add(this.panUnit2);
            this.panInsert.Controls.Add(this.panUnit1);
            this.panInsert.Controls.Add(this.labTitle1);
            this.panInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.panInsert.Location = new System.Drawing.Point(0, 0);
            this.panInsert.Name = "panInsert";
            this.panInsert.Size = new System.Drawing.Size(388, 450);
            this.panInsert.TabIndex = 0;
            // 
            // labText8
            // 
            this.labText8.AutoSize = true;
            this.labText8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText8.Location = new System.Drawing.Point(9, 320);
            this.labText8.Name = "labText8";
            this.labText8.Size = new System.Drawing.Size(313, 16);
            this.labText8.TabIndex = 8;
            this.labText8.Text = "Список фиксированных температур(через пробел):";
            // 
            // panUnit7
            // 
            this.panUnit7.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit7.Controls.Add(this.textBoxTimeStartcv);
            this.panUnit7.Controls.Add(this.labText7);
            this.panUnit7.Location = new System.Drawing.Point(6, 266);
            this.panUnit7.Name = "panUnit7";
            this.panUnit7.Size = new System.Drawing.Size(289, 35);
            this.panUnit7.TabIndex = 13;
            // 
            // textBoxTimeStartcv
            // 
            this.textBoxTimeStartcv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTimeStartcv.Location = new System.Drawing.Point(174, 5);
            this.textBoxTimeStartcv.Name = "textBoxTimeStartcv";
            this.textBoxTimeStartcv.Size = new System.Drawing.Size(98, 21);
            this.textBoxTimeStartcv.TabIndex = 12;
            // 
            // labText7
            // 
            this.labText7.AutoSize = true;
            this.labText7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText7.Location = new System.Drawing.Point(3, 7);
            this.labText7.Name = "labText7";
            this.labText7.Size = new System.Drawing.Size(165, 16);
            this.labText7.TabIndex = 7;
            this.labText7.Text = "Время начала измерений:";
            // 
            // panUnit5
            // 
            this.panUnit5.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit5.Controls.Add(this.textBoxMinTime);
            this.panUnit5.Controls.Add(this.labText5);
            this.panUnit5.Location = new System.Drawing.Point(6, 189);
            this.panUnit5.Name = "panUnit5";
            this.panUnit5.Size = new System.Drawing.Size(372, 33);
            this.panUnit5.TabIndex = 13;
            this.panUnit5.Visible = false;
            // 
            // textBoxMinTime
            // 
            this.textBoxMinTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinTime.Location = new System.Drawing.Point(317, 6);
            this.textBoxMinTime.Name = "textBoxMinTime";
            this.textBoxMinTime.Size = new System.Drawing.Size(48, 21);
            this.textBoxMinTime.TabIndex = 12;
            // 
            // labText5
            // 
            this.labText5.AutoSize = true;
            this.labText5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText5.Location = new System.Drawing.Point(2, 8);
            this.labText5.Name = "labText5";
            this.labText5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labText5.Size = new System.Drawing.Size(302, 16);
            this.labText5.TabIndex = 5;
            this.labText5.Text = "Время, допустимое для превышения минимума:";
            // 
            // panUnit6
            // 
            this.panUnit6.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit6.Controls.Add(this.textBoxDataStart);
            this.panUnit6.Controls.Add(this.labText6);
            this.panUnit6.Location = new System.Drawing.Point(6, 228);
            this.panUnit6.Name = "panUnit6";
            this.panUnit6.Size = new System.Drawing.Size(289, 32);
            this.panUnit6.TabIndex = 12;
            // 
            // textBoxDataStart
            // 
            this.textBoxDataStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDataStart.Location = new System.Drawing.Point(162, 3);
            this.textBoxDataStart.Name = "textBoxDataStart";
            this.textBoxDataStart.Size = new System.Drawing.Size(110, 21);
            this.textBoxDataStart.TabIndex = 13;
            // 
            // labText6
            // 
            this.labText6.AutoSize = true;
            this.labText6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText6.Location = new System.Drawing.Point(2, 5);
            this.labText6.Name = "labText6";
            this.labText6.Size = new System.Drawing.Size(154, 16);
            this.labText6.TabIndex = 6;
            this.labText6.Text = "Дата начала измерений:";
            // 
            // panUnit4
            // 
            this.panUnit4.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit4.Controls.Add(this.textBoxMinTemp);
            this.panUnit4.Controls.Add(this.labText4);
            this.panUnit4.Location = new System.Drawing.Point(6, 150);
            this.panUnit4.Name = "panUnit4";
            this.panUnit4.Size = new System.Drawing.Size(311, 33);
            this.panUnit4.TabIndex = 12;
            // 
            // textBoxMinTemp
            // 
            this.textBoxMinTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinTemp.Location = new System.Drawing.Point(252, 3);
            this.textBoxMinTemp.Name = "textBoxMinTemp";
            this.textBoxMinTemp.Size = new System.Drawing.Size(48, 21);
            this.textBoxMinTemp.TabIndex = 11;
            // 
            // labText4
            // 
            this.labText4.AutoSize = true;
            this.labText4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText4.Location = new System.Drawing.Point(2, 5);
            this.labText4.Name = "labText4";
            this.labText4.Size = new System.Drawing.Size(237, 16);
            this.labText4.TabIndex = 3;
            this.labText4.Text = "Минимальная к допуску температура:";
            // 
            // panUnit3
            // 
            this.panUnit3.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit3.Controls.Add(this.textBoxTimeMax);
            this.panUnit3.Controls.Add(this.labText3);
            this.panUnit3.Location = new System.Drawing.Point(6, 111);
            this.panUnit3.Name = "panUnit3";
            this.panUnit3.Size = new System.Drawing.Size(372, 33);
            this.panUnit3.TabIndex = 12;
            this.panUnit3.Visible = false;
            // 
            // textBoxTimeMax
            // 
            this.textBoxTimeMax.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTimeMax.Location = new System.Drawing.Point(317, 3);
            this.textBoxTimeMax.Name = "textBoxTimeMax";
            this.textBoxTimeMax.Size = new System.Drawing.Size(48, 21);
            this.textBoxTimeMax.TabIndex = 11;
            // 
            // labText3
            // 
            this.labText3.AutoSize = true;
            this.labText3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText3.Location = new System.Drawing.Point(2, 5);
            this.labText3.Name = "labText3";
            this.labText3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labText3.Size = new System.Drawing.Size(308, 16);
            this.labText3.TabIndex = 4;
            this.labText3.Text = "Время, допустимое для превышения максимума:";
            // 
            // panUnit2
            // 
            this.panUnit2.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit2.Controls.Add(this.textBoxMaxTemp);
            this.panUnit2.Controls.Add(this.labText2);
            this.panUnit2.Location = new System.Drawing.Point(6, 68);
            this.panUnit2.Name = "panUnit2";
            this.panUnit2.Size = new System.Drawing.Size(311, 38);
            this.panUnit2.TabIndex = 11;
            // 
            // textBoxMaxTemp
            // 
            this.textBoxMaxTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxTemp.Location = new System.Drawing.Point(252, 7);
            this.textBoxMaxTemp.Name = "textBoxMaxTemp";
            this.textBoxMaxTemp.Size = new System.Drawing.Size(48, 21);
            this.textBoxMaxTemp.TabIndex = 10;
            // 
            // labText2
            // 
            this.labText2.AutoSize = true;
            this.labText2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText2.Location = new System.Drawing.Point(3, 9);
            this.labText2.Name = "labText2";
            this.labText2.Size = new System.Drawing.Size(243, 16);
            this.labText2.TabIndex = 2;
            this.labText2.Text = "Максимальная к допуску температура:";
            // 
            // panUnit1
            // 
            this.panUnit1.BackColor = System.Drawing.SystemColors.Control;
            this.panUnit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUnit1.Controls.Add(this.labText1);
            this.panUnit1.Controls.Add(this.textBoxFishName);
            this.panUnit1.Location = new System.Drawing.Point(6, 33);
            this.panUnit1.Name = "panUnit1";
            this.panUnit1.Size = new System.Drawing.Size(240, 33);
            this.panUnit1.TabIndex = 10;
            // 
            // labText1
            // 
            this.labText1.AutoSize = true;
            this.labText1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labText1.Location = new System.Drawing.Point(3, 6);
            this.labText1.Name = "labText1";
            this.labText1.Size = new System.Drawing.Size(72, 16);
            this.labText1.TabIndex = 1;
            this.labText1.Text = "Вид рыбы:";
            // 
            // textBoxFishName
            // 
            this.textBoxFishName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFishName.Location = new System.Drawing.Point(81, 4);
            this.textBoxFishName.Name = "textBoxFishName";
            this.textBoxFishName.Size = new System.Drawing.Size(147, 21);
            this.textBoxFishName.TabIndex = 9;
            // 
            // labTitle1
            // 
            this.labTitle1.AutoSize = true;
            this.labTitle1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTitle1.Location = new System.Drawing.Point(37, 9);
            this.labTitle1.Name = "labTitle1";
            this.labTitle1.Size = new System.Drawing.Size(270, 19);
            this.labTitle1.TabIndex = 0;
            this.labTitle1.Text = "Ввести информацию о поставке";
            // 
            // panOutput
            // 
            this.panOutput.Controls.Add(this.labTitle2);
            this.panOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.panOutput.Location = new System.Drawing.Point(413, 0);
            this.panOutput.Name = "panOutput";
            this.panOutput.Size = new System.Drawing.Size(387, 450);
            this.panOutput.TabIndex = 1;
            // 
            // labTitle2
            // 
            this.labTitle2.AutoSize = true;
            this.labTitle2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTitle2.Location = new System.Drawing.Point(159, 9);
            this.labTitle2.Name = "labTitle2";
            this.labTitle2.Size = new System.Drawing.Size(156, 19);
            this.labTitle2.TabIndex = 1;
            this.labTitle2.Text = "Отчет по поставке";
            // 
            // openFFDialog
            // 
            this.openFFDialog.FileName = "openFileDialog1";
            // 
            // textBoxTempList
            // 
            this.textBoxTempList.Location = new System.Drawing.Point(6, 340);
            this.textBoxTempList.Multiline = true;
            this.textBoxTempList.Name = "textBoxTempList";
            this.textBoxTempList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxTempList.Size = new System.Drawing.Size(372, 70);
            this.textBoxTempList.TabIndex = 14;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOpenFile.Location = new System.Drawing.Point(88, 416);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(192, 31);
            this.butOpenFile.TabIndex = 15;
            this.butOpenFile.Text = "Загрузить файл";
            this.butOpenFile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panOutput);
            this.Controls.Add(this.panInsert);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panInsert.ResumeLayout(false);
            this.panInsert.PerformLayout();
            this.panUnit7.ResumeLayout(false);
            this.panUnit7.PerformLayout();
            this.panUnit5.ResumeLayout(false);
            this.panUnit5.PerformLayout();
            this.panUnit6.ResumeLayout(false);
            this.panUnit6.PerformLayout();
            this.panUnit4.ResumeLayout(false);
            this.panUnit4.PerformLayout();
            this.panUnit3.ResumeLayout(false);
            this.panUnit3.PerformLayout();
            this.panUnit2.ResumeLayout(false);
            this.panUnit2.PerformLayout();
            this.panUnit1.ResumeLayout(false);
            this.panUnit1.PerformLayout();
            this.panOutput.ResumeLayout(false);
            this.panOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panInsert;
        private System.Windows.Forms.TextBox textBoxFishName;
        private System.Windows.Forms.Label labText8;
        private System.Windows.Forms.Label labText7;
        private System.Windows.Forms.Label labText6;
        private System.Windows.Forms.Label labText5;
        private System.Windows.Forms.Label labText3;
        private System.Windows.Forms.Label labText4;
        private System.Windows.Forms.Label labText2;
        private System.Windows.Forms.Label labText1;
        private System.Windows.Forms.Label labTitle1;
        private System.Windows.Forms.Panel panOutput;
        private System.Windows.Forms.Label labTitle2;
        private System.Windows.Forms.OpenFileDialog openFFDialog;
        private System.Windows.Forms.SaveFileDialog saveFFDialog;
        private System.Windows.Forms.Panel panUnit7;
        private System.Windows.Forms.TextBox textBoxTimeStartcv;
        private System.Windows.Forms.Panel panUnit5;
        private System.Windows.Forms.TextBox textBoxMinTime;
        private System.Windows.Forms.Panel panUnit6;
        private System.Windows.Forms.TextBox textBoxDataStart;
        private System.Windows.Forms.Panel panUnit4;
        private System.Windows.Forms.TextBox textBoxMinTemp;
        private System.Windows.Forms.Panel panUnit3;
        private System.Windows.Forms.TextBox textBoxTimeMax;
        private System.Windows.Forms.Panel panUnit2;
        private System.Windows.Forms.TextBox textBoxMaxTemp;
        private System.Windows.Forms.Panel panUnit1;
        private System.Windows.Forms.TextBox textBoxTempList;
        private System.Windows.Forms.Button butOpenFile;
    }
}

