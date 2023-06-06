namespace pryBenjaLangSp1Login
{
    partial class frmSinterpartSRL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinterpartSRL));
            this.lblBienvewnido = new System.Windows.Forms.Label();
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvewnido
            // 
            this.lblBienvewnido.AutoSize = true;
            this.lblBienvewnido.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvewnido.Location = new System.Drawing.Point(81, 39);
            this.lblBienvewnido.Name = "lblBienvewnido";
            this.lblBienvewnido.Size = new System.Drawing.Size(584, 54);
            this.lblBienvewnido.TabIndex = 0;
            this.lblBienvewnido.Text = "Bienvenido SinterpartSRL";
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.Location = new System.Drawing.Point(249, 96);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(182, 38);
            this.cmdIniciar.TabIndex = 1;
            this.cmdIniciar.Text = "Iniciar";
            this.cmdIniciar.UseVisualStyleBackColor = true;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // frmSinterpartSRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 160);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.lblBienvewnido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSinterpartSRL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinterpartSRL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvewnido;
        private System.Windows.Forms.Button cmdIniciar;
    }
}