namespace SysPecNSDesk
{
    partial class FrmCliente
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
            groupBox1 = new GroupBox();
            tabPageEndereco = new TabControl();
            tabPageCliente = new TabPage();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            tabPageEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabPageEndereco);
            groupBox1.Location = new Point(80, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 318);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabPageEndereco
            // 
            tabPageEndereco.Controls.Add(tabPageCliente);
            tabPageEndereco.Controls.Add(tabPage2);
            tabPageEndereco.Location = new Point(30, 44);
            tabPageEndereco.Name = "tabPageEndereco";
            tabPageEndereco.SelectedIndex = 0;
            tabPageEndereco.Size = new Size(252, 162);
            tabPageEndereco.TabIndex = 1;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(192, 72);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "tabPage1";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(244, 134);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            groupBox1.ResumeLayout(false);
            tabPageEndereco.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabPageEndereco;
        private TabPage tabPageCliente;
        private TabPage tabPage2;
    }
}