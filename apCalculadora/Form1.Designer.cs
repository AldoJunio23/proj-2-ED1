using System.Drawing;

namespace apCalculadora
{
    partial class apCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apCalculadora));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.lbPosfixa = new System.Windows.Forms.Label();
            this.btnElevar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAbreParenteses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Gray;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(6, 57);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(312, 35);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.Gray;
            this.txtVisor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.ForeColor = System.Drawing.Color.White;
            this.txtVisor.Location = new System.Drawing.Point(6, 20);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(312, 35);
            this.txtVisor.TabIndex = 1;
            this.txtVisor.Leave += new System.EventHandler(this.txtVisor_Leave);
            // 
            // lbPosfixa
            // 
            this.lbPosfixa.AutoSize = true;
            this.lbPosfixa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosfixa.ForeColor = System.Drawing.Color.White;
            this.lbPosfixa.Location = new System.Drawing.Point(9, 104);
            this.lbPosfixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPosfixa.Name = "lbPosfixa";
            this.lbPosfixa.Size = new System.Drawing.Size(302, 25);
            this.lbPosfixa.TabIndex = 2;
            this.lbPosfixa.Text = "A expressão pósfixa aparecerá aqui.";
            // 
            // btnElevar
            // 
            this.btnElevar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnElevar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElevar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevar.ForeColor = System.Drawing.Color.White;
            this.btnElevar.Location = new System.Drawing.Point(6, 147);
            this.btnElevar.Margin = new System.Windows.Forms.Padding(2);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(75, 53);
            this.btnElevar.TabIndex = 3;
            this.btnElevar.Text = "^";
            this.btnElevar.UseVisualStyleBackColor = false;
            this.btnElevar.Click += new System.EventHandler(this.btnElevar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(244, 147);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 53);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicar.Location = new System.Drawing.Point(165, 147);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 53);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(85, 147);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 53);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(4, 212);
            this.btnSete.Margin = new System.Windows.Forms.Padding(2);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 53);
            this.btnSete.TabIndex = 9;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(85, 212);
            this.btnOito.Margin = new System.Windows.Forms.Padding(2);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 53);
            this.btnOito.TabIndex = 10;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(165, 212);
            this.btnNove.Margin = new System.Windows.Forms.Padding(2);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 53);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(244, 212);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 53);
            this.btnSomar.TabIndex = 12;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(4, 270);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 53);
            this.btnSeis.TabIndex = 13;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(85, 270);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(2);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 53);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnQuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(165, 270);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 53);
            this.btnQuatro.TabIndex = 15;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVirgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.White;
            this.btnVirgula.Location = new System.Drawing.Point(244, 270);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(75, 53);
            this.btnVirgula.TabIndex = 16;
            this.btnVirgula.Text = ".";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(4, 327);
            this.btnTres.Margin = new System.Windows.Forms.Padding(2);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 53);
            this.btnTres.TabIndex = 17;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(85, 327);
            this.btnDois.Margin = new System.Windows.Forms.Padding(2);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 53);
            this.btnDois.TabIndex = 18;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.White;
            this.btnUm.Location = new System.Drawing.Point(165, 327);
            this.btnUm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 53);
            this.btnUm.TabIndex = 19;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFechaParenteses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechaParenteses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaParenteses.ForeColor = System.Drawing.Color.White;
            this.btnFechaParenteses.Location = new System.Drawing.Point(244, 327);
            this.btnFechaParenteses.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(75, 53);
            this.btnFechaParenteses.TabIndex = 20;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = false;
            this.btnFechaParenteses.Click += new System.EventHandler(this.btnFechaParenteses_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(4, 385);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 53);
            this.btnZero.TabIndex = 21;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(84, 385);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(2);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 53);
            this.btnIgual.TabIndex = 22;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(165, 385);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 53);
            this.btnApagar.TabIndex = 23;
            this.btnApagar.Text = "C";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAbreParenteses
            // 
            this.btnAbreParenteses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAbreParenteses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbreParenteses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbreParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbreParenteses.ForeColor = System.Drawing.Color.White;
            this.btnAbreParenteses.Location = new System.Drawing.Point(244, 385);
            this.btnAbreParenteses.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbreParenteses.Name = "btnAbreParenteses";
            this.btnAbreParenteses.Size = new System.Drawing.Size(75, 53);
            this.btnAbreParenteses.TabIndex = 24;
            this.btnAbreParenteses.Text = "(";
            this.btnAbreParenteses.UseVisualStyleBackColor = false;
            this.btnAbreParenteses.Click += new System.EventHandler(this.btnAbreParenteses_Click);
            // 
            // apCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(322, 451);
            this.Controls.Add(this.btnAbreParenteses);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnFechaParenteses);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnElevar);
            this.Controls.Add(this.lbPosfixa);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.txtResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "apCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Label lbPosfixa;
        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnFechaParenteses;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAbreParenteses;
    }
}

