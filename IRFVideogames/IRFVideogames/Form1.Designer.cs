namespace IRFVideogames
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
            this.VideogameDataSet = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.cím = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideogameDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VideogameDataSet
            // 
            this.VideogameDataSet.DataSetName = "VideogameDataSet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(496, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to csv";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cím
            // 
            this.cím.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cím.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cím.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cím.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cím.Location = new System.Drawing.Point(76, 33);
            this.cím.Name = "cím";
            this.cím.Size = new System.Drawing.Size(1061, 164);
            this.cím.TabIndex = 2;
            this.cím.Text = "Ez a program a videójátékpiacon végzett saját kutatásomból alkotott adatbázis egy" +
    " részét hivatásos bemutatni!";
            this.cím.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1419, 692);
            this.Controls.Add(this.cím);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.VideogameDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet VideogameDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cím;
    }
}

