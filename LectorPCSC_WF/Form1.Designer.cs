namespace LectorPCSC_WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxReaders = new System.Windows.Forms.ComboBox();
            this.BtnReadAtr = new System.Windows.Forms.Button();
            this.BtnReadUID = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReaders.FormattingEnabled = true;
            this.comboBoxReaders.Location = new System.Drawing.Point(140, 135);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(470, 39);
            this.comboBoxReaders.TabIndex = 0;
            this.comboBoxReaders.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReaders_SelectedIndexChanged);
            // 
            // BtnReadAtr
            // 
            this.BtnReadAtr.Location = new System.Drawing.Point(172, 307);
            this.BtnReadAtr.Name = "BtnReadAtr";
            this.BtnReadAtr.Size = new System.Drawing.Size(124, 64);
            this.BtnReadAtr.TabIndex = 1;
            this.BtnReadAtr.Text = "Leer ATR";
            this.BtnReadAtr.UseVisualStyleBackColor = true;
            this.BtnReadAtr.Click += new System.EventHandler(this.BtnReadAtr_Click);
            // 
            // BtnReadUID
            // 
            this.BtnReadUID.Location = new System.Drawing.Point(455, 307);
            this.BtnReadUID.Name = "BtnReadUID";
            this.BtnReadUID.Size = new System.Drawing.Size(124, 64);
            this.BtnReadUID.TabIndex = 2;
            this.BtnReadUID.Text = "Leer UID";
            this.BtnReadUID.UseVisualStyleBackColor = true;
            this.BtnReadUID.Click += new System.EventHandler(this.BtnReadUID_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(25, 434);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(719, 38);
            this.textBoxOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el lector";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(550, 487);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(212, 33);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version X.X.X.X";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.BtnReadUID);
            this.Controls.Add(this.BtnReadAtr);
            this.Controls.Add(this.comboBoxReaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector Tarjetas PCSC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReaders;
        private System.Windows.Forms.Button BtnReadAtr;
        private System.Windows.Forms.Button BtnReadUID;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
    }
}

