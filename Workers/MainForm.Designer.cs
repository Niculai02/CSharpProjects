
namespace Workers
{
    partial class MainForm
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
            this.buttonListWorkers = new System.Windows.Forms.Button();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.radioButtonDirector = new System.Windows.Forms.RadioButton();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonOfficer = new System.Windows.Forms.RadioButton();
            this.radioButtonWorker = new System.Windows.Forms.RadioButton();
            this.groupBoxWorkerType = new System.Windows.Forms.GroupBox();
            this.textBoxDirectorAllowance = new System.Windows.Forms.TextBox();
            this.labelCityAllowance = new System.Windows.Forms.Label();
            this.groupBoxDirector = new System.Windows.Forms.GroupBox();
            this.textBoxManagerAllowance = new System.Windows.Forms.TextBox();
            this.labelCarAllowance = new System.Windows.Forms.Label();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.labelHouseAllowance = new System.Windows.Forms.Label();
            this.groupBoxOfficer = new System.Windows.Forms.GroupBox();
            this.textBoxBasicSalary = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.groupBoxWorker = new System.Windows.Forms.GroupBox();
            this.groupBoxWorkerType.SuspendLayout();
            this.groupBoxDirector.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.groupBoxOfficer.SuspendLayout();
            this.groupBoxWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListWorkers
            // 
            this.buttonListWorkers.Location = new System.Drawing.Point(445, 11);
            this.buttonListWorkers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListWorkers.Name = "buttonListWorkers";
            this.buttonListWorkers.Size = new System.Drawing.Size(105, 34);
            this.buttonListWorkers.TabIndex = 15;
            this.buttonListWorkers.Text = "List Workers";
            this.buttonListWorkers.UseVisualStyleBackColor = true;
            this.buttonListWorkers.Click += new System.EventHandler(this.buttonListWorkers_Click);
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(11, 153);
            this.buttonAddWorker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(103, 34);
            this.buttonAddWorker.TabIndex = 14;
            this.buttonAddWorker.Text = "Add Worker";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // radioButtonDirector
            // 
            this.radioButtonDirector.AutoSize = true;
            this.radioButtonDirector.Location = new System.Drawing.Point(4, 94);
            this.radioButtonDirector.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDirector.Name = "radioButtonDirector";
            this.radioButtonDirector.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDirector.TabIndex = 3;
            this.radioButtonDirector.TabStop = true;
            this.radioButtonDirector.Text = "Director";
            this.radioButtonDirector.UseVisualStyleBackColor = true;
            this.radioButtonDirector.Click += new System.EventHandler(this.radioButtonDirector_Click);
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Location = new System.Drawing.Point(4, 72);
            this.radioButtonManager.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(67, 17);
            this.radioButtonManager.TabIndex = 2;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            this.radioButtonManager.Click += new System.EventHandler(this.radioButtonManager_Click);
            // 
            // radioButtonOfficer
            // 
            this.radioButtonOfficer.AutoSize = true;
            this.radioButtonOfficer.Location = new System.Drawing.Point(4, 50);
            this.radioButtonOfficer.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOfficer.Name = "radioButtonOfficer";
            this.radioButtonOfficer.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOfficer.TabIndex = 1;
            this.radioButtonOfficer.TabStop = true;
            this.radioButtonOfficer.Text = "Officer";
            this.radioButtonOfficer.UseVisualStyleBackColor = true;
            this.radioButtonOfficer.Click += new System.EventHandler(this.radioButtonOfficer_Click);
            // 
            // radioButtonWorker
            // 
            this.radioButtonWorker.AutoSize = true;
            this.radioButtonWorker.Checked = true;
            this.radioButtonWorker.Location = new System.Drawing.Point(4, 28);
            this.radioButtonWorker.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWorker.Name = "radioButtonWorker";
            this.radioButtonWorker.Size = new System.Drawing.Size(60, 17);
            this.radioButtonWorker.TabIndex = 0;
            this.radioButtonWorker.TabStop = true;
            this.radioButtonWorker.Text = "Worker";
            this.radioButtonWorker.UseVisualStyleBackColor = true;
            this.radioButtonWorker.CheckedChanged += new System.EventHandler(this.radioButtonWorker_CheckedChanged);
            this.radioButtonWorker.Click += new System.EventHandler(this.radioButtonWorker_Click);
            // 
            // groupBoxWorkerType
            // 
            this.groupBoxWorkerType.Controls.Add(this.radioButtonDirector);
            this.groupBoxWorkerType.Controls.Add(this.radioButtonManager);
            this.groupBoxWorkerType.Controls.Add(this.radioButtonOfficer);
            this.groupBoxWorkerType.Controls.Add(this.radioButtonWorker);
            this.groupBoxWorkerType.Location = new System.Drawing.Point(11, 11);
            this.groupBoxWorkerType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxWorkerType.Name = "groupBoxWorkerType";
            this.groupBoxWorkerType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxWorkerType.Size = new System.Drawing.Size(102, 138);
            this.groupBoxWorkerType.TabIndex = 13;
            this.groupBoxWorkerType.TabStop = false;
            this.groupBoxWorkerType.Text = "Worker type";
            // 
            // textBoxDirectorAllowance
            // 
            this.textBoxDirectorAllowance.Location = new System.Drawing.Point(123, 20);
            this.textBoxDirectorAllowance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDirectorAllowance.Name = "textBoxDirectorAllowance";
            this.textBoxDirectorAllowance.Size = new System.Drawing.Size(136, 20);
            this.textBoxDirectorAllowance.TabIndex = 10;
            this.textBoxDirectorAllowance.Text = "200";
            // 
            // labelCityAllowance
            // 
            this.labelCityAllowance.AutoSize = true;
            this.labelCityAllowance.Location = new System.Drawing.Point(13, 27);
            this.labelCityAllowance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityAllowance.Name = "labelCityAllowance";
            this.labelCityAllowance.Size = new System.Drawing.Size(96, 13);
            this.labelCityAllowance.TabIndex = 3;
            this.labelCityAllowance.Text = "Director Allowance";
            // 
            // groupBoxDirector
            // 
            this.groupBoxDirector.Controls.Add(this.textBoxDirectorAllowance);
            this.groupBoxDirector.Controls.Add(this.labelCityAllowance);
            this.groupBoxDirector.Enabled = false;
            this.groupBoxDirector.Location = new System.Drawing.Point(140, 219);
            this.groupBoxDirector.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDirector.Name = "groupBoxDirector";
            this.groupBoxDirector.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDirector.Size = new System.Drawing.Size(278, 60);
            this.groupBoxDirector.TabIndex = 12;
            this.groupBoxDirector.TabStop = false;
            this.groupBoxDirector.Text = "Director";
            // 
            // textBoxManagerAllowance
            // 
            this.textBoxManagerAllowance.Location = new System.Drawing.Point(123, 26);
            this.textBoxManagerAllowance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxManagerAllowance.Name = "textBoxManagerAllowance";
            this.textBoxManagerAllowance.Size = new System.Drawing.Size(141, 20);
            this.textBoxManagerAllowance.TabIndex = 8;
            this.textBoxManagerAllowance.Text = "100";
            // 
            // labelCarAllowance
            // 
            this.labelCarAllowance.AutoSize = true;
            this.labelCarAllowance.Location = new System.Drawing.Point(13, 29);
            this.labelCarAllowance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarAllowance.Name = "labelCarAllowance";
            this.labelCarAllowance.Size = new System.Drawing.Size(101, 13);
            this.labelCarAllowance.TabIndex = 1;
            this.labelCarAllowance.Text = "Manager Allowance";
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.textBoxManagerAllowance);
            this.groupBoxManager.Controls.Add(this.labelCarAllowance);
            this.groupBoxManager.Enabled = false;
            this.groupBoxManager.Location = new System.Drawing.Point(140, 163);
            this.groupBoxManager.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxManager.Size = new System.Drawing.Size(284, 52);
            this.groupBoxManager.TabIndex = 11;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "Manager";
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Location = new System.Drawing.Point(104, 26);
            this.textBoxBonus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.Size = new System.Drawing.Size(168, 20);
            this.textBoxBonus.TabIndex = 5;
            this.textBoxBonus.Text = "10";
            // 
            // labelHouseAllowance
            // 
            this.labelHouseAllowance.AutoSize = true;
            this.labelHouseAllowance.Location = new System.Drawing.Point(12, 28);
            this.labelHouseAllowance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHouseAllowance.Name = "labelHouseAllowance";
            this.labelHouseAllowance.Size = new System.Drawing.Size(54, 13);
            this.labelHouseAllowance.TabIndex = 0;
            this.labelHouseAllowance.Text = "Bonus (%)";
            // 
            // groupBoxOfficer
            // 
            this.groupBoxOfficer.Controls.Add(this.textBoxBonus);
            this.groupBoxOfficer.Controls.Add(this.labelHouseAllowance);
            this.groupBoxOfficer.Enabled = false;
            this.groupBoxOfficer.Location = new System.Drawing.Point(138, 105);
            this.groupBoxOfficer.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOfficer.Name = "groupBoxOfficer";
            this.groupBoxOfficer.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOfficer.Size = new System.Drawing.Size(286, 54);
            this.groupBoxOfficer.TabIndex = 10;
            this.groupBoxOfficer.TabStop = false;
            this.groupBoxOfficer.Text = "Officer";
            // 
            // textBoxBasicSalary
            // 
            this.textBoxBasicSalary.Location = new System.Drawing.Point(98, 49);
            this.textBoxBasicSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBasicSalary.Name = "textBoxBasicSalary";
            this.textBoxBasicSalary.Size = new System.Drawing.Size(168, 20);
            this.textBoxBasicSalary.TabIndex = 6;
            this.textBoxBasicSalary.Text = "1000";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 28);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "John";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Location = new System.Drawing.Point(9, 54);
            this.labelBasicSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(65, 13);
            this.labelBasicSalary.TabIndex = 2;
            this.labelBasicSalary.Text = "Basic Salary";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(445, 60);
            this.textBoxResults.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResults.Size = new System.Drawing.Size(406, 219);
            this.textBoxResults.TabIndex = 16;
            // 
            // groupBoxWorker
            // 
            this.groupBoxWorker.Controls.Add(this.textBoxBasicSalary);
            this.groupBoxWorker.Controls.Add(this.textBoxName);
            this.groupBoxWorker.Controls.Add(this.labelBasicSalary);
            this.groupBoxWorker.Controls.Add(this.labelName);
            this.groupBoxWorker.Location = new System.Drawing.Point(138, 11);
            this.groupBoxWorker.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxWorker.Name = "groupBoxWorker";
            this.groupBoxWorker.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxWorker.Size = new System.Drawing.Size(284, 89);
            this.groupBoxWorker.TabIndex = 9;
            this.groupBoxWorker.TabStop = false;
            this.groupBoxWorker.Text = "Worker";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 299);
            this.Controls.Add(this.buttonListWorkers);
            this.Controls.Add(this.buttonAddWorker);
            this.Controls.Add(this.groupBoxWorkerType);
            this.Controls.Add(this.groupBoxDirector);
            this.Controls.Add(this.groupBoxManager);
            this.Controls.Add(this.groupBoxOfficer);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.groupBoxWorker);
            this.Name = "MainForm";
            this.Text = "Human Resources";
            this.groupBoxWorkerType.ResumeLayout(false);
            this.groupBoxWorkerType.PerformLayout();
            this.groupBoxDirector.ResumeLayout(false);
            this.groupBoxDirector.PerformLayout();
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            this.groupBoxOfficer.ResumeLayout(false);
            this.groupBoxOfficer.PerformLayout();
            this.groupBoxWorker.ResumeLayout(false);
            this.groupBoxWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonListWorkers;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.RadioButton radioButtonDirector;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonOfficer;
        private System.Windows.Forms.RadioButton radioButtonWorker;
        private System.Windows.Forms.GroupBox groupBoxWorkerType;
        private System.Windows.Forms.TextBox textBoxDirectorAllowance;
        private System.Windows.Forms.Label labelCityAllowance;
        private System.Windows.Forms.GroupBox groupBoxDirector;
        private System.Windows.Forms.TextBox textBoxManagerAllowance;
        private System.Windows.Forms.Label labelCarAllowance;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.TextBox textBoxBonus;
        private System.Windows.Forms.Label labelHouseAllowance;
        private System.Windows.Forms.GroupBox groupBoxOfficer;
        private System.Windows.Forms.TextBox textBoxBasicSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.GroupBox groupBoxWorker;
    }
}

