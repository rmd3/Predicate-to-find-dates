
namespace D_Anjolell_13_5
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lstbxDates = new System.Windows.Forms.ListBox();
            this.txtbxFirst = new System.Windows.Forms.TextBox();
            this.txtbxAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFirst.Location = new System.Drawing.Point(172, 136);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(132, 45);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First Date";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAll.Location = new System.Drawing.Point(172, 308);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(132, 42);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Dates";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lstbxDates
            // 
            this.lstbxDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstbxDates.FormattingEnabled = true;
            this.lstbxDates.ItemHeight = 29;
            this.lstbxDates.Location = new System.Drawing.Point(471, 12);
            this.lstbxDates.Name = "lstbxDates";
            this.lstbxDates.Size = new System.Drawing.Size(258, 439);
            this.lstbxDates.TabIndex = 2;
            // 
            // txtbxFirst
            // 
            this.txtbxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtbxFirst.Location = new System.Drawing.Point(157, 81);
            this.txtbxFirst.Name = "txtbxFirst";
            this.txtbxFirst.Size = new System.Drawing.Size(163, 34);
            this.txtbxFirst.TabIndex = 3;
            // 
            // txtbxAll
            // 
            this.txtbxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtbxAll.Location = new System.Drawing.Point(157, 254);
            this.txtbxAll.Name = "txtbxAll";
            this.txtbxAll.Size = new System.Drawing.Size(163, 34);
            this.txtbxAll.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxAll);
            this.Controls.Add(this.txtbxFirst);
            this.Controls.Add(this.lstbxDates);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListBox lstbxDates;
        private System.Windows.Forms.TextBox txtbxFirst;
        private System.Windows.Forms.TextBox txtbxAll;
    }
}

