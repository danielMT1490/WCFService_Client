namespace ClienteWCF
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
            this.Num1Text = new System.Windows.Forms.TextBox();
            this.Num2Text = new System.Windows.Forms.TextBox();
            this.ResultadoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protocoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SumaOption = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MultiplicacionOption = new System.Windows.Forms.ToolStripMenuItem();
            this.DivisionOption = new System.Windows.Forms.ToolStripMenuItem();
            this.HTTPOption = new System.Windows.Forms.ToolStripMenuItem();
            this.TCPOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Num1Text
            // 
            this.Num1Text.Location = new System.Drawing.Point(150, 52);
            this.Num1Text.Name = "Num1Text";
            this.Num1Text.Size = new System.Drawing.Size(77, 20);
            this.Num1Text.TabIndex = 0;
            // 
            // Num2Text
            // 
            this.Num2Text.Location = new System.Drawing.Point(150, 96);
            this.Num2Text.Name = "Num2Text";
            this.Num2Text.Size = new System.Drawing.Size(77, 20);
            this.Num2Text.TabIndex = 1;
            // 
            // ResultadoText
            // 
            this.ResultadoText.Location = new System.Drawing.Point(150, 139);
            this.ResultadoText.Name = "ResultadoText";
            this.ResultadoText.Size = new System.Drawing.Size(77, 20);
            this.ResultadoText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(133, 194);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(106, 58);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionToolStripMenuItem,
            this.protocoloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SumaOption,
            this.RestaOption,
            this.MultiplicacionOption,
            this.DivisionOption});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.operacionToolStripMenuItem.Text = "Operacion";
            // 
            // protocoloToolStripMenuItem
            // 
            this.protocoloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HTTPOption,
            this.TCPOption});
            this.protocoloToolStripMenuItem.Name = "protocoloToolStripMenuItem";
            this.protocoloToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.protocoloToolStripMenuItem.Text = "Protocolo";
            // 
            // SumaOption
            // 
            this.SumaOption.Name = "SumaOption";
            this.SumaOption.Size = new System.Drawing.Size(180, 22);
            this.SumaOption.Text = "Suma";
            this.SumaOption.Click += new System.EventHandler(this.SumaOption_Click);
            // 
            // RestaOption
            // 
            this.RestaOption.Name = "RestaOption";
            this.RestaOption.Size = new System.Drawing.Size(180, 22);
            this.RestaOption.Text = "Resta";
            this.RestaOption.Click += new System.EventHandler(this.RestaOption_Click);
            // 
            // MultiplicacionOption
            // 
            this.MultiplicacionOption.Name = "MultiplicacionOption";
            this.MultiplicacionOption.Size = new System.Drawing.Size(180, 22);
            this.MultiplicacionOption.Text = "Multiplicación";
            this.MultiplicacionOption.Click += new System.EventHandler(this.MultiplicacionOption_Click);
            // 
            // DivisionOption
            // 
            this.DivisionOption.Name = "DivisionOption";
            this.DivisionOption.Size = new System.Drawing.Size(180, 22);
            this.DivisionOption.Text = "División";
            this.DivisionOption.Click += new System.EventHandler(this.DivisionOption_Click);
            // 
            // HTTPOption
            // 
            this.HTTPOption.Name = "HTTPOption";
            this.HTTPOption.Size = new System.Drawing.Size(180, 22);
            this.HTTPOption.Text = "HTTP";
            this.HTTPOption.Click += new System.EventHandler(this.HTTPOption_Click);
            // 
            // TCPOption
            // 
            this.TCPOption.Name = "TCPOption";
            this.TCPOption.Size = new System.Drawing.Size(180, 22);
            this.TCPOption.Text = "TCP";
            this.TCPOption.Click += new System.EventHandler(this.TCPOption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 305);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultadoText);
            this.Controls.Add(this.Num2Text);
            this.Controls.Add(this.Num1Text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1Text;
        private System.Windows.Forms.TextBox Num2Text;
        private System.Windows.Forms.TextBox ResultadoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SumaOption;
        private System.Windows.Forms.ToolStripMenuItem RestaOption;
        private System.Windows.Forms.ToolStripMenuItem MultiplicacionOption;
        private System.Windows.Forms.ToolStripMenuItem DivisionOption;
        private System.Windows.Forms.ToolStripMenuItem protocoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HTTPOption;
        private System.Windows.Forms.ToolStripMenuItem TCPOption;
    }
}

