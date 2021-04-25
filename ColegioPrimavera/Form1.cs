using ColegioPrimavera.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioPrimavera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            comboBox1.DataSource = bd.Cursos.ToList();
            comboBox1.DisplayMember = "nombre";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            Curso cursoSelec = (Curso)comboBox1.SelectedItem;

            List<Alumno> alumnos = bd.Alumnos.Where(alumno => alumno.idCurso == cursoSelec.idCurso).ToList();

            List<Profesore> profesores = bd.Profesores.Where(profesor => profesor.idProfesor == cursoSelec.idProfesor).ToList();

            textBox1.ReadOnly = true;
            textBox1.Text = cursoSelec.Profesore.nombre;

            dataGridView1.DataSource = alumnos;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
