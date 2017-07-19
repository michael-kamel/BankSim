namespace game_Simulation
{
    partial class Sim_Options
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
            this.btn_Apply = new System.Windows.Forms.Button();
            this.teller_Clock_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_intercations_lbl = new System.Windows.Forms.Label();
            this.client_Clock_txt = new System.Windows.Forms.TextBox();
            this.clock_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(309, 96);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 0;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // teller_Clock_txt
            // 
            this.teller_Clock_txt.Location = new System.Drawing.Point(12, 40);
            this.teller_Clock_txt.Name = "teller_Clock_txt";
            this.teller_Clock_txt.Size = new System.Drawing.Size(100, 20);
            this.teller_Clock_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teller_Interactions Seconds";
            // 
            // Client_intercations_lbl
            // 
            this.Client_intercations_lbl.AutoSize = true;
            this.Client_intercations_lbl.Location = new System.Drawing.Point(118, 69);
            this.Client_intercations_lbl.Name = "Client_intercations_lbl";
            this.Client_intercations_lbl.Size = new System.Drawing.Size(141, 13);
            this.Client_intercations_lbl.TabIndex = 4;
            this.Client_intercations_lbl.Text = "Client_Interactions Seconds";
            // 
            // client_Clock_txt
            // 
            this.client_Clock_txt.Location = new System.Drawing.Point(12, 66);
            this.client_Clock_txt.Name = "client_Clock_txt";
            this.client_Clock_txt.Size = new System.Drawing.Size(100, 20);
            this.client_Clock_txt.TabIndex = 3;
            // 
            // clock_txt
            // 
            this.clock_txt.Location = new System.Drawing.Point(12, 14);
            this.clock_txt.Name = "clock_txt";
            this.clock_txt.Size = new System.Drawing.Size(100, 20);
            this.clock_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clock Speed";
            // 
            // Sim_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clock_txt);
            this.Controls.Add(this.Client_intercations_lbl);
            this.Controls.Add(this.client_Clock_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teller_Clock_txt);
            this.Controls.Add(this.btn_Apply);
            this.Name = "Sim_Options";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.TextBox teller_Clock_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Client_intercations_lbl;
        private System.Windows.Forms.TextBox client_Clock_txt;
        private System.Windows.Forms.TextBox clock_txt;
        private System.Windows.Forms.Label label2;
    }
}