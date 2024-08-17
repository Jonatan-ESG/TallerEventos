namespace TellerEventos
{
    partial class ControlTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTareas));
            txtNombreTarea = new TextBox();
            btnAgregarTarea = new Button();
            flowPanelTareaPendientes = new FlowLayoutPanel();
            btnEliminarUltimaTarea = new Button();
            SuspendLayout();
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(19, 24);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.PlaceholderText = "Ingrese su tarea";
            txtNombreTarea.Size = new Size(463, 27);
            txtNombreTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarTarea.Location = new Point(488, 22);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(146, 29);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // flowPanelTareaPendientes
            // 
            flowPanelTareaPendientes.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaPendientes.Location = new Point(19, 82);
            flowPanelTareaPendientes.Name = "flowPanelTareaPendientes";
            flowPanelTareaPendientes.Size = new Size(337, 356);
            flowPanelTareaPendientes.TabIndex = 2;
            // 
            // btnEliminarUltimaTarea
            // 
            btnEliminarUltimaTarea.Location = new Point(566, 110);
            btnEliminarUltimaTarea.Name = "btnEliminarUltimaTarea";
            btnEliminarUltimaTarea.Size = new Size(146, 52);
            btnEliminarUltimaTarea.TabIndex = 3;
            btnEliminarUltimaTarea.Text = "Eliminar Ultima Tarea";
            btnEliminarUltimaTarea.UseVisualStyleBackColor = true;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarUltimaTarea);
            Controls.Add(flowPanelTareaPendientes);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtNombreTarea);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControlTareas";
            Text = "ControlTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreTarea;
        private Button btnAgregarTarea;
        private FlowLayoutPanel flowPanelTareaPendientes;
        private Button btnEliminarUltimaTarea;
    }
}
