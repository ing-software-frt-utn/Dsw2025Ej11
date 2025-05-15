namespace Dsw2025Ej11.Graphics
{
    partial class EstrellaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEstrella = new Label();
            SuspendLayout();
            // 
            // lblEstrella
            // 
            lblEstrella.Dock = DockStyle.Fill;
            lblEstrella.Font = new Font("Wingdings", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstrella.ForeColor = Color.White;
            lblEstrella.Location = new Point(0, 0);
            lblEstrella.Margin = new Padding(0);
            lblEstrella.Name = "lblEstrella";
            lblEstrella.Size = new Size(26, 26);
            lblEstrella.TabIndex = 0;
            lblEstrella.Text = "¬";
            lblEstrella.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EstrellaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblEstrella);
            Margin = new Padding(0);
            Name = "EstrellaControl";
            Size = new Size(26, 26);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblEstrella;
    }
}
