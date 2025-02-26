
namespace PROJETO_ROSALVINO
{
    partial class Frm_Rosalvino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rosalvino));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Bnt_Ativar = new System.Windows.Forms.Button();
            this.Bnt_Desativar = new System.Windows.Forms.Button();
            this.Bnt_Limpar = new System.Windows.Forms.Button();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Lbl_idade = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Bnt_Nome = new System.Windows.Forms.Button();
            this.Bnt_Sobrenome = new System.Windows.Forms.Button();
            this.Bnt_Idade = new System.Windows.Forms.Button();
            this.Bnt_Bairro = new System.Windows.Forms.Button();
            this.Bnt_Celular = new System.Windows.Forms.Button();
            this.Bnt_Email = new System.Windows.Forms.Button();
            this.Grp_Temas = new System.Windows.Forms.GroupBox();
            this.Rad_Tema2 = new System.Windows.Forms.RadioButton();
            this.Rad_Padrao = new System.Windows.Forms.RadioButton();
            this.Rad_Tema1 = new System.Windows.Forms.RadioButton();
            this.Lbl_DadosPessoais = new System.Windows.Forms.Label();
            this.Bnt_DadosCompletos = new System.Windows.Forms.Button();
            this.Grp_Temas.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Bnt_Ativar
            // 
            this.Bnt_Ativar.Location = new System.Drawing.Point(13, 13);
            this.Bnt_Ativar.Name = "Bnt_Ativar";
            this.Bnt_Ativar.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Ativar.TabIndex = 0;
            this.Bnt_Ativar.Text = "Ativar";
            this.Bnt_Ativar.UseVisualStyleBackColor = true;
            this.Bnt_Ativar.Click += new System.EventHandler(this.Bnt_Ativar_Click);
            // 
            // Bnt_Desativar
            // 
            this.Bnt_Desativar.Enabled = false;
            this.Bnt_Desativar.Location = new System.Drawing.Point(126, 13);
            this.Bnt_Desativar.Name = "Bnt_Desativar";
            this.Bnt_Desativar.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Desativar.TabIndex = 1;
            this.Bnt_Desativar.Text = "Desativar";
            this.Bnt_Desativar.UseVisualStyleBackColor = true;
            // 
            // Bnt_Limpar
            // 
            this.Bnt_Limpar.Enabled = false;
            this.Bnt_Limpar.Location = new System.Drawing.Point(244, 13);
            this.Bnt_Limpar.Name = "Bnt_Limpar";
            this.Bnt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Limpar.TabIndex = 2;
            this.Bnt_Limpar.Text = "Limpar";
            this.Bnt_Limpar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Enabled = false;
            this.Lbl_Nome.Location = new System.Drawing.Point(553, 105);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome.TabIndex = 3;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.Enabled = false;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(535, 136);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Sobrenome.TabIndex = 4;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            // 
            // Lbl_idade
            // 
            this.Lbl_idade.AutoSize = true;
            this.Lbl_idade.Enabled = false;
            this.Lbl_idade.Location = new System.Drawing.Point(555, 170);
            this.Lbl_idade.Name = "Lbl_idade";
            this.Lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.Lbl_idade.TabIndex = 5;
            this.Lbl_idade.Text = "Idade";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Enabled = false;
            this.Lbl_Bairro.Location = new System.Drawing.Point(553, 202);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 6;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Enabled = false;
            this.Lbl_Celular.Location = new System.Drawing.Point(555, 232);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Celular.TabIndex = 7;
            this.Lbl_Celular.Text = "Celular";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Enabled = false;
            this.Lbl_Email.Location = new System.Drawing.Point(553, 264);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 8;
            this.Lbl_Email.Text = "Email";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Enabled = false;
            this.Txt_Nome.Location = new System.Drawing.Point(602, 102);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nome.TabIndex = 9;
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.Enabled = false;
            this.Txt_Sobrenome.Location = new System.Drawing.Point(602, 133);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sobrenome.TabIndex = 10;
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Enabled = false;
            this.Txt_Idade.Location = new System.Drawing.Point(602, 167);
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Idade.TabIndex = 11;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Enabled = false;
            this.Txt_Bairro.Location = new System.Drawing.Point(596, 199);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(100, 20);
            this.Txt_Bairro.TabIndex = 12;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Enabled = false;
            this.Txt_Celular.Location = new System.Drawing.Point(600, 238);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(100, 20);
            this.Txt_Celular.TabIndex = 13;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Enabled = false;
            this.Txt_Email.Location = new System.Drawing.Point(602, 264);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 14;
            // 
            // Bnt_Nome
            // 
            this.Bnt_Nome.Enabled = false;
            this.Bnt_Nome.Location = new System.Drawing.Point(720, 100);
            this.Bnt_Nome.Name = "Bnt_Nome";
            this.Bnt_Nome.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Nome.TabIndex = 15;
            this.Bnt_Nome.Text = "Nome";
            this.Bnt_Nome.UseVisualStyleBackColor = true;
            // 
            // Bnt_Sobrenome
            // 
            this.Bnt_Sobrenome.Enabled = false;
            this.Bnt_Sobrenome.Location = new System.Drawing.Point(720, 133);
            this.Bnt_Sobrenome.Name = "Bnt_Sobrenome";
            this.Bnt_Sobrenome.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Sobrenome.TabIndex = 16;
            this.Bnt_Sobrenome.Text = "Sobrenome";
            this.Bnt_Sobrenome.UseVisualStyleBackColor = true;
            // 
            // Bnt_Idade
            // 
            this.Bnt_Idade.Enabled = false;
            this.Bnt_Idade.Location = new System.Drawing.Point(720, 167);
            this.Bnt_Idade.Name = "Bnt_Idade";
            this.Bnt_Idade.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Idade.TabIndex = 17;
            this.Bnt_Idade.Text = "Idade";
            this.Bnt_Idade.UseVisualStyleBackColor = true;
            // 
            // Bnt_Bairro
            // 
            this.Bnt_Bairro.Enabled = false;
            this.Bnt_Bairro.Location = new System.Drawing.Point(720, 199);
            this.Bnt_Bairro.Name = "Bnt_Bairro";
            this.Bnt_Bairro.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Bairro.TabIndex = 18;
            this.Bnt_Bairro.Text = "Bairro";
            this.Bnt_Bairro.UseVisualStyleBackColor = true;
            // 
            // Bnt_Celular
            // 
            this.Bnt_Celular.Enabled = false;
            this.Bnt_Celular.Location = new System.Drawing.Point(720, 229);
            this.Bnt_Celular.Name = "Bnt_Celular";
            this.Bnt_Celular.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Celular.TabIndex = 19;
            this.Bnt_Celular.Text = "Celular";
            this.Bnt_Celular.UseVisualStyleBackColor = true;
            // 
            // Bnt_Email
            // 
            this.Bnt_Email.Enabled = false;
            this.Bnt_Email.Location = new System.Drawing.Point(720, 262);
            this.Bnt_Email.Name = "Bnt_Email";
            this.Bnt_Email.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Email.TabIndex = 20;
            this.Bnt_Email.Text = "Email";
            this.Bnt_Email.UseVisualStyleBackColor = true;
            // 
            // Grp_Temas
            // 
            this.Grp_Temas.Controls.Add(this.Rad_Tema2);
            this.Grp_Temas.Controls.Add(this.Rad_Padrao);
            this.Grp_Temas.Controls.Add(this.Rad_Tema1);
            this.Grp_Temas.Enabled = false;
            this.Grp_Temas.Location = new System.Drawing.Point(1, 340);
            this.Grp_Temas.Name = "Grp_Temas";
            this.Grp_Temas.Size = new System.Drawing.Size(290, 113);
            this.Grp_Temas.TabIndex = 21;
            this.Grp_Temas.TabStop = false;
            this.Grp_Temas.Text = "Temas";
            this.Grp_Temas.Enter += new System.EventHandler(this.Grp_Temas_Enter);
            // 
            // Rad_Tema2
            // 
            this.Rad_Tema2.AutoSize = true;
            this.Rad_Tema2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rad_Tema2.Enabled = false;
            this.Rad_Tema2.Location = new System.Drawing.Point(188, 48);
            this.Rad_Tema2.Name = "Rad_Tema2";
            this.Rad_Tema2.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema2.TabIndex = 3;
            this.Rad_Tema2.Text = "Tema 2";
            this.Rad_Tema2.UseVisualStyleBackColor = true;
            this.Rad_Tema2.CheckedChanged += new System.EventHandler(this.Rad_Tema2_CheckedChanged);
            // 
            // Rad_Padrao
            // 
            this.Rad_Padrao.AutoSize = true;
            this.Rad_Padrao.Enabled = false;
            this.Rad_Padrao.Location = new System.Drawing.Point(7, 48);
            this.Rad_Padrao.Name = "Rad_Padrao";
            this.Rad_Padrao.Size = new System.Drawing.Size(59, 17);
            this.Rad_Padrao.TabIndex = 2;
            this.Rad_Padrao.Text = "Padrão";
            this.Rad_Padrao.UseVisualStyleBackColor = true;
            this.Rad_Padrao.CheckedChanged += new System.EventHandler(this.Rad_Padrao_CheckedChanged);
            // 
            // Rad_Tema1
            // 
            this.Rad_Tema1.AutoSize = true;
            this.Rad_Tema1.Enabled = false;
            this.Rad_Tema1.Location = new System.Drawing.Point(98, 48);
            this.Rad_Tema1.Name = "Rad_Tema1";
            this.Rad_Tema1.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema1.TabIndex = 1;
            this.Rad_Tema1.Text = "Tema 1";
            this.Rad_Tema1.UseVisualStyleBackColor = true;
            this.Rad_Tema1.CheckedChanged += new System.EventHandler(this.Rad_Tema1_CheckedChanged);
            // 
            // Lbl_DadosPessoais
            // 
            this.Lbl_DadosPessoais.AutoSize = true;
            this.Lbl_DadosPessoais.Enabled = false;
            this.Lbl_DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DadosPessoais.ForeColor = System.Drawing.Color.Red;
            this.Lbl_DadosPessoais.Location = new System.Drawing.Point(598, 58);
            this.Lbl_DadosPessoais.Name = "Lbl_DadosPessoais";
            this.Lbl_DadosPessoais.Size = new System.Drawing.Size(138, 20);
            this.Lbl_DadosPessoais.TabIndex = 22;
            this.Lbl_DadosPessoais.Text = "Dados Pessoais";
            this.Lbl_DadosPessoais.Click += new System.EventHandler(this.label7_Click);
            // 
            // Bnt_DadosCompletos
            // 
            this.Bnt_DadosCompletos.Enabled = false;
            this.Bnt_DadosCompletos.Location = new System.Drawing.Point(602, 302);
            this.Bnt_DadosCompletos.Name = "Bnt_DadosCompletos";
            this.Bnt_DadosCompletos.Size = new System.Drawing.Size(110, 34);
            this.Bnt_DadosCompletos.TabIndex = 23;
            this.Bnt_DadosCompletos.Text = "Dados Completos";
            this.Bnt_DadosCompletos.UseVisualStyleBackColor = true;
            // 
            // Frm_Rosalvino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bnt_DadosCompletos);
            this.Controls.Add(this.Lbl_DadosPessoais);
            this.Controls.Add(this.Grp_Temas);
            this.Controls.Add(this.Bnt_Email);
            this.Controls.Add(this.Bnt_Celular);
            this.Controls.Add(this.Bnt_Bairro);
            this.Controls.Add(this.Bnt_Idade);
            this.Controls.Add(this.Bnt_Sobrenome);
            this.Controls.Add(this.Bnt_Nome);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Txt_Sobrenome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Celular);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Lbl_idade);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Bnt_Limpar);
            this.Controls.Add(this.Bnt_Desativar);
            this.Controls.Add(this.Bnt_Ativar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rosalvino";
            this.Text = "O Dom Bosco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grp_Temas.ResumeLayout(false);
            this.Grp_Temas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button Bnt_Ativar;
        private System.Windows.Forms.Button Bnt_Desativar;
        private System.Windows.Forms.Button Bnt_Limpar;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.Label Lbl_idade;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Sobrenome;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Bnt_Nome;
        private System.Windows.Forms.Button Bnt_Sobrenome;
        private System.Windows.Forms.Button Bnt_Idade;
        private System.Windows.Forms.Button Bnt_Bairro;
        private System.Windows.Forms.Button Bnt_Celular;
        private System.Windows.Forms.Button Bnt_Email;
        private System.Windows.Forms.GroupBox Grp_Temas;
        private System.Windows.Forms.RadioButton Rad_Tema2;
        private System.Windows.Forms.RadioButton Rad_Padrao;
        private System.Windows.Forms.RadioButton Rad_Tema1;
        private System.Windows.Forms.Label Lbl_DadosPessoais;
        private System.Windows.Forms.Button Bnt_DadosCompletos;
    }
}

