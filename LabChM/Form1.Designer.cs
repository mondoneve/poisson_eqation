namespace LabChM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.calcButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.testTRadiobutton = new System.Windows.Forms.RadioButton();
      this.mainTRadiobutton = new System.Windows.Forms.RadioButton();
      this.resultTabControl = new System.Windows.Forms.TabControl();
      this.uTabPage = new System.Windows.Forms.TabPage();
      this.uDGV = new System.Windows.Forms.DataGridView();
      this.vTabPage = new System.Windows.Forms.TabPage();
      this.vDGV = new System.Windows.Forms.DataGridView();
      this.diffTabPage = new System.Windows.Forms.TabPage();
      this.dDGV = new System.Windows.Forms.DataGridView();
      this.otherTabPage = new System.Windows.Forms.TabPage();
      this.grid_mTB = new System.Windows.Forms.TextBox();
      this.grid_nTB = new System.Windows.Forms.TextBox();
      this.gridLabel = new System.Windows.Forms.Label();
      this.n_iterTB = new System.Windows.Forms.TextBox();
      this.epsTB = new System.Windows.Forms.TextBox();
      this.n_iterLabel = new System.Windows.Forms.Label();
      this.epsLabel = new System.Windows.Forms.Label();
      this.n_paramTB = new System.Windows.Forms.TextBox();
      this.n_paramLabel = new System.Windows.Forms.Label();
      this.infoBox = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.iterDefaultLabel = new System.Windows.Forms.Label();
      this.maxDiffLabel = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.precDefaultLabel = new System.Windows.Forms.Label();
      this.precDoubleLabel = new System.Windows.Forms.Label();
      this.iterDoubleLabel = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.pointMaxDiffLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.resultTabControl.SuspendLayout();
      this.uTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uDGV)).BeginInit();
      this.vTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.vDGV)).BeginInit();
      this.diffTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dDGV)).BeginInit();
      this.infoBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // calcButton
      // 
      this.calcButton.Location = new System.Drawing.Point(3, 166);
      this.calcButton.Name = "calcButton";
      this.calcButton.Size = new System.Drawing.Size(210, 23);
      this.calcButton.TabIndex = 0;
      this.calcButton.Text = "СЧЁТ";
      this.calcButton.UseVisualStyleBackColor = true;
      this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.testTRadiobutton);
      this.groupBox1.Controls.Add(this.mainTRadiobutton);
      this.groupBox1.Location = new System.Drawing.Point(3, 111);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(210, 49);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "ЗАДАЧА";
      // 
      // testTRadiobutton
      // 
      this.testTRadiobutton.AutoSize = true;
      this.testTRadiobutton.Location = new System.Drawing.Point(130, 19);
      this.testTRadiobutton.Name = "testTRadiobutton";
      this.testTRadiobutton.Size = new System.Drawing.Size(53, 17);
      this.testTRadiobutton.TabIndex = 1;
      this.testTRadiobutton.Text = "ТЕСТ";
      this.testTRadiobutton.UseVisualStyleBackColor = true;
      // 
      // mainTRadiobutton
      // 
      this.mainTRadiobutton.AutoSize = true;
      this.mainTRadiobutton.Checked = true;
      this.mainTRadiobutton.Location = new System.Drawing.Point(3, 19);
      this.mainTRadiobutton.Name = "mainTRadiobutton";
      this.mainTRadiobutton.Size = new System.Drawing.Size(86, 17);
      this.mainTRadiobutton.TabIndex = 0;
      this.mainTRadiobutton.TabStop = true;
      this.mainTRadiobutton.Text = "ОСНОВНАЯ";
      this.mainTRadiobutton.UseVisualStyleBackColor = true;
      this.mainTRadiobutton.CheckedChanged += new System.EventHandler(this.mainTRadiobutton_CheckedChanged);
      // 
      // resultTabControl
      // 
      this.resultTabControl.Controls.Add(this.uTabPage);
      this.resultTabControl.Controls.Add(this.vTabPage);
      this.resultTabControl.Controls.Add(this.diffTabPage);
      this.resultTabControl.Controls.Add(this.otherTabPage);
      this.resultTabControl.Location = new System.Drawing.Point(219, 6);
      this.resultTabControl.Name = "resultTabControl";
      this.resultTabControl.SelectedIndex = 0;
      this.resultTabControl.Size = new System.Drawing.Size(835, 438);
      this.resultTabControl.TabIndex = 3;
      // 
      // uTabPage
      // 
      this.uTabPage.Controls.Add(this.uDGV);
      this.uTabPage.Location = new System.Drawing.Point(4, 22);
      this.uTabPage.Name = "uTabPage";
      this.uTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.uTabPage.Size = new System.Drawing.Size(827, 412);
      this.uTabPage.TabIndex = 0;
      this.uTabPage.Text = "ТОЧНЕЕ";
      this.uTabPage.UseVisualStyleBackColor = true;
      // 
      // uDGV
      // 
      this.uDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.uDGV.Location = new System.Drawing.Point(0, 0);
      this.uDGV.Name = "uDGV";
      this.uDGV.Size = new System.Drawing.Size(827, 412);
      this.uDGV.TabIndex = 0;
      // 
      // vTabPage
      // 
      this.vTabPage.Controls.Add(this.vDGV);
      this.vTabPage.Location = new System.Drawing.Point(4, 22);
      this.vTabPage.Name = "vTabPage";
      this.vTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.vTabPage.Size = new System.Drawing.Size(827, 412);
      this.vTabPage.TabIndex = 1;
      this.vTabPage.Text = "НЕ ТАК ТОЧНО";
      this.vTabPage.UseVisualStyleBackColor = true;
      // 
      // vDGV
      // 
      this.vDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.vDGV.Location = new System.Drawing.Point(0, 0);
      this.vDGV.Name = "vDGV";
      this.vDGV.Size = new System.Drawing.Size(827, 416);
      this.vDGV.TabIndex = 0;
      // 
      // diffTabPage
      // 
      this.diffTabPage.Controls.Add(this.dDGV);
      this.diffTabPage.Location = new System.Drawing.Point(4, 22);
      this.diffTabPage.Name = "diffTabPage";
      this.diffTabPage.Size = new System.Drawing.Size(827, 412);
      this.diffTabPage.TabIndex = 2;
      this.diffTabPage.Text = "КАК НЕТОЧНО";
      this.diffTabPage.UseVisualStyleBackColor = true;
      // 
      // dDGV
      // 
      this.dDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dDGV.Location = new System.Drawing.Point(0, 0);
      this.dDGV.Name = "dDGV";
      this.dDGV.Size = new System.Drawing.Size(827, 412);
      this.dDGV.TabIndex = 4;
      // 
      // otherTabPage
      // 
      this.otherTabPage.Location = new System.Drawing.Point(4, 22);
      this.otherTabPage.Name = "otherTabPage";
      this.otherTabPage.Size = new System.Drawing.Size(827, 412);
      this.otherTabPage.TabIndex = 3;
      this.otherTabPage.Text = "ИТОГ";
      this.otherTabPage.UseVisualStyleBackColor = true;
      // 
      // grid_mTB
      // 
      this.grid_mTB.Location = new System.Drawing.Point(145, 6);
      this.grid_mTB.Name = "grid_mTB";
      this.grid_mTB.Size = new System.Drawing.Size(68, 20);
      this.grid_mTB.TabIndex = 4;
      this.grid_mTB.Text = "10";
      // 
      // grid_nTB
      // 
      this.grid_nTB.Location = new System.Drawing.Point(82, 6);
      this.grid_nTB.Name = "grid_nTB";
      this.grid_nTB.Size = new System.Drawing.Size(57, 20);
      this.grid_nTB.TabIndex = 5;
      this.grid_nTB.Text = "10";
      // 
      // gridLabel
      // 
      this.gridLabel.AutoSize = true;
      this.gridLabel.Location = new System.Drawing.Point(3, 9);
      this.gridLabel.Name = "gridLabel";
      this.gridLabel.Size = new System.Drawing.Size(73, 13);
      this.gridLabel.TabIndex = 6;
      this.gridLabel.Text = "СЕТКА N x M";
      // 
      // n_iterTB
      // 
      this.n_iterTB.Location = new System.Drawing.Point(145, 32);
      this.n_iterTB.Name = "n_iterTB";
      this.n_iterTB.Size = new System.Drawing.Size(68, 20);
      this.n_iterTB.TabIndex = 7;
      this.n_iterTB.Text = "200";
      // 
      // epsTB
      // 
      this.epsTB.Location = new System.Drawing.Point(145, 58);
      this.epsTB.Name = "epsTB";
      this.epsTB.Size = new System.Drawing.Size(68, 20);
      this.epsTB.TabIndex = 8;
      this.epsTB.Text = "0.0001";
      // 
      // n_iterLabel
      // 
      this.n_iterLabel.AutoSize = true;
      this.n_iterLabel.Location = new System.Drawing.Point(3, 35);
      this.n_iterLabel.Name = "n_iterLabel";
      this.n_iterLabel.Size = new System.Drawing.Size(136, 13);
      this.n_iterLabel.TabIndex = 9;
      this.n_iterLabel.Text = "ОГРАНИЧИТЕЛЬ ШАГОВ";
      // 
      // epsLabel
      // 
      this.epsLabel.AutoSize = true;
      this.epsLabel.Location = new System.Drawing.Point(3, 58);
      this.epsLabel.Name = "epsLabel";
      this.epsLabel.Size = new System.Drawing.Size(67, 13);
      this.epsLabel.TabIndex = 10;
      this.epsLabel.Text = "ТОЧНОСТЬ";
      // 
      // n_paramTB
      // 
      this.n_paramTB.Location = new System.Drawing.Point(145, 85);
      this.n_paramTB.Name = "n_paramTB";
      this.n_paramTB.Size = new System.Drawing.Size(68, 20);
      this.n_paramTB.TabIndex = 11;
      this.n_paramTB.Text = "5";
      // 
      // n_paramLabel
      // 
      this.n_paramLabel.AutoSize = true;
      this.n_paramLabel.Location = new System.Drawing.Point(3, 88);
      this.n_paramLabel.Name = "n_paramLabel";
      this.n_paramLabel.Size = new System.Drawing.Size(123, 13);
      this.n_paramLabel.TabIndex = 12;
      this.n_paramLabel.Text = "ЧИСЛО ПАРАМЕТРОВ";
      // 
      // infoBox
      // 
      this.infoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.infoBox.Controls.Add(this.pointMaxDiffLabel);
      this.infoBox.Controls.Add(this.label16);
      this.infoBox.Controls.Add(this.label15);
      this.infoBox.Controls.Add(this.precDoubleLabel);
      this.infoBox.Controls.Add(this.iterDoubleLabel);
      this.infoBox.Controls.Add(this.label11);
      this.infoBox.Controls.Add(this.label12);
      this.infoBox.Controls.Add(this.label13);
      this.infoBox.Controls.Add(this.label14);
      this.infoBox.Controls.Add(this.precDefaultLabel);
      this.infoBox.Controls.Add(this.label7);
      this.infoBox.Controls.Add(this.maxDiffLabel);
      this.infoBox.Controls.Add(this.iterDefaultLabel);
      this.infoBox.Controls.Add(this.label3);
      this.infoBox.Controls.Add(this.label2);
      this.infoBox.Controls.Add(this.label1);
      this.infoBox.Controls.Add(this.label6);
      this.infoBox.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.infoBox.Location = new System.Drawing.Point(3, 196);
      this.infoBox.Name = "infoBox";
      this.infoBox.Size = new System.Drawing.Size(210, 248);
      this.infoBox.TabIndex = 13;
      this.infoBox.TabStop = false;
      this.infoBox.Text = "ИТОГ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(139, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ИТЕРАЦИЙ ЗАТРАЧЕНО:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "ТОЧНОСТЬ МЕТОДА:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 34);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "ОБЫЧНАЯ СЕТКА";
      // 
      // iterDefaultLabel
      // 
      this.iterDefaultLabel.AutoSize = true;
      this.iterDefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iterDefaultLabel.Location = new System.Drawing.Point(148, 63);
      this.iterDefaultLabel.Name = "iterDefaultLabel";
      this.iterDefaultLabel.Size = new System.Drawing.Size(0, 13);
      this.iterDefaultLabel.TabIndex = 4;
      // 
      // maxDiffLabel
      // 
      this.maxDiffLabel.AutoSize = true;
      this.maxDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.maxDiffLabel.Location = new System.Drawing.Point(148, 192);
      this.maxDiffLabel.Name = "maxDiffLabel";
      this.maxDiffLabel.Size = new System.Drawing.Size(0, 13);
      this.maxDiffLabel.TabIndex = 5;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(6, 91);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(199, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "________________________________";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(6, 192);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(117, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "РЕКОРД РАЗНОСТИ:";
      // 
      // precDefaultLabel
      // 
      this.precDefaultLabel.AutoSize = true;
      this.precDefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.precDefaultLabel.Location = new System.Drawing.Point(148, 76);
      this.precDefaultLabel.Name = "precDefaultLabel";
      this.precDefaultLabel.Size = new System.Drawing.Size(0, 13);
      this.precDefaultLabel.TabIndex = 8;
      // 
      // precDoubleLabel
      // 
      this.precDoubleLabel.AutoSize = true;
      this.precDoubleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.precDoubleLabel.Location = new System.Drawing.Point(148, 156);
      this.precDoubleLabel.Name = "precDoubleLabel";
      this.precDoubleLabel.Size = new System.Drawing.Size(0, 13);
      this.precDoubleLabel.TabIndex = 14;
      // 
      // iterDoubleLabel
      // 
      this.iterDoubleLabel.AutoSize = true;
      this.iterDoubleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iterDoubleLabel.Location = new System.Drawing.Point(148, 143);
      this.iterDoubleLabel.Name = "iterDoubleLabel";
      this.iterDoubleLabel.Size = new System.Drawing.Size(0, 13);
      this.iterDoubleLabel.TabIndex = 12;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(6, 114);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(100, 13);
      this.label11.TabIndex = 11;
      this.label11.Text = "ДВОЙНАЯ СЕТКА";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label12.Location = new System.Drawing.Point(6, 156);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(120, 13);
      this.label12.TabIndex = 10;
      this.label12.Text = "ТОЧНОСТЬ МЕТОДА:";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label13.Location = new System.Drawing.Point(6, 143);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(139, 13);
      this.label13.TabIndex = 9;
      this.label13.Text = "ИТЕРАЦИЙ ЗАТРАЧЕНО:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label14.Location = new System.Drawing.Point(6, 171);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(199, 13);
      this.label14.TabIndex = 13;
      this.label14.Text = "________________________________";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label15.Location = new System.Drawing.Point(6, 214);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(40, 13);
      this.label15.TabIndex = 15;
      this.label15.Text = "УЗЕЛ:";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label16.Location = new System.Drawing.Point(105, 118);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(0, 13);
      this.label16.TabIndex = 16;
      // 
      // pointMaxDiffLabel
      // 
      this.pointMaxDiffLabel.AutoSize = true;
      this.pointMaxDiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.pointMaxDiffLabel.Location = new System.Drawing.Point(52, 214);
      this.pointMaxDiffLabel.Name = "pointMaxDiffLabel";
      this.pointMaxDiffLabel.Size = new System.Drawing.Size(0, 13);
      this.pointMaxDiffLabel.TabIndex = 17;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1066, 456);
      this.Controls.Add(this.infoBox);
      this.Controls.Add(this.n_paramLabel);
      this.Controls.Add(this.n_paramTB);
      this.Controls.Add(this.epsLabel);
      this.Controls.Add(this.n_iterLabel);
      this.Controls.Add(this.epsTB);
      this.Controls.Add(this.n_iterTB);
      this.Controls.Add(this.gridLabel);
      this.Controls.Add(this.grid_nTB);
      this.Controls.Add(this.grid_mTB);
      this.Controls.Add(this.resultTabControl);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.calcButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.resultTabControl.ResumeLayout(false);
      this.uTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uDGV)).EndInit();
      this.vTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.vDGV)).EndInit();
      this.diffTabPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dDGV)).EndInit();
      this.infoBox.ResumeLayout(false);
      this.infoBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button calcButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton testTRadiobutton;
    private System.Windows.Forms.RadioButton mainTRadiobutton;
    private System.Windows.Forms.TabControl resultTabControl;
    private System.Windows.Forms.TabPage uTabPage;
    private System.Windows.Forms.DataGridView uDGV;
    private System.Windows.Forms.TabPage vTabPage;
    private System.Windows.Forms.DataGridView vDGV;
    private System.Windows.Forms.TabPage diffTabPage;
    private System.Windows.Forms.DataGridView dDGV;
    private System.Windows.Forms.TabPage otherTabPage;
    private System.Windows.Forms.TextBox grid_mTB;
    private System.Windows.Forms.TextBox grid_nTB;
    private System.Windows.Forms.Label gridLabel;
    private System.Windows.Forms.TextBox n_iterTB;
    private System.Windows.Forms.TextBox epsTB;
    private System.Windows.Forms.Label n_iterLabel;
    private System.Windows.Forms.Label epsLabel;
    private System.Windows.Forms.TextBox n_paramTB;
    private System.Windows.Forms.Label n_paramLabel;
    private System.Windows.Forms.GroupBox infoBox;
    private System.Windows.Forms.Label pointMaxDiffLabel;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label precDoubleLabel;
    private System.Windows.Forms.Label iterDoubleLabel;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label precDefaultLabel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label maxDiffLabel;
    private System.Windows.Forms.Label iterDefaultLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
  }
}

