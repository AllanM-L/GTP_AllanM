namespace GTP_AllanM
{
    partial class Frm_GTP
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
            text_Tarea = new TextBox();
            btn_AgregarTarea = new Button();
            list_Tareas = new ListBox();
            btn_EliminarTarea = new Button();
            panel1 = new Panel();
            btn_LimpiarLista = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // text_Tarea
            // 
            text_Tarea.Location = new Point(41, 62);
            text_Tarea.Name = "text_Tarea";
            text_Tarea.Size = new Size(240, 23);
            text_Tarea.TabIndex = 0;
            // 
            // btn_AgregarTarea
            // 
            btn_AgregarTarea.Location = new Point(110, 104);
            btn_AgregarTarea.Name = "btn_AgregarTarea";
            btn_AgregarTarea.Size = new Size(108, 23);
            btn_AgregarTarea.TabIndex = 1;
            btn_AgregarTarea.Text = "Agregar Tarea";
            btn_AgregarTarea.UseVisualStyleBackColor = true;
            btn_AgregarTarea.Click += btn_AgregarTarea_Click;
            // 
            // list_Tareas
            // 
            list_Tareas.FormattingEnabled = true;
            list_Tareas.ItemHeight = 15;
            list_Tareas.Location = new Point(41, 141);
            list_Tareas.Name = "list_Tareas";
            list_Tareas.Size = new Size(240, 109);
            list_Tareas.TabIndex = 2;
            // 
            // btn_EliminarTarea
            // 
            btn_EliminarTarea.Location = new Point(40, 268);
            btn_EliminarTarea.Name = "btn_EliminarTarea";
            btn_EliminarTarea.Size = new Size(97, 23);
            btn_EliminarTarea.TabIndex = 3;
            btn_EliminarTarea.Text = "Eliminar Tarea";
            btn_EliminarTarea.UseVisualStyleBackColor = true;
            btn_EliminarTarea.Click += btn_EliminarTarea_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_LimpiarLista);
            panel1.Controls.Add(text_Tarea);
            panel1.Controls.Add(btn_EliminarTarea);
            panel1.Controls.Add(btn_AgregarTarea);
            panel1.Controls.Add(list_Tareas);
            panel1.Location = new Point(177, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 349);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btn_LimpiarLista
            // 
            btn_LimpiarLista.Location = new Point(184, 268);
            btn_LimpiarLista.Name = "btn_LimpiarLista";
            btn_LimpiarLista.Size = new Size(97, 23);
            btn_LimpiarLista.TabIndex = 4;
            btn_LimpiarLista.Text = "Limpiar Lista";
            btn_LimpiarLista.UseVisualStyleBackColor = true;
            btn_LimpiarLista.Click += btn_LimpiarLista_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 100);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 30);
            label1.Name = "label1";
            label1.Size = new Size(501, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Tareas Pendientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 49);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 7;
            label2.Text = "ALLAN MANZANILLAS";
            // 
            // Frm_GTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(685, 491);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.AppStarting;
            Name = "Frm_GTP";
            Text = "Frm_GTP";
            Load += Frm_GTP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox text_Tarea;
        private Button btn_AgregarTarea;
        private ListBox list_Tareas;
        private Button btn_EliminarTarea;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_LimpiarLista;
        private Panel panel3;
        private Label label2;
    }
}
