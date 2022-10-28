namespace CheckedListBox
{
    partial class PruebaCheckedListBox
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
            this.Mostrarlistbox = new System.Windows.Forms.ListBox();
            this.Entradacheckedlistbox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Mostrarlistbox
            // 
            this.Mostrarlistbox.FormattingEnabled = true;
            this.Mostrarlistbox.ItemHeight = 16;
            this.Mostrarlistbox.Location = new System.Drawing.Point(474, 114);
            this.Mostrarlistbox.Name = "Mostrarlistbox";
            this.Mostrarlistbox.Size = new System.Drawing.Size(183, 180);
            this.Mostrarlistbox.TabIndex = 0;
            // 
            // Entradacheckedlistbox
            // 
            this.Entradacheckedlistbox.FormattingEnabled = true;
            this.Entradacheckedlistbox.Items.AddRange(new object[] {
            "C++HTP",
            "Java HTP",
            "VB HTP",
            "Internet y WWW",
            "Perl HTP",
            "Python HTP",
            "Internet inalámbrica HTP",
            "Java avanzado HTP"});
            this.Entradacheckedlistbox.Location = new System.Drawing.Point(241, 114);
            this.Entradacheckedlistbox.Name = "Entradacheckedlistbox";
            this.Entradacheckedlistbox.Size = new System.Drawing.Size(173, 157);
            this.Entradacheckedlistbox.TabIndex = 1;
            this.Entradacheckedlistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Entradacheckedlistbox_ItemCheck);
            // 
            // PruebaCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Entradacheckedlistbox);
            this.Controls.Add(this.Mostrarlistbox);
            this.Name = "PruebaCheckedListBox";
            this.Text = "PruebaCheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Mostrarlistbox;
        private System.Windows.Forms.CheckedListBox Entradacheckedlistbox;
    }
}

