namespace IRFVideogames
{
    partial class Form3
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
            this.gamenamebox = new System.Windows.Forms.TextBox();
            this.yearlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 772);
            this.dataGridView1.TabIndex = 0;
            // 
            // gamenamebox
            // 
            this.gamenamebox.Location = new System.Drawing.Point(12, 473);
            this.gamenamebox.Name = "gamenamebox";
            this.gamenamebox.Size = new System.Drawing.Size(203, 22);
            this.gamenamebox.TabIndex = 1;
            this.gamenamebox.TextChanged += new System.EventHandler(this.gamenamebox_TextChanged);
            // 
            // yearlistBox
            // 
            this.yearlistBox.FormattingEnabled = true;
            this.yearlistBox.ItemHeight = 16;
            this.yearlistBox.Location = new System.Drawing.Point(12, 71);
            this.yearlistBox.Name = "yearlistBox";
            this.yearlistBox.Size = new System.Drawing.Size(203, 340);
            this.yearlistBox.TabIndex = 2;
            this.yearlistBox.SelectedIndexChanged += new System.EventHandler(this.gamelistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Itt megjelenési év szerint tudod szűrni a felvett videójátékokat, illetve név sze" +
    "rint is. Az évjáratot a listából tudod kiválasztani, a nevet pedig önállóan kell" +
    " begépelni a szövegdobozba.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 771);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearlistBox);
            this.Controls.Add(this.gamenamebox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox gamenamebox;
        private System.Windows.Forms.ListBox yearlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}