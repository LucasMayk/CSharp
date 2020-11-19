namespace WebChallenge
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonToEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 241);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(650, 210);
            this.dataGridView.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.buttonSave.Location = new System.Drawing.Point(547, 86);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 24);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonToEdit
            // 
            this.buttonToEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.buttonToEdit.Location = new System.Drawing.Point(547, 116);
            this.buttonToEdit.Name = "buttonToEdit";
            this.buttonToEdit.Size = new System.Drawing.Size(97, 24);
            this.buttonToEdit.TabIndex = 18;
            this.buttonToEdit.Text = "Editar";
            this.buttonToEdit.UseVisualStyleBackColor = true;
            this.buttonToEdit.Click += new System.EventHandler(this.buttonToEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.buttonDelete.Location = new System.Drawing.Point(547, 146);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 24);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Excluir";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.AccessibleName = "";
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxData.Location = new System.Drawing.Point(9, 34);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(140, 23);
            this.textBoxData.TabIndex = 0;
            this.textBoxData.Text = "dd/mm/aaaa";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelData.Location = new System.Drawing.Point(6, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(47, 17);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "*Data:";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(193, 34);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(140, 24);
            this.comboBoxPriority.TabIndex = 7;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPriority.Location = new System.Drawing.Point(190, 9);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(82, 17);
            this.labelPriority.TabIndex = 8;
            this.labelPriority.Text = "*Prioridade:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(374, 34);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 24);
            this.comboBoxStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStatus.Location = new System.Drawing.Point(371, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 17);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "*Status:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDescription.Location = new System.Drawing.Point(9, 102);
            this.textBoxDescription.MaxLength = 50;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(230, 68);
            this.textBoxDescription.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDescription.Location = new System.Drawing.Point(6, 72);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(80, 17);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "*Descrição:";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxComments.Location = new System.Drawing.Point(284, 102);
            this.textBoxComments.MaxLength = 50;
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(230, 68);
            this.textBoxComments.TabIndex = 13;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelComments.Location = new System.Drawing.Point(281, 72);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(101, 17);
            this.labelComments.TabIndex = 14;
            this.labelComments.Text = "*Observações:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.labelComments);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxComments);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonToEdit);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.labelPriority);
            this.groupBox1.Controls.Add(this.comboBoxPriority);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.textBoxData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelID.Location = new System.Drawing.Point(544, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 17);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "Id:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(547, 34);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(88, 23);
            this.textBoxID.TabIndex = 17;
            this.textBoxID.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonToEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

