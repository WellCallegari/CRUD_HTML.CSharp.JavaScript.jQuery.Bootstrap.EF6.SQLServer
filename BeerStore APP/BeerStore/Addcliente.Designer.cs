namespace BeerStore
{
    partial class Addcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addcliente));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblseaex = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.lblnew = new System.Windows.Forms.Label();
            this.lblsave = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblback = new System.Windows.Forms.Label();
            this.lblseati = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.gpcadastro = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.txtcel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gpcadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 26);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome:";
            // 
            // lblseaex
            // 
            this.lblseaex.AutoSize = true;
            this.lblseaex.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseaex.Location = new System.Drawing.Point(12, 112);
            this.lblseaex.Name = "lblseaex";
            this.lblseaex.Size = new System.Drawing.Size(280, 26);
            this.lblseaex.TabIndex = 13;
            this.lblseaex.Text = "Pesquisar por nome de cliente:";
            this.lblseaex.Visible = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(298, 111);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(458, 31);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.Visible = false;
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(26, 26);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(55, 50);
            this.btnnew.TabIndex = 44;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(143, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(55, 50);
            this.btnsave.TabIndex = 45;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(494, 26);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(55, 50);
            this.btndelete.TabIndex = 47;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(377, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(55, 50);
            this.btnsearch.TabIndex = 51;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(260, 26);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(55, 50);
            this.btnedit.TabIndex = 50;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Visible = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // lblnew
            // 
            this.lblnew.AutoSize = true;
            this.lblnew.Font = new System.Drawing.Font("GAMERIA", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnew.Location = new System.Drawing.Point(30, 79);
            this.lblnew.Name = "lblnew";
            this.lblnew.Size = new System.Drawing.Size(48, 14);
            this.lblnew.TabIndex = 52;
            this.lblnew.Text = "Novo";
            // 
            // lblsave
            // 
            this.lblsave.AutoSize = true;
            this.lblsave.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lblsave.Location = new System.Drawing.Point(140, 79);
            this.lblsave.Name = "lblsave";
            this.lblsave.Size = new System.Drawing.Size(63, 14);
            this.lblsave.TabIndex = 9;
            this.lblsave.Text = "Salvar";
            this.lblsave.Visible = false;
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lbledit.Location = new System.Drawing.Point(259, 79);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(56, 14);
            this.lbledit.TabIndex = 10;
            this.lbledit.Text = "Editar";
            this.lbledit.Visible = false;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lblsearch.Location = new System.Drawing.Point(362, 79);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(85, 14);
            this.lblsearch.TabIndex = 11;
            this.lblsearch.Text = "Pesquisar";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lbldelete.Location = new System.Drawing.Point(488, 79);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(66, 14);
            this.lbldelete.TabIndex = 12;
            this.lbldelete.Text = "Deletar";
            this.lbldelete.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(830, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 500);
            this.panel5.TabIndex = 9;
            // 
            // btnback
            // 
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.Location = new System.Drawing.Point(769, 26);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 50);
            this.btnback.TabIndex = 52;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lblback.Location = new System.Drawing.Point(766, 79);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(61, 14);
            this.lblback.TabIndex = 53;
            this.lblback.Text = "Voltar";
            this.lblback.Visible = false;
            // 
            // lblseati
            // 
            this.lblseati.AutoSize = true;
            this.lblseati.Font = new System.Drawing.Font("GAMERIA", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseati.Location = new System.Drawing.Point(38, 23);
            this.lblseati.Name = "lblseati";
            this.lblseati.Size = new System.Drawing.Size(500, 81);
            this.lblseati.TabIndex = 54;
            this.lblseati.Text = "Pesquisar";
            this.lblseati.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 20);
            this.panel2.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(95, 35);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(510, 31);
            this.txtnome.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 56;
            this.label1.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(95, 70);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(510, 31);
            this.txtemail.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tel.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cel.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 26);
            this.label4.TabIndex = 64;
            this.label4.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 62;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 66;
            this.label6.Text = "Rua:";
            // 
            // txtrua
            // 
            this.txtrua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrua.Location = new System.Drawing.Point(95, 107);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(510, 31);
            this.txtrua.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 26);
            this.label7.TabIndex = 68;
            this.label7.Text = "Bairro:";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(95, 142);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(510, 31);
            this.txtbairro.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 26);
            this.label8.TabIndex = 70;
            this.label8.Text = "Cidade:";
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(95, 216);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(510, 31);
            this.txtcidade.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 26);
            this.label9.TabIndex = 72;
            this.label9.Text = "Obs:";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.Location = new System.Drawing.Point(95, 179);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(510, 31);
            this.txtobs.TabIndex = 73;
            // 
            // gpcadastro
            // 
            this.gpcadastro.Controls.Add(this.txtcel);
            this.gpcadastro.Controls.Add(this.txttel);
            this.gpcadastro.Controls.Add(this.txtrg);
            this.gpcadastro.Controls.Add(this.txtcpf);
            this.gpcadastro.Controls.Add(this.label9);
            this.gpcadastro.Controls.Add(this.lblNome);
            this.gpcadastro.Controls.Add(this.txtobs);
            this.gpcadastro.Controls.Add(this.txtnome);
            this.gpcadastro.Controls.Add(this.label8);
            this.gpcadastro.Controls.Add(this.txtemail);
            this.gpcadastro.Controls.Add(this.label7);
            this.gpcadastro.Controls.Add(this.label1);
            this.gpcadastro.Controls.Add(this.txtcidade);
            this.gpcadastro.Controls.Add(this.txtbairro);
            this.gpcadastro.Controls.Add(this.label2);
            this.gpcadastro.Controls.Add(this.label6);
            this.gpcadastro.Controls.Add(this.txtrua);
            this.gpcadastro.Controls.Add(this.label3);
            this.gpcadastro.Controls.Add(this.label4);
            this.gpcadastro.Controls.Add(this.label5);
            this.gpcadastro.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpcadastro.Location = new System.Drawing.Point(10, 167);
            this.gpcadastro.Name = "gpcadastro";
            this.gpcadastro.Size = new System.Drawing.Size(828, 256);
            this.gpcadastro.TabIndex = 55;
            this.gpcadastro.TabStop = false;
            this.gpcadastro.Text = "Cadastro de Cliente";
            this.gpcadastro.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(771, 107);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(50, 40);
            this.btnbuscar.TabIndex = 56;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Visible = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("GAMERIA", 12F);
            this.lblbuscar.Location = new System.Drawing.Point(764, 150);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(63, 14);
            this.lblbuscar.TabIndex = 57;
            this.lblbuscar.Text = "Buscar";
            this.lblbuscar.Visible = false;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(667, 70);
            this.txtcpf.Mask = "999.999.999-99";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(150, 31);
            this.txtcpf.TabIndex = 58;
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(667, 107);
            this.txtrg.Mask = "99999999-9";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(150, 31);
            this.txtrg.TabIndex = 75;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(667, 143);
            this.txttel.Mask = "(99) 9999-9999";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(150, 31);
            this.txttel.TabIndex = 76;
            // 
            // txtcel
            // 
            this.txtcel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(667, 179);
            this.txtcel.Mask = "(99) 9 9999-9999";
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(150, 31);
            this.txtcel.TabIndex = 77;
            // 
            // Addcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(850, 427);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gpcadastro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblnew);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblseaex);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lbledit);
            this.Controls.Add(this.lblsave);
            this.Controls.Add(this.lblseati);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Addcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gpcadastro.ResumeLayout(false);
            this.gpcadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblseaex;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label lblnew;
        private System.Windows.Forms.Label lblsave;
        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lbldelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblback;
        private System.Windows.Forms.Label lblseati;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.GroupBox gpcadastro;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtcel;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.MaskedTextBox txtrg;
    }
}