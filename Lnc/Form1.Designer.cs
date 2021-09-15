
namespace Lnc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonCad = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExc = new System.Windows.Forms.Button();
            this.buttonFzr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(46, 111);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(87, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Código Cliente";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(46, 152);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTel.Location = new System.Drawing.Point(46, 193);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(56, 15);
            this.labelTel.TabIndex = 2;
            this.labelTel.Text = "Telefone";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(138, 108);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(165, 23);
            this.textBoxId.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(103, 149);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxTel
            // 
            this.textBoxTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTel.Location = new System.Drawing.Point(103, 190);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(200, 23);
            this.textBoxTel.TabIndex = 5;
            // 
            // buttonCad
            // 
            this.buttonCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCad.Location = new System.Drawing.Point(38, 262);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(75, 23);
            this.buttonCad.TabIndex = 6;
            this.buttonCad.Text = "Cadastrar";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(150, 262);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonExc
            // 
            this.buttonExc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExc.Location = new System.Drawing.Point(281, 262);
            this.buttonExc.Name = "buttonExc";
            this.buttonExc.Size = new System.Drawing.Size(75, 23);
            this.buttonExc.TabIndex = 8;
            this.buttonExc.Text = "Excluir";
            this.buttonExc.UseVisualStyleBackColor = true;
            // 
            // buttonFzr
            // 
            this.buttonFzr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFzr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFzr.Location = new System.Drawing.Point(397, 262);
            this.buttonFzr.Name = "buttonFzr";
            this.buttonFzr.Size = new System.Drawing.Size(114, 23);
            this.buttonFzr.TabIndex = 9;
            this.buttonFzr.Text = "Fazer Pedido";
            this.buttonFzr.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnTel});
            this.dataGridView1.GridColor = System.Drawing.Color.Chocolate;
            this.dataGridView1.Location = new System.Drawing.Point(38, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 131);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnTel
            // 
            this.ColumnTel.HeaderText = "Telefone";
            this.ColumnTel.Name = "ColumnTel";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(232, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(95, 28);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFzr);
            this.Controls.Add(this.buttonExc);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCad);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonExc;
        private System.Windows.Forms.Button buttonFzr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTel;
        private System.Windows.Forms.Label labelTitulo;
    }
}

