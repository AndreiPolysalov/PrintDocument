namespace PrintDocument
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DateOfTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RemoveSelectedProfile = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_LastName,
            this.Column_FirstName,
            this.Column_DateOfTime});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ProfileID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.Visible = false;
            this.Column_ID.Width = 30;
            // 
            // Column_LastName
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_LastName.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_LastName.HeaderText = "Фамилия";
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            this.Column_LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_LastName.Width = 250;
            // 
            // Column_FirstName
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_FirstName.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_FirstName.HeaderText = "Имя";
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.ReadOnly = true;
            this.Column_FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_FirstName.Width = 240;
            // 
            // Column_DateOfTime
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_DateOfTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column_DateOfTime.HeaderText = "Дата рождения";
            this.Column_DateOfTime.Name = "Column_DateOfTime";
            this.Column_DateOfTime.ReadOnly = true;
            this.Column_DateOfTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_DateOfTime.Width = 90;
            // 
            // button_RemoveSelectedProfile
            // 
            this.button_RemoveSelectedProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_RemoveSelectedProfile.Location = new System.Drawing.Point(423, 574);
            this.button_RemoveSelectedProfile.Name = "button_RemoveSelectedProfile";
            this.button_RemoveSelectedProfile.Size = new System.Drawing.Size(175, 40);
            this.button_RemoveSelectedProfile.TabIndex = 280;
            this.button_RemoveSelectedProfile.Text = "Удалить выбранную анкету";
            this.button_RemoveSelectedProfile.UseVisualStyleBackColor = true;
            this.button_RemoveSelectedProfile.Click += new System.EventHandler(this.button_RemoveSelectedProfile_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button.Location = new System.Drawing.Point(12, 574);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(175, 40);
            this.button.TabIndex = 281;
            this.button.Text = "Открыть выбранную анкету";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_OpenSelectedProfile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 626);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button_RemoveSelectedProfile);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкеты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_RemoveSelectedProfile;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DateOfTime;
    }
}