using System;

namespace AudioRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_out = new System.Windows.Forms.Button();
            this.stop_out = new System.Windows.Forms.Button();
            this.stop_in = new System.Windows.Forms.Button();
            this.start_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_out
            // 
            this.start_out.Location = new System.Drawing.Point(16, 15);
            this.start_out.Margin = new System.Windows.Forms.Padding(4);
            this.start_out.Name = "start_out";
            this.start_out.Size = new System.Drawing.Size(130, 27);
            this.start_out.TabIndex = 0;
            this.start_out.Text = "start (audio out)";
            this.start_out.UseVisualStyleBackColor = true;
            this.start_out.Click += new System.EventHandler(this.start_out_Click);
            // 
            // stop_out
            // 
            this.stop_out.Location = new System.Drawing.Point(16, 49);
            this.stop_out.Margin = new System.Windows.Forms.Padding(4);
            this.stop_out.Name = "stop_out";
            this.stop_out.Size = new System.Drawing.Size(130, 27);
            this.stop_out.TabIndex = 1;
            this.stop_out.Text = "stop (audio out)";
            this.stop_out.UseVisualStyleBackColor = true;
            this.stop_out.Click += new System.EventHandler(this.stop_out_Click);
            // 
            // stop_in
            // 
            this.stop_in.Location = new System.Drawing.Point(154, 49);
            this.stop_in.Margin = new System.Windows.Forms.Padding(4);
            this.stop_in.Name = "stop_in";
            this.stop_in.Size = new System.Drawing.Size(130, 27);
            this.stop_in.TabIndex = 3;
            this.stop_in.Text = "stop (audio in)";
            this.stop_in.UseVisualStyleBackColor = true;
            this.stop_in.Click += new System.EventHandler(this.stop_in_Click);
            // 
            // start_in
            // 
            this.start_in.Location = new System.Drawing.Point(154, 15);
            this.start_in.Margin = new System.Windows.Forms.Padding(4);
            this.start_in.Name = "start_in";
            this.start_in.Size = new System.Drawing.Size(130, 27);
            this.start_in.TabIndex = 2;
            this.start_in.Text = "start (audio in)";
            this.start_in.UseVisualStyleBackColor = true;
            this.start_in.Click += new System.EventHandler(this.start_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 89);
            this.Controls.Add(this.stop_in);
            this.Controls.Add(this.start_in);
            this.Controls.Add(this.stop_out);
            this.Controls.Add(this.start_out);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 136);
            this.MinimumSize = new System.Drawing.Size(320, 136);
            this.Name = "Form1";
            this.Text = "Audio driver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_out;
        private System.Windows.Forms.Button stop_out;
        private System.Windows.Forms.Button stop_in;
        private System.Windows.Forms.Button start_in;
    }
}

