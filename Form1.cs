using System.Drawing.Printing;
using TellerEventos.Clases;

namespace TellerEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public ControlTareas()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (txtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un nombre para la tarea");
                return;
            }

            Tarea nuevaTarea = new Tarea(txtNombreTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            this.renderizarTareas();

        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(5);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                    tarjeta.Cursor = Cursors.Hand;
                };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };


                flowPanelTareaPendientes.Controls.Add(tarjeta);
            }
        }


        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            tareas.RemoveAt(tareas.Count - 1);
            this.renderizarTareas();
        }
    }
}
