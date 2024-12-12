namespace GTP_AllanM
{
    public partial class Frm_GTP : Form
    {
        public Frm_GTP()
        {
            InitializeComponent();
        }

        
        private void Frm_GTP_Load(object sender, EventArgs e)
        {
            text_Tarea.Focus(); 
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btn_AgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_Tarea.Text))
            {
                list_Tareas.Items.Add(text_Tarea.Text); 
                text_Tarea.Clear(); 
                text_Tarea.Focus(); 
            }
            else
            {
                MessageBox.Show("Ingresa una tarea.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btn_LimpiarLista_Click(object sender, EventArgs e)
        {
            if (list_Tareas.Items.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Deseas limpiar la lista de tareas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    list_Tareas.Items.Clear(); 
                }
            }
            else
            {
                MessageBox.Show("La lista ya está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void text_Tarea_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_EliminarTarea_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Evento btn_EliminarTarea_Click ejecutado");
            if (list_Tareas.SelectedItem != null)
            {
                list_Tareas.Items.Remove(list_Tareas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecciona la tarea que eliminará.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
