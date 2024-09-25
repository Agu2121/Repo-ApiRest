using System;
using System.Windows.Forms;
using WindowsFormsApp.Controllers;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private PersonajeController personajeController;
        private Personajes personajes;
        public Form1()
        {
            InitializeComponent();
            personajeController = new PersonajeController();
            personajes = new Personajes();
        }

        private async void GetPersonajes()
        {
            personajes = await personajeController.GetAllPersonajes();

            if (personajes != null )
            {
                foreach (var personaje in personajes.results) 
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtgDatos);

                    row.Cells[0].Value = personaje.name;
                    row.Cells[1].Value = personaje.gender;
                    row.Cells[2].Value = personaje.species;
                    row.Cells[3].Value = personaje.origin.name;

                    dtgDatos.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la petición", 
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnGetPersonajes_Click(object sender, EventArgs e)
        {
            GetPersonajes();
        }
    }
}
