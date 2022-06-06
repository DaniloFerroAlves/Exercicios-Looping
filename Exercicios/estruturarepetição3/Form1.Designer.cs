
namespace estruturarepetição3
{
    partial class Form1
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
            this.lboxResultado = new System.Windows.Forms.ListBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxResultado
            // 
            this.lboxResultado.FormattingEnabled = true;
            this.lboxResultado.Location = new System.Drawing.Point(134, 30);
            this.lboxResultado.Name = "lboxResultado";
            this.lboxResultado.Size = new System.Drawing.Size(138, 238);
            this.lboxResultado.TabIndex = 0;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(31, 47);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 41);
            this.btCalcular.TabIndex = 1;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxResultado);
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Location = new System.Drawing.Point(42, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatorial dos numeros impares 1 a 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 304);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

