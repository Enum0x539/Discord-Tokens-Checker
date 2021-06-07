
namespace Discord_Tokens_Checker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadFromCopyboard = new System.Windows.Forms.Button();
            this.LoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(-100, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 5);
            this.panel1.TabIndex = 0;
            // 
            // LoadFromCopyboard
            // 
            this.LoadFromCopyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LoadFromCopyboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromCopyboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromCopyboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromCopyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadFromCopyboard.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFromCopyboard.ForeColor = System.Drawing.Color.Red;
            this.LoadFromCopyboard.Location = new System.Drawing.Point(54, 12);
            this.LoadFromCopyboard.Name = "LoadFromCopyboard";
            this.LoadFromCopyboard.Size = new System.Drawing.Size(192, 39);
            this.LoadFromCopyboard.TabIndex = 4;
            this.LoadFromCopyboard.Text = "Load from clipboard";
            this.LoadFromCopyboard.UseVisualStyleBackColor = false;
            this.LoadFromCopyboard.Click += new System.EventHandler(this.LoadFromCopyboard_Click);
            // 
            // LoadFromFile
            // 
            this.LoadFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LoadFromFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadFromFile.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFromFile.ForeColor = System.Drawing.Color.Red;
            this.LoadFromFile.Location = new System.Drawing.Point(54, 68);
            this.LoadFromFile.Name = "LoadFromFile";
            this.LoadFromFile.Size = new System.Drawing.Size(192, 39);
            this.LoadFromFile.TabIndex = 5;
            this.LoadFromFile.Text = "Load from file";
            this.LoadFromFile.UseVisualStyleBackColor = false;
            this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(300, 119);
            this.Controls.Add(this.LoadFromFile);
            this.Controls.Add(this.LoadFromCopyboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoadFromCopyboard;
        private System.Windows.Forms.Button LoadFromFile;
    }
}