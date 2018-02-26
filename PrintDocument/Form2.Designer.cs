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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DateOfTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RemoveSelectedProfile = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.textBox_FindByLastName = new System.Windows.Forms.TextBox();
            this.textBox_FindByFirstName = new System.Windows.Forms.TextBox();
            this.button_Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CountProfiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_LastName,
            this.Column_FirstName,
            this.Column_DateOfTime});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 503);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_LastName.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_LastName.HeaderText = "Фамилия";
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            this.Column_LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_LastName.Width = 250;
            // 
            // Column_FirstName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_FirstName.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_FirstName.HeaderText = "Имя";
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.ReadOnly = true;
            this.Column_FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_FirstName.Width = 240;
            // 
            // Column_DateOfTime
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Column_DateOfTime.DefaultCellStyle = dataGridViewCellStyle3;
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
            // textBox_FindByLastName
            // 
            this.textBox_FindByLastName.Location = new System.Drawing.Point(0, 25);
            this.textBox_FindByLastName.Name = "textBox_FindByLastName";
            this.textBox_FindByLastName.Size = new System.Drawing.Size(252, 20);
            this.textBox_FindByLastName.TabIndex = 282;
            // 
            // textBox_FindByFirstName
            // 
            this.textBox_FindByFirstName.Location = new System.Drawing.Point(258, 25);
            this.textBox_FindByFirstName.Name = "textBox_FindByFirstName";
            this.textBox_FindByFirstName.Size = new System.Drawing.Size(233, 20);
            this.textBox_FindByFirstName.TabIndex = 283;
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(497, 25);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(85, 20);
            this.button_Find.TabIndex = 284;
            this.button_Find.Text = "Поиск";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 285;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 286;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(209, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 287;
            this.label3.Text = "Анкет в списке:";
            // 
            // label_CountProfiles
            // 
            this.label_CountProfiles.AutoSize = true;
            this.label_CountProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CountProfiles.Location = new System.Drawing.Point(339, 586);
            this.label_CountProfiles.Name = "label_CountProfiles";
            this.label_CountProfiles.Size = new System.Drawing.Size(64, 16);
            this.label_CountProfiles.TabIndex = 288;
            this.label_CountProfiles.Text = "9999999";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 626);
            this.Controls.Add(this.label_CountProfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.textBox_FindByFirstName);
            this.Controls.Add(this.textBox_FindByLastName);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_RemoveSelectedProfile;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DateOfTime;
        private System.Windows.Forms.TextBox textBox_FindByLastName;
        private System.Windows.Forms.TextBox textBox_FindByFirstName;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CountProfiles;
    }
}