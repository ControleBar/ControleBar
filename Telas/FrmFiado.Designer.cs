namespace ControleBar.Telas
{
    partial class FrmFiado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCpf = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCep = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEndereco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dvgfiado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConfirmar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtNomeConsulta = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtCpfConsulta = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgfiado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnfechar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 36);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NBA Bucks", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fiado";
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Transparent;
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.Image = global::ControleBar.Properties.Resources.Fechar_Tela;
            this.btnfechar.Location = new System.Drawing.Point(925, 6);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(25, 24);
            this.btnfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfechar.TabIndex = 1;
            this.btnfechar.TabStop = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleBar.Properties.Resources.LoginSilvio;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(92, 277);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderColorFocused = System.Drawing.Color.LightGray;
            this.txtNome.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.txtNome.BorderThickness = 3;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.isPassword = false;
            this.txtNome.Location = new System.Drawing.Point(92, 95);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 34);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCpf.BorderColorFocused = System.Drawing.Color.LightGray;
            this.txtCpf.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.txtCpf.BorderThickness = 3;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.isPassword = false;
            this.txtCpf.Location = new System.Drawing.Point(92, 141);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(303, 34);
            this.txtCpf.TabIndex = 7;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.BorderColorFocused = System.Drawing.Color.LightGray;
            this.txtCep.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.txtCep.BorderThickness = 3;
            this.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.isPassword = false;
            this.txtCep.Location = new System.Drawing.Point(92, 183);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(303, 34);
            this.txtCep.TabIndex = 8;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndereco.BorderColorFocused = System.Drawing.Color.LightGray;
            this.txtEndereco.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.txtEndereco.BorderThickness = 3;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.isPassword = false;
            this.txtEndereco.Location = new System.Drawing.Point(92, 228);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(303, 34);
            this.txtEndereco.TabIndex = 9;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dvgfiado
            // 
            this.dvgfiado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dvgfiado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgfiado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgfiado.Location = new System.Drawing.Point(434, 95);
            this.dvgfiado.Name = "dvgfiado";
            this.dvgfiado.Size = new System.Drawing.Size(510, 268);
            this.dvgfiado.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CPF";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CEP";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Endereço";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmar.Image = global::ControleBar.Properties.Resources.CorretoButon1;
            this.BtnConfirmar.ImageActive = null;
            this.BtnConfirmar.Location = new System.Drawing.Point(92, 313);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(145, 50);
            this.BtnConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnConfirmar.TabIndex = 12;
            this.BtnConfirmar.TabStop = false;
            this.BtnConfirmar.Zoom = 10;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Image = global::ControleBar.Properties.Resources.Xbuton;
            this.BtnCancelar.ImageActive = null;
            this.BtnCancelar.Location = new System.Drawing.Point(250, 313);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(145, 50);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Zoom = 10;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.BackColor = System.Drawing.Color.Silver;
            this.txtNomeConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNomeConsulta.BackgroundImage")));
            this.txtNomeConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNomeConsulta.ForeColor = System.Drawing.Color.Firebrick;
            this.txtNomeConsulta.Icon = ((System.Drawing.Image)(resources.GetObject("txtNomeConsulta.Icon")));
            this.txtNomeConsulta.Location = new System.Drawing.Point(701, 56);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(243, 24);
            this.txtNomeConsulta.TabIndex = 13;
            this.txtNomeConsulta.text = "Nome";
            // 
            // txtCpfConsulta
            // 
            this.txtCpfConsulta.BackColor = System.Drawing.Color.Silver;
            this.txtCpfConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCpfConsulta.BackgroundImage")));
            this.txtCpfConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCpfConsulta.ForeColor = System.Drawing.Color.Brown;
            this.txtCpfConsulta.Icon = ((System.Drawing.Image)(resources.GetObject("txtCpfConsulta.Icon")));
            this.txtCpfConsulta.Location = new System.Drawing.Point(434, 56);
            this.txtCpfConsulta.Name = "txtCpfConsulta";
            this.txtCpfConsulta.Size = new System.Drawing.Size(243, 24);
            this.txtCpfConsulta.TabIndex = 14;
            this.txtCpfConsulta.text = "CPF";
            // 
            // FrmFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(956, 376);
            this.Controls.Add(this.txtCpfConsulta);
            this.Controls.Add(this.txtNomeConsulta);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.dvgfiado);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnfechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgfiado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnfechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNome;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCpf;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCep;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEndereco;
        private System.Windows.Forms.DataGridView dvgfiado;
        private Bunifu.Framework.UI.BunifuImageButton BtnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton BtnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuTextbox txtNomeConsulta;
        private Bunifu.Framework.UI.BunifuTextbox txtCpfConsulta;
    }
}