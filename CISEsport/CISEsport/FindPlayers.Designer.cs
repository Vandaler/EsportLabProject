namespace CISEsport
{
    partial class FindPlayers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisplayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitclickk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnStudentID,
            this.ColumnMajor,
            this.ColumnDisplayname,
            this.ColumnEmail,
            this.ColumnPhoneNum,
            this.ColumnAge});
            this.dataGridView1.Location = new System.Drawing.Point(44, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(712, 386);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.DataPropertyName = "Studentid";
            this.ColumnStudentID.HeaderText = "StudentID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.DataPropertyName = "Major";
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.Name = "ColumnMajor";
            // 
            // ColumnDisplayname
            // 
            this.ColumnDisplayname.DataPropertyName = "Displayname";
            this.ColumnDisplayname.HeaderText = "Displayname";
            this.ColumnDisplayname.Name = "ColumnDisplayname";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "Mail";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnPhoneNum
            // 
            this.ColumnPhoneNum.DataPropertyName = "Phonenum";
            this.ColumnPhoneNum.HeaderText = "Phone Number";
            this.ColumnPhoneNum.Name = "ColumnPhoneNum";
            // 
            // ColumnAge
            // 
            this.ColumnAge.DataPropertyName = "Age";
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            // 
            // submitclickk
            // 
            this.submitclickk.Location = new System.Drawing.Point(337, 411);
            this.submitclickk.Name = "submitclickk";
            this.submitclickk.Size = new System.Drawing.Size(121, 38);
            this.submitclickk.TabIndex = 8;
            this.submitclickk.Text = "Submit";
            this.submitclickk.UseVisualStyleBackColor = true;
            this.submitclickk.Click += new System.EventHandler(this.submitclickk_Click);
            // 
            // FindPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.submitclickk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindPlayers";
            this.Text = "FindPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnStudentID;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnDisplayname;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhoneNum;
        private DataGridViewTextBoxColumn ColumnAge;
        private Button submitclickk;
    }
}