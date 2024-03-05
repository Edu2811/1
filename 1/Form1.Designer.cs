
namespace _1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lblsinal = new System.Windows.Forms.Label();
            this.lblresp = new System.Windows.Forms.Label();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnpot = new System.Windows.Forms.Button();
            this.btnpar = new System.Windows.Forms.Button();
            this.btncomp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(359, 46);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 0;
            this.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(359, 99);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 1;
            this.txtn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsinal
            // 
            this.lblsinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsinal.Location = new System.Drawing.Point(323, 99);
            this.lblsinal.Name = "lblsinal";
            this.lblsinal.Size = new System.Drawing.Size(21, 20);
            this.lblsinal.TabIndex = 2;
            this.lblsinal.Text = "?";
            this.lblsinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblresp
            // 
            this.lblresp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblresp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresp.Location = new System.Drawing.Point(323, 150);
            this.lblresp.Name = "lblresp";
            this.lblresp.Size = new System.Drawing.Size(178, 29);
            this.lblresp.TabIndex = 3;
            this.lblresp.Text = "?";
            this.lblresp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.Location = new System.Drawing.Point(135, 213);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(103, 49);
            this.btnsoma.TabIndex = 5;
            this.btnsoma.Text = "Somar";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(359, 367);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(103, 49);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Fechar";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnlimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Location = new System.Drawing.Point(570, 292);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(103, 49);
            this.btnlimp.TabIndex = 7;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = false;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(570, 213);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(103, 49);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "Dividir";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(427, 213);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(103, 49);
            this.btnmult.TabIndex = 9;
            this.btnmult.Text = "Multiplicar";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(281, 213);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(103, 49);
            this.btnsub.TabIndex = 10;
            this.btnsub.Text = "Subtrair";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnpot
            // 
            this.btnpot.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpot.Location = new System.Drawing.Point(135, 292);
            this.btnpot.Name = "btnpot";
            this.btnpot.Size = new System.Drawing.Size(103, 49);
            this.btnpot.TabIndex = 11;
            this.btnpot.Text = "Potenciação";
            this.btnpot.UseVisualStyleBackColor = false;
            this.btnpot.Click += new System.EventHandler(this.btnpot_Click);
            // 
            // btnpar
            // 
            this.btnpar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpar.Location = new System.Drawing.Point(281, 292);
            this.btnpar.Name = "btnpar";
            this.btnpar.Size = new System.Drawing.Size(103, 49);
            this.btnpar.TabIndex = 12;
            this.btnpar.Text = "Par ou Ímpar";
            this.btnpar.UseVisualStyleBackColor = false;
            this.btnpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncomp
            // 
            this.btncomp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btncomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomp.Location = new System.Drawing.Point(427, 292);
            this.btncomp.Name = "btncomp";
            this.btncomp.Size = new System.Drawing.Size(103, 49);
            this.btncomp.TabIndex = 13;
            this.btncomp.Text = "Comparar";
            this.btncomp.UseVisualStyleBackColor = false;
            this.btncomp.Click += new System.EventHandler(this.btncomp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.btncomp);
            this.Controls.Add(this.btnpar);
            this.Controls.Add(this.btnpot);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.lblresp);
            this.Controls.Add(this.lblsinal);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lblsinal;
        private System.Windows.Forms.Label lblresp;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnpot;
        private System.Windows.Forms.Button btnpar;
        private System.Windows.Forms.Button btncomp;
    }
}

