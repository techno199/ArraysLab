namespace ArraysResolver
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.dataGridViewArrays = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.buttonEvaluateTaskSeven = new System.Windows.Forms.Button();
            this.evaluateTaskSevenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem,
            this.evaluateTaskSevenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randomizeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.randomizeToolStripMenuItem.Text = "Заполнить массивы";
            this.randomizeToolStripMenuItem.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandomize.Location = new System.Drawing.Point(13, 521);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(155, 23);
            this.buttonRandomize.TabIndex = 1;
            this.buttonRandomize.Text = "Заполнить массивы";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // dataGridViewArrays
            // 
            this.dataGridViewArrays.AllowUserToAddRows = false;
            this.dataGridViewArrays.AllowUserToDeleteRows = false;
            this.dataGridViewArrays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArrays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrays.Location = new System.Drawing.Point(13, 27);
            this.dataGridViewArrays.Name = "dataGridViewArrays";
            this.dataGridViewArrays.Size = new System.Drawing.Size(901, 487);
            this.dataGridViewArrays.TabIndex = 2;
            this.dataGridViewArrays.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArrays_CellValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Столбцы";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строки";
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownColumns.Location = new System.Drawing.Point(983, 28);
            this.numericUpDownColumns.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownColumns.TabIndex = 5;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownRows.Location = new System.Drawing.Point(983, 54);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownRows.TabIndex = 6;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // buttonEvaluateTaskSeven
            // 
            this.buttonEvaluateTaskSeven.Location = new System.Drawing.Point(175, 521);
            this.buttonEvaluateTaskSeven.Name = "buttonEvaluateTaskSeven";
            this.buttonEvaluateTaskSeven.Size = new System.Drawing.Size(158, 23);
            this.buttonEvaluateTaskSeven.TabIndex = 7;
            this.buttonEvaluateTaskSeven.Text = "Посчитать задачу 7";
            this.buttonEvaluateTaskSeven.UseVisualStyleBackColor = true;
            this.buttonEvaluateTaskSeven.Click += new System.EventHandler(this.buttonEvaluateTaskSeven_Click);
            // 
            // evaluateTaskSevenToolStripMenuItem
            // 
            this.evaluateTaskSevenToolStripMenuItem.Name = "evaluateTaskSevenToolStripMenuItem";
            this.evaluateTaskSevenToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.evaluateTaskSevenToolStripMenuItem.Text = "Посчитать седьмую задачу";
            this.evaluateTaskSevenToolStripMenuItem.Click += new System.EventHandler(this.evaluateTaskSevenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 556);
            this.Controls.Add(this.buttonEvaluateTaskSeven);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewArrays);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.DataGridView dataGridViewArrays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Button buttonEvaluateTaskSeven;
        private System.Windows.Forms.ToolStripMenuItem evaluateTaskSevenToolStripMenuItem;
    }
}

