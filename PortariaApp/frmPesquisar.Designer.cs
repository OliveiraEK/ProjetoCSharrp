﻿
namespace PortariaApp
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbRegistroFuncionario = new System.Windows.Forms.RadioButton();
            this.lstInformacoes = new System.Windows.Forms.ListBox();
            this.gpbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricao);
            this.gpbPesquisar.Controls.Add(this.label1);
            this.gpbPesquisar.Controls.Add(this.rdbNome);
            this.gpbPesquisar.Controls.Add(this.rdbRegistroFuncionario);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(28, 12);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 121);
            this.gpbPesquisar.TabIndex = 0;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(463, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 75);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(108, 74);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 26);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(208, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // rdbRegistroFuncionario
            // 
            this.rdbRegistroFuncionario.AutoSize = true;
            this.rdbRegistroFuncionario.Location = new System.Drawing.Point(80, 25);
            this.rdbRegistroFuncionario.Name = "rdbRegistroFuncionario";
            this.rdbRegistroFuncionario.Size = new System.Drawing.Size(87, 24);
            this.rdbRegistroFuncionario.TabIndex = 1;
            this.rdbRegistroFuncionario.Text = "Registro";
            this.rdbRegistroFuncionario.UseVisualStyleBackColor = true;
            // 
            // lstInformacoes
            // 
            this.lstInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInformacoes.FormattingEnabled = true;
            this.lstInformacoes.ItemHeight = 20;
            this.lstInformacoes.Location = new System.Drawing.Point(28, 146);
            this.lstInformacoes.Name = "lstInformacoes";
            this.lstInformacoes.Size = new System.Drawing.Size(599, 144);
            this.lstInformacoes.TabIndex = 5;
            this.lstInformacoes.SelectedIndexChanged += new System.EventHandler(this.lstInformacoes_SelectedIndexChanged);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 305);
            this.Controls.Add(this.lstInformacoes);
            this.Controls.Add(this.gpbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.frmPesquisar_Load);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbRegistroFuncionario;
        private System.Windows.Forms.ListBox lstInformacoes;
    }
}