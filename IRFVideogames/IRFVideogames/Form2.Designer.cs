namespace IRFVideogames
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IGNbtn = new System.Windows.Forms.Button();
            this.datebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 726);
            this.dataGridView1.TabIndex = 1;
            // 
            // IGNbtn
            // 
            this.IGNbtn.Location = new System.Drawing.Point(1, 158);
            this.IGNbtn.Name = "IGNbtn";
            this.IGNbtn.Size = new System.Drawing.Size(154, 87);
            this.IGNbtn.TabIndex = 2;
            this.IGNbtn.Text = "Top játékok (IGN:9-10)";
            this.IGNbtn.UseVisualStyleBackColor = true;
            this.IGNbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // datebtn
            // 
            this.datebtn.Location = new System.Drawing.Point(1, 290);
            this.datebtn.Name = "datebtn";
            this.datebtn.Size = new System.Drawing.Size(154, 87);
            this.datebtn.TabIndex = 3;
            this.datebtn.Text = "Elmúlt 5 év játékai (2015-)";
            this.datebtn.UseVisualStyleBackColor = true;
            this.datebtn.Click += new System.EventHandler(this.datebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Multiplayer játékok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Minden játék mutatása (Alapértelmezett)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datebtn);
            this.Controls.Add(this.IGNbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IGNbtn;
        private System.Windows.Forms.Button datebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}