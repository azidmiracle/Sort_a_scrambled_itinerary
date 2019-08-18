namespace Sort_a_scrambled_itinerary
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
            this.btn_Browse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrint = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(168, 12);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(92, 32);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Sort";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelPrint);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 212);
            this.panel1.TabIndex = 2;
            // 
            // labelPrint
            // 
            this.labelPrint.AutoSize = true;
            this.labelPrint.Location = new System.Drawing.Point(3, 12);
            this.labelPrint.Name = "labelPrint";
            this.labelPrint.Size = new System.Drawing.Size(0, 13);
            this.labelPrint.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Browse);
            this.Name = "Form1";
            this.Text = "Sort Itinerary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrint;
    }
}

