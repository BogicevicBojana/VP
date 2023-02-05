namespace PresentationLayer.UserControls.ProjectManager
{
    partial class UC_Tasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.checkBox_Mine = new System.Windows.Forms.CheckBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_manager_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_spent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pregled zadataka";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date_issued,
            this.date_due,
            this.project_manager_id,
            this.team_member,
            this.title,
            this.is_completed,
            this.description,
            this.hours_spent,
            this.team_member_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 142);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 627);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdateRecord.FlatAppearance.BorderSize = 0;
            this.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecord.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRecord.Location = new System.Drawing.Point(841, 34);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(163, 44);
            this.btnUpdateRecord.TabIndex = 16;
            this.btnUpdateRecord.Text = "Izmeni zapis";
            this.btnUpdateRecord.UseVisualStyleBackColor = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Sienna;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1023, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Obriši zapis";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkBox_Mine
            // 
            this.checkBox_Mine.AutoSize = true;
            this.checkBox_Mine.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mine.ForeColor = System.Drawing.Color.White;
            this.checkBox_Mine.Location = new System.Drawing.Point(35, 95);
            this.checkBox_Mine.Name = "checkBox_Mine";
            this.checkBox_Mine.Size = new System.Drawing.Size(365, 25);
            this.checkBox_Mine.TabIndex = 17;
            this.checkBox_Mine.Text = "Prikaži samo zadatke koje sam ja kreirao";
            this.checkBox_Mine.UseVisualStyleBackColor = true;
            this.checkBox_Mine.CheckedChanged += new System.EventHandler(this.checkBox_Mine_CheckedChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(660, 34);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(163, 44);
            this.btnAddTask.TabIndex = 18;
            this.btnAddTask.Text = "Dodaj zapis";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 52;
            // 
            // date_issued
            // 
            this.date_issued.HeaderText = "Kreiran";
            this.date_issued.MinimumWidth = 6;
            this.date_issued.Name = "date_issued";
            this.date_issued.ReadOnly = true;
            // 
            // date_due
            // 
            this.date_due.HeaderText = "Rok";
            this.date_due.MinimumWidth = 6;
            this.date_due.Name = "date_due";
            this.date_due.ReadOnly = true;
            // 
            // project_manager_id
            // 
            this.project_manager_id.HeaderText = "PM ID";
            this.project_manager_id.MinimumWidth = 6;
            this.project_manager_id.Name = "project_manager_id";
            this.project_manager_id.ReadOnly = true;
            this.project_manager_id.Visible = false;
            // 
            // team_member
            // 
            this.team_member.HeaderText = "Zaduženi";
            this.team_member.MinimumWidth = 6;
            this.team_member.Name = "team_member";
            this.team_member.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Naziv";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // is_completed
            // 
            this.is_completed.HeaderText = "Završen";
            this.is_completed.MinimumWidth = 6;
            this.is_completed.Name = "is_completed";
            this.is_completed.ReadOnly = true;
            this.is_completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // description
            // 
            this.description.HeaderText = "Opis";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // hours_spent
            // 
            this.hours_spent.HeaderText = "Utrošeno sati";
            this.hours_spent.MinimumWidth = 6;
            this.hours_spent.Name = "hours_spent";
            this.hours_spent.ReadOnly = true;
            this.hours_spent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hours_spent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // team_member_id
            // 
            this.team_member_id.HeaderText = "TeamMemberId";
            this.team_member_id.MinimumWidth = 6;
            this.team_member_id.Name = "team_member_id";
            this.team_member_id.ReadOnly = true;
            this.team_member_id.Visible = false;
            // 
            // UC_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.checkBox_Mine);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Name = "UC_Tasks";
            this.Size = new System.Drawing.Size(1208, 769);
            this.Load += new System.EventHandler(this.UC_Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBox_Mine;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_due;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_manager_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_spent;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_member_id;
    }
}
