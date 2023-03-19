using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_7_Julian_B_Ortega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!ValidateFields())
            {
                lblError.Text = "* Faltan rellenar campos o uno de ellos tienes datos inválidos.";
                return;
            }

            Empleado nuevoEmpleado = new Empleado(inputNombre.Text.Trim(), Convert.ToInt32(inputDNI.Text.Trim()), 
                Convert.ToInt32(inputEdad.Text.Trim()), chkCasado.Checked, Convert.ToSingle(inputSalario.Text.Trim()));

            if (!DBFetcher.CreateEmpleado(nuevoEmpleado))
            {
                lblError.Text = "* ERROR - Ocurrió un error relacionado a la base de datos.";
                return;
            }

            lblError.Text = "";
            inputNombre.Clear();
            inputDNI.Clear();
            inputEdad.Clear();
            inputSalario.Clear();
            chkCasado.Checked = false;
            UpdateGrid();
        }

        private bool ValidateFields()
        {
            if (inputNombre.Text.Trim().Length < 1) return false;
            if (inputDNI.Text.Trim().Length < 1 || !int.TryParse(inputDNI.Text, out int dni)) return false;
            if (inputEdad.Text.Trim().Length < 1 || !int.TryParse(inputEdad.Text, out int edad)) return false;
            if (inputSalario.Text.Trim().Length < 1 || !float.TryParse(inputSalario.Text, out float salario)) return false;

            return true;
        }

        private void UpdateGrid()
        {
            dgEmpleados.AutoGenerateColumns = false;
            dgEmpleados.DataSource = DBFetcher.GetAllEmpleados();
            dgEmpleados.Refresh();
        }
    }
}
