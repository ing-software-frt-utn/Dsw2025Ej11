namespace Dsw2025Ej11.Graphics
{
    partial class ConstalacionView
    {
        // /// <summary>
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
            layoutBase = new TableLayoutPanel();
            pConstelacion = new Panel();
            pControles = new Panel();
            btnEliminar = new Button();
            lblNovedades = new Label();
            btnAgregar = new Button();
            layoutBase.SuspendLayout();
            pControles.SuspendLayout();
            SuspendLayout();
            // 
            // layoutBase
            // 
            layoutBase.ColumnCount = 1;
            layoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutBase.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            layoutBase.Controls.Add(pConstelacion, 0, 0);
            layoutBase.Controls.Add(pControles, 0, 1);
            layoutBase.Dock = DockStyle.Fill;
            layoutBase.Location = new Point(0, 0);
            layoutBase.Margin = new Padding(4, 3, 4, 3);
            layoutBase.Name = "layoutBase";
            layoutBase.RowCount = 2;
            layoutBase.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            layoutBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            layoutBase.Size = new Size(1176, 841);
            layoutBase.TabIndex = 0;
            // 
            // pConstelacion
            // 
            pConstelacion.BackColor = Color.Black;
            pConstelacion.Dock = DockStyle.Fill;
            pConstelacion.Location = new Point(4, 3);
            pConstelacion.Margin = new Padding(4, 3, 4, 3);
            pConstelacion.Name = "pConstelacion";
            pConstelacion.Size = new Size(1168, 789);
            pConstelacion.TabIndex = 0;
            // 
            // pControles
            // 
            pControles.Controls.Add(btnEliminar);
            pControles.Controls.Add(lblNovedades);
            pControles.Controls.Add(btnAgregar);
            pControles.Dock = DockStyle.Fill;
            pControles.Location = new Point(4, 798);
            pControles.Margin = new Padding(4, 3, 4, 3);
            pControles.Name = "pControles";
            pControles.Size = new Size(1168, 40);
            pControles.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(971, 7);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 27);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNovedades
            // 
            lblNovedades.AutoSize = true;
            lblNovedades.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNovedades.Location = new Point(246, 8);
            lblNovedades.Margin = new Padding(4, 0, 4, 0);
            lblNovedades.Name = "lblNovedades";
            lblNovedades.Size = new Size(177, 20);
            lblNovedades.TabIndex = 1;
            lblNovedades.Text = "Cantidad de Estrellas: 0";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(46, 7);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 27);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Estrella";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ConstalacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 841);
            Controls.Add(layoutBase);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConstalacionView";
            Text = "Mi Constelación";
            layoutBase.ResumeLayout(false);
            pControles.ResumeLayout(false);
            pControles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.Panel pConstelacion;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNovedades;
        private System.Windows.Forms.Button btnEliminar;
    }
}
