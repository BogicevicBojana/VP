namespace PresentationLayer.UserControls.ProjectManager
{
    partial class UC_TeamMembers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personal_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uncompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_spent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.taskManagementDBDataSet = new PresentationLayer.TaskManagementDBDataSet();
            this.projectManagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_ManagersTableAdapter = new PresentationLayer.TaskManagementDBDataSetTableAdapters.Project_ManagersTableAdapter();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.first_name,
            this.last_name,
            this.personal_number,
            this.emp_date,
            this.place_of_birth,
            this.employment_date,
            this.email,
            this.Password,
            this.phone_number,
            this.completed,
            this.uncompleted,
            this.hours_spent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 624);
            this.dataGridView1.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Ime";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Prezime";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // personal_number
            // 
            this.personal_number.HeaderText = "Lični broj";
            this.personal_number.MinimumWidth = 6;
            this.personal_number.Name = "personal_number";
            this.personal_number.ReadOnly = true;
            this.personal_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personal_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // emp_date
            // 
            this.emp_date.HeaderText = "Datum rođenja";
            this.emp_date.MinimumWidth = 6;
            this.emp_date.Name = "emp_date";
            this.emp_date.ReadOnly = true;
            // 
            // place_of_birth
            // 
            this.place_of_birth.HeaderText = "Mesto rođenja";
            this.place_of_birth.MinimumWidth = 6;
            this.place_of_birth.Name = "place_of_birth";
            this.place_of_birth.ReadOnly = true;
            // 
            // employment_date
            // 
            this.employment_date.HeaderText = "Datum zaposlenja";
            this.employment_date.MinimumWidth = 6;
            this.employment_date.Name = "employment_date";
            this.employment_date.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            this.Password.HeaderText = "Lozinka";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Broj telefona";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phone_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // completed
            // 
            this.completed.HeaderText = "Završeno";
            this.completed.MinimumWidth = 6;
            this.completed.Name = "completed";
            this.completed.ReadOnly = true;
            // 
            // uncompleted
            // 
            this.uncompleted.HeaderText = "Nezavršeno";
            this.uncompleted.MinimumWidth = 6;
            this.uncompleted.Name = "uncompleted";
            this.uncompleted.ReadOnly = true;
            // 
            // hours_spent
            // 
            this.hours_spent.HeaderText = "Potrošeno sati";
            this.hours_spent.MinimumWidth = 6;
            this.hours_spent.Name = "hours_spent";
            this.hours_spent.ReadOnly = true;
            this.hours_spent.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pregled članova tima";
            // 
            // taskManagementDBDataSet
            // 
            this.taskManagementDBDataSet.DataSetName = "TaskManagementDBDataSet";
            this.taskManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectManagersBindingSource
            // 
            this.projectManagersBindingSource.DataMember = "Project_Managers";
            this.projectManagersBindingSource.DataSource = this.taskManagementDBDataSet;
            // 
            // project_ManagersTableAdapter
            // 
            this.project_ManagersTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUpdateRecord.FlatAppearance.BorderSize = 0;
            this.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecord.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRecord.Location = new System.Drawing.Point(844, 31);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(163, 44);
            this.btnUpdateRecord.TabIndex = 13;
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
            this.btnDelete.Location = new System.Drawing.Point(1026, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 44);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Obriši zapis";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UC_TeamMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnDelete);
            this.Name = "UC_TeamMembers";
            this.Size = new System.Drawing.Size(1208, 748);
            this.Load += new System.EventHandler(this.UC_TeamMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private TaskManagementDBDataSet taskManagementDBDataSet;
        private System.Windows.Forms.BindingSource projectManagersBindingSource;
        private TaskManagementDBDataSetTableAdapters.Project_ManagersTableAdapter project_ManagersTableAdapter;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn personal_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn employment_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn uncompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_spent;
    }
}
