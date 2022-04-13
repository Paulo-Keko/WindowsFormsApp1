
namespace WindowsFormsApp1.Teste
{
    partial class inss
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.mtxtdesc = new System.Windows.Forms.MaskedTextBox();
            this.btncalcula = new System.Windows.Forms.Button();
            this.gbxdesconto = new System.Windows.Forms.GroupBox();
            this.gbxsalario = new System.Windows.Forms.GroupBox();
            this.gbxano = new System.Windows.Forms.GroupBox();
            this.mtxtdata = new System.Windows.Forms.TextBox();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.mtxtdata);
            this.pn1.Controls.Add(this.txtsal);
            this.pn1.Controls.Add(this.mtxtdesc);
            this.pn1.Controls.Add(this.btncalcula);
            this.pn1.Controls.Add(this.gbxdesconto);
            this.pn1.Controls.Add(this.gbxsalario);
            this.pn1.Controls.Add(this.gbxano);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(800, 450);
            this.pn1.TabIndex = 1;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(169, 141);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(141, 26);
            this.txtsal.TabIndex = 12;
            this.txtsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsal.LostFocus += new System.EventHandler(this.txtsal_LostFocus);
            // 
            // mtxtdesc
            // 
            this.mtxtdesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtxtdesc.Location = new System.Drawing.Point(169, 284);
            this.mtxtdesc.Name = "mtxtdesc";
            this.mtxtdesc.ReadOnly = true;
            this.mtxtdesc.Size = new System.Drawing.Size(141, 26);
            this.mtxtdesc.TabIndex = 11;
            this.mtxtdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtdesc.ValidatingType = typeof(int);
            // 
            // btncalcula
            // 
            this.btncalcula.Location = new System.Drawing.Point(407, 135);
            this.btncalcula.Name = "btncalcula";
            this.btncalcula.Size = new System.Drawing.Size(133, 38);
            this.btncalcula.TabIndex = 5;
            this.btncalcula.Text = "Calcular";
            this.btncalcula.UseVisualStyleBackColor = true;
            this.btncalcula.Click += new System.EventHandler(this.btncalcula_Click);
            // 
            // gbxdesconto
            // 
            this.gbxdesconto.Location = new System.Drawing.Point(12, 261);
            this.gbxdesconto.Name = "gbxdesconto";
            this.gbxdesconto.Size = new System.Drawing.Size(190, 38);
            this.gbxdesconto.TabIndex = 3;
            this.gbxdesconto.TabStop = false;
            this.gbxdesconto.Text = "Desconto";
            // 
            // gbxsalario
            // 
            this.gbxsalario.Location = new System.Drawing.Point(12, 117);
            this.gbxsalario.Name = "gbxsalario";
            this.gbxsalario.Size = new System.Drawing.Size(190, 38);
            this.gbxsalario.TabIndex = 2;
            this.gbxsalario.TabStop = false;
            this.gbxsalario.Text = "Salario";
            // 
            // gbxano
            // 
            this.gbxano.Location = new System.Drawing.Point(12, 31);
            this.gbxano.Name = "gbxano";
            this.gbxano.Size = new System.Drawing.Size(190, 40);
            this.gbxano.TabIndex = 0;
            this.gbxano.TabStop = false;
            this.gbxano.Text = "Ano";
            // 
            // mtxtdata
            // 
            this.mtxtdata.Location = new System.Drawing.Point(169, 56);
            this.mtxtdata.Name = "mtxtdata";
            this.mtxtdata.Size = new System.Drawing.Size(66, 26);
            this.mtxtdata.TabIndex = 13;
            this.mtxtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn1);
            this.Name = "inss";
            this.Text = "inss";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.MaskedTextBox mtxtdesc;
        private System.Windows.Forms.Button btncalcula;
        private System.Windows.Forms.GroupBox gbxdesconto;
        private System.Windows.Forms.GroupBox gbxsalario;
        private System.Windows.Forms.GroupBox gbxano;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox mtxtdata;
    }
}