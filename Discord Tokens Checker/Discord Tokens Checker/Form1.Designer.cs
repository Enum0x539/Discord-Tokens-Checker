
namespace Discord_Tokens_Checker
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RainbowLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.ChangeOutputPathButton = new System.Windows.Forms.Button();
            this.InputTokensButton = new System.Windows.Forms.Button();
            this.OutputFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutPutTextBox = new System.Windows.Forms.RichTextBox();
            this.TimerRGB = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.RainbowLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 58);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(532, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 29);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RainbowLabel
            // 
            this.RainbowLabel.AutoSize = true;
            this.RainbowLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainbowLabel.ForeColor = System.Drawing.Color.White;
            this.RainbowLabel.Location = new System.Drawing.Point(30, 14);
            this.RainbowLabel.Name = "RainbowLabel";
            this.RainbowLabel.Size = new System.Drawing.Size(505, 32);
            this.RainbowLabel.TabIndex = 1;
            this.RainbowLabel.Text = "Loaded: 0; Working: 0; Unverified: 0;  Invaild: 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Controls.Add(this.ChangeOutputPathButton);
            this.panel2.Controls.Add(this.InputTokensButton);
            this.panel2.Controls.Add(this.OutputFilePath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 69);
            this.panel2.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.LightGreen;
            this.StartButton.Location = new System.Drawing.Point(355, 36);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start Checking";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChangeOutputPathButton
            // 
            this.ChangeOutputPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChangeOutputPathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChangeOutputPathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChangeOutputPathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChangeOutputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeOutputPathButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeOutputPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChangeOutputPathButton.Location = new System.Drawing.Point(99, 37);
            this.ChangeOutputPathButton.Name = "ChangeOutputPathButton";
            this.ChangeOutputPathButton.Size = new System.Drawing.Size(133, 23);
            this.ChangeOutputPathButton.TabIndex = 4;
            this.ChangeOutputPathButton.Text = "Change output path";
            this.ChangeOutputPathButton.UseVisualStyleBackColor = false;
            this.ChangeOutputPathButton.Click += new System.EventHandler(this.ChangeOutputPathButton_Click);
            // 
            // InputTokensButton
            // 
            this.InputTokensButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InputTokensButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InputTokensButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InputTokensButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InputTokensButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputTokensButton.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTokensButton.ForeColor = System.Drawing.Color.Red;
            this.InputTokensButton.Location = new System.Drawing.Point(238, 37);
            this.InputTokensButton.Name = "InputTokensButton";
            this.InputTokensButton.Size = new System.Drawing.Size(111, 23);
            this.InputTokensButton.TabIndex = 3;
            this.InputTokensButton.Text = "Input Tokens";
            this.InputTokensButton.UseVisualStyleBackColor = false;
            this.InputTokensButton.Click += new System.EventHandler(this.InputTokensButton_Click);
            // 
            // OutputFilePath
            // 
            this.OutputFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OutputFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputFilePath.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OutputFilePath.Location = new System.Drawing.Point(94, 10);
            this.OutputFilePath.Name = "OutputFilePath";
            this.OutputFilePath.Size = new System.Drawing.Size(461, 18);
            this.OutputFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results:";
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OutPutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutPutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OutPutTextBox.Location = new System.Drawing.Point(0, 167);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.ReadOnly = true;
            this.OutPutTextBox.Size = new System.Drawing.Size(565, 271);
            this.OutPutTextBox.TabIndex = 4;
            this.OutPutTextBox.Text = "";
            this.OutPutTextBox.TextChanged += new System.EventHandler(this.OutPutTextBox_TextChanged);
            // 
            // TimerRGB
            // 
            this.TimerRGB.Enabled = true;
            this.TimerRGB.Interval = 5;
            this.TimerRGB.Tick += new System.EventHandler(this.TimerRGB_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(565, 440);
            this.Controls.Add(this.OutPutTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Tokens Check | Tex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RainbowLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ChangeOutputPathButton;
        private System.Windows.Forms.Button InputTokensButton;
        private System.Windows.Forms.TextBox OutputFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox OutPutTextBox;
        private System.Windows.Forms.Timer TimerRGB;
    }
}