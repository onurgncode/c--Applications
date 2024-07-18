namespace timerForm
{
    partial class djitalSaat
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
            this.Lblsaat = new System.Windows.Forms.Label();
            this.Lbldk = new System.Windows.Forms.Label();
            this.Lblsaniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lblsaat
            // 
            this.Lblsaat.AutoSize = true;
            this.Lblsaat.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsaat.Location = new System.Drawing.Point(34, 39);
            this.Lblsaat.Name = "Lblsaat";
            this.Lblsaat.Size = new System.Drawing.Size(33, 35);
            this.Lblsaat.TabIndex = 0;
            this.Lblsaat.Text = "0";
            // 
            // Lbldk
            // 
            this.Lbldk.AutoSize = true;
            this.Lbldk.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldk.Location = new System.Drawing.Point(73, 39);
            this.Lbldk.Name = "Lbldk";
            this.Lbldk.Size = new System.Drawing.Size(33, 35);
            this.Lbldk.TabIndex = 1;
            this.Lbldk.Text = "0";
            // 
            // Lblsaniye
            // 
            this.Lblsaniye.AutoSize = true;
            this.Lblsaniye.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsaniye.Location = new System.Drawing.Point(118, 39);
            this.Lblsaniye.Name = "Lblsaniye";
            this.Lblsaniye.Size = new System.Drawing.Size(33, 35);
            this.Lblsaniye.TabIndex = 2;
            this.Lblsaniye.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // djitalSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.Lblsaniye);
            this.Controls.Add(this.Lbldk);
            this.Controls.Add(this.Lblsaat);
            this.Name = "djitalSaat";
            this.Text = "djitalSaat";
            this.Load += new System.EventHandler(this.djitalSaat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblsaat;
        private System.Windows.Forms.Label Lbldk;
        private System.Windows.Forms.Label Lblsaniye;
        private System.Windows.Forms.Timer timer1;
    }
}