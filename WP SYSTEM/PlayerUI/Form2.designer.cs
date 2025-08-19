namespace PlayerUI
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
            this.button5 = new System.Windows.Forms.Button();
            this.panelGestionMateriales = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelMaterialesLista = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelGestionMateriales
            // 
            this.panelGestionMateriales.BackColor = System.Drawing.Color.Transparent;
            this.panelGestionMateriales.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGestionMateriales.FillColor = System.Drawing.Color.White;
            this.panelGestionMateriales.Location = new System.Drawing.Point(0, 0);
            this.panelGestionMateriales.Name = "panelGestionMateriales";
            this.panelGestionMateriales.ShadowColor = System.Drawing.Color.Black;
            this.panelGestionMateriales.Size = new System.Drawing.Size(277, 556);
            this.panelGestionMateriales.TabIndex = 8;
            // 
            // panelMaterialesLista
            // 
            this.panelMaterialesLista.BackColor = System.Drawing.Color.Transparent;
            this.panelMaterialesLista.FillColor = System.Drawing.Color.White;
            this.panelMaterialesLista.Location = new System.Drawing.Point(304, 48);
            this.panelMaterialesLista.Name = "panelMaterialesLista";
            this.panelMaterialesLista.ShadowColor = System.Drawing.Color.Black;
            this.panelMaterialesLista.Size = new System.Drawing.Size(565, 496);
            this.panelMaterialesLista.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(881, 556);
            this.Controls.Add(this.panelMaterialesLista);
            this.Controls.Add(this.panelGestionMateriales);
            this.Controls.Add(this.button5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelGestionMateriales;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMaterialesLista;
    }
}