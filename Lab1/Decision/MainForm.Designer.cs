namespace Decision
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
            this.trackBarMain = new System.Windows.Forms.TrackBar();
            this.tb_ProbabilityRain = new System.Windows.Forms.TextBox();
            this.numUpDown_UtilityRain1 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_UtilityRain2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_UtilitySun2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_UtilitySun1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Utility = new System.Windows.Forms.Label();
            this.lbl_ProbablityRain = new System.Windows.Forms.Label();
            this.lbl_Expectation = new System.Windows.Forms.Label();
            this.lbl_ForestRes = new System.Windows.Forms.Label();
            this.lbl_Forest = new System.Windows.Forms.Label();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.lbl_Decision = new System.Windows.Forms.Label();
            this.lbl_HomeRes = new System.Windows.Forms.Label();
            this.lbl_Decide = new System.Windows.Forms.Label();
            this.lbl_UtilitySun = new System.Windows.Forms.Label();
            this.lbl_UtilityRain = new System.Windows.Forms.Label();
            this.lbl_UntilityHome = new System.Windows.Forms.Label();
            this.lbl_UntilityForest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilityRain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilityRain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilitySun2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilitySun1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarMain
            // 
            this.trackBarMain.Location = new System.Drawing.Point(67, 43);
            this.trackBarMain.Maximum = 100;
            this.trackBarMain.Name = "trackBarMain";
            this.trackBarMain.Size = new System.Drawing.Size(145, 56);
            this.trackBarMain.TabIndex = 1;
            this.trackBarMain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMain.Scroll += new System.EventHandler(this.trackBarMain_Scroll);
            // 
            // tb_ProbabilityRain
            // 
            this.tb_ProbabilityRain.Location = new System.Drawing.Point(245, 43);
            this.tb_ProbabilityRain.Name = "tb_ProbabilityRain";
            this.tb_ProbabilityRain.ReadOnly = true;
            this.tb_ProbabilityRain.Size = new System.Drawing.Size(68, 22);
            this.tb_ProbabilityRain.TabIndex = 2;
            this.tb_ProbabilityRain.Text = "0";
            this.tb_ProbabilityRain.TextChanged += new System.EventHandler(this.ValueChange);
            // 
            // numUpDown_UtilityRain1
            // 
            this.numUpDown_UtilityRain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown_UtilityRain1.Location = new System.Drawing.Point(100, 238);
            this.numUpDown_UtilityRain1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilityRain1.Name = "numUpDown_UtilityRain1";
            this.numUpDown_UtilityRain1.ReadOnly = true;
            this.numUpDown_UtilityRain1.Size = new System.Drawing.Size(112, 27);
            this.numUpDown_UtilityRain1.TabIndex = 3;
            this.numUpDown_UtilityRain1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_UtilityRain1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilityRain1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // numUpDown_UtilityRain2
            // 
            this.numUpDown_UtilityRain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown_UtilityRain2.Location = new System.Drawing.Point(236, 238);
            this.numUpDown_UtilityRain2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilityRain2.Name = "numUpDown_UtilityRain2";
            this.numUpDown_UtilityRain2.ReadOnly = true;
            this.numUpDown_UtilityRain2.Size = new System.Drawing.Size(112, 27);
            this.numUpDown_UtilityRain2.TabIndex = 8;
            this.numUpDown_UtilityRain2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_UtilityRain2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilityRain2.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // numUpDown_UtilitySun2
            // 
            this.numUpDown_UtilitySun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown_UtilitySun2.Location = new System.Drawing.Point(236, 195);
            this.numUpDown_UtilitySun2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilitySun2.Name = "numUpDown_UtilitySun2";
            this.numUpDown_UtilitySun2.ReadOnly = true;
            this.numUpDown_UtilitySun2.Size = new System.Drawing.Size(112, 27);
            this.numUpDown_UtilitySun2.TabIndex = 9;
            this.numUpDown_UtilitySun2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_UtilitySun2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilitySun2.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // numUpDown_UtilitySun1
            // 
            this.numUpDown_UtilitySun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown_UtilitySun1.Location = new System.Drawing.Point(100, 195);
            this.numUpDown_UtilitySun1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilitySun1.Name = "numUpDown_UtilitySun1";
            this.numUpDown_UtilitySun1.ReadOnly = true;
            this.numUpDown_UtilitySun1.Size = new System.Drawing.Size(112, 27);
            this.numUpDown_UtilitySun1.TabIndex = 10;
            this.numUpDown_UtilitySun1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_UtilitySun1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_UtilitySun1.ValueChanged += new System.EventHandler(this.ValueChange);
            // 
            // lbl_Utility
            // 
            this.lbl_Utility.AutoSize = true;
            this.lbl_Utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Utility.Location = new System.Drawing.Point(156, 118);
            this.lbl_Utility.Name = "lbl_Utility";
            this.lbl_Utility.Size = new System.Drawing.Size(112, 20);
            this.lbl_Utility.TabIndex = 12;
            this.lbl_Utility.Text = "Корисність";
            // 
            // lbl_ProbablityRain
            // 
            this.lbl_ProbablityRain.AutoSize = true;
            this.lbl_ProbablityRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ProbablityRain.Location = new System.Drawing.Point(63, 9);
            this.lbl_ProbablityRain.Name = "lbl_ProbablityRain";
            this.lbl_ProbablityRain.Size = new System.Drawing.Size(174, 20);
            this.lbl_ProbablityRain.TabIndex = 13;
            this.lbl_ProbablityRain.Text = "Ймовірність дощу";
            // 
            // lbl_Expectation
            // 
            this.lbl_Expectation.AutoSize = true;
            this.lbl_Expectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Expectation.Location = new System.Drawing.Point(484, 59);
            this.lbl_Expectation.Name = "lbl_Expectation";
            this.lbl_Expectation.Size = new System.Drawing.Size(227, 25);
            this.lbl_Expectation.TabIndex = 14;
            this.lbl_Expectation.Text = "Очікувана корисність";
            // 
            // lbl_ForestRes
            // 
            this.lbl_ForestRes.AutoSize = true;
            this.lbl_ForestRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ForestRes.Location = new System.Drawing.Point(649, 109);
            this.lbl_ForestRes.Name = "lbl_ForestRes";
            this.lbl_ForestRes.Size = new System.Drawing.Size(0, 20);
            this.lbl_ForestRes.TabIndex = 15;
            // 
            // lbl_Forest
            // 
            this.lbl_Forest.AutoSize = true;
            this.lbl_Forest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Forest.Location = new System.Drawing.Point(494, 109);
            this.lbl_Forest.Name = "lbl_Forest";
            this.lbl_Forest.Size = new System.Drawing.Size(34, 20);
            this.lbl_Forest.TabIndex = 16;
            this.lbl_Forest.Text = "Ліс";
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Home.Location = new System.Drawing.Point(494, 146);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(38, 20);
            this.lbl_Home.TabIndex = 17;
            this.lbl_Home.Text = "Дім";
            // 
            // lbl_Decision
            // 
            this.lbl_Decision.AutoSize = true;
            this.lbl_Decision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Decision.Location = new System.Drawing.Point(484, 184);
            this.lbl_Decision.Name = "lbl_Decision";
            this.lbl_Decision.Size = new System.Drawing.Size(95, 25);
            this.lbl_Decision.TabIndex = 18;
            this.lbl_Decision.Text = "Рішення";
            // 
            // lbl_HomeRes
            // 
            this.lbl_HomeRes.AutoSize = true;
            this.lbl_HomeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_HomeRes.Location = new System.Drawing.Point(649, 146);
            this.lbl_HomeRes.Name = "lbl_HomeRes";
            this.lbl_HomeRes.Size = new System.Drawing.Size(0, 20);
            this.lbl_HomeRes.TabIndex = 19;
            // 
            // lbl_Decide
            // 
            this.lbl_Decide.AutoSize = true;
            this.lbl_Decide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Decide.Location = new System.Drawing.Point(494, 225);
            this.lbl_Decide.Name = "lbl_Decide";
            this.lbl_Decide.Size = new System.Drawing.Size(0, 20);
            this.lbl_Decide.TabIndex = 20;
            // 
            // lbl_UtilitySun
            // 
            this.lbl_UtilitySun.AutoSize = true;
            this.lbl_UtilitySun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_UtilitySun.Location = new System.Drawing.Point(16, 198);
            this.lbl_UtilitySun.Name = "lbl_UtilitySun";
            this.lbl_UtilitySun.Size = new System.Drawing.Size(61, 20);
            this.lbl_UtilitySun.TabIndex = 21;
            this.lbl_UtilitySun.Text = "Сонце";
            // 
            // lbl_UtilityRain
            // 
            this.lbl_UtilityRain.AutoSize = true;
            this.lbl_UtilityRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_UtilityRain.Location = new System.Drawing.Point(31, 238);
            this.lbl_UtilityRain.Name = "lbl_UtilityRain";
            this.lbl_UtilityRain.Size = new System.Drawing.Size(46, 20);
            this.lbl_UtilityRain.TabIndex = 22;
            this.lbl_UtilityRain.Text = "Дощ";
            // 
            // lbl_UntilityHome
            // 
            this.lbl_UntilityHome.AutoSize = true;
            this.lbl_UntilityHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_UntilityHome.Location = new System.Drawing.Point(273, 159);
            this.lbl_UntilityHome.Name = "lbl_UntilityHome";
            this.lbl_UntilityHome.Size = new System.Drawing.Size(38, 20);
            this.lbl_UntilityHome.TabIndex = 24;
            this.lbl_UntilityHome.Text = "Дім";
            // 
            // lbl_UntilityForest
            // 
            this.lbl_UntilityForest.AutoSize = true;
            this.lbl_UntilityForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_UntilityForest.Location = new System.Drawing.Point(131, 159);
            this.lbl_UntilityForest.Name = "lbl_UntilityForest";
            this.lbl_UntilityForest.Size = new System.Drawing.Size(34, 20);
            this.lbl_UntilityForest.TabIndex = 23;
            this.lbl_UntilityForest.Text = "Ліс";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 308);
            this.Controls.Add(this.lbl_UntilityHome);
            this.Controls.Add(this.lbl_UntilityForest);
            this.Controls.Add(this.lbl_UtilityRain);
            this.Controls.Add(this.lbl_UtilitySun);
            this.Controls.Add(this.lbl_Decide);
            this.Controls.Add(this.lbl_HomeRes);
            this.Controls.Add(this.lbl_Decision);
            this.Controls.Add(this.lbl_Home);
            this.Controls.Add(this.lbl_Forest);
            this.Controls.Add(this.lbl_ForestRes);
            this.Controls.Add(this.lbl_Expectation);
            this.Controls.Add(this.lbl_ProbablityRain);
            this.Controls.Add(this.lbl_Utility);
            this.Controls.Add(this.numUpDown_UtilitySun1);
            this.Controls.Add(this.numUpDown_UtilitySun2);
            this.Controls.Add(this.numUpDown_UtilityRain2);
            this.Controls.Add(this.numUpDown_UtilityRain1);
            this.Controls.Add(this.tb_ProbabilityRain);
            this.Controls.Add(this.trackBarMain);
            this.Name = "MainForm";
            this.Text = "Пікнік";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilityRain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilityRain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilitySun2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_UtilitySun1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarMain;
        private System.Windows.Forms.TextBox tb_ProbabilityRain;
        private System.Windows.Forms.NumericUpDown numUpDown_UtilityRain1;
        private System.Windows.Forms.NumericUpDown numUpDown_UtilityRain2;
        private System.Windows.Forms.NumericUpDown numUpDown_UtilitySun2;
        private System.Windows.Forms.NumericUpDown numUpDown_UtilitySun1;
        private System.Windows.Forms.Label lbl_Utility;
        private System.Windows.Forms.Label lbl_ProbablityRain;
        private System.Windows.Forms.Label lbl_Expectation;
        private System.Windows.Forms.Label lbl_ForestRes;
        private System.Windows.Forms.Label lbl_Forest;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label lbl_Decision;
        private System.Windows.Forms.Label lbl_HomeRes;
        private System.Windows.Forms.Label lbl_Decide;
        private System.Windows.Forms.Label lbl_UtilitySun;
        private System.Windows.Forms.Label lbl_UtilityRain;
        private System.Windows.Forms.Label lbl_UntilityHome;
        private System.Windows.Forms.Label lbl_UntilityForest;
    }
}

