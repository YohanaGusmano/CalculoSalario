using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form

    {

        Empleado myEmpleado= new Empleado();
        Sueldo mySueldo = new Sueldo();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLuiquidacionDeSueldo.Text = mySueldo.CalcularSueldo(Convert.ToInt32 (mySueldo.DiasLaborados),
                Convert.ToDecimal(myEmpleado.AsignacionDia )) .ToString(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_Click(object sender, EventArgs e)

        {
            // Valida que se ingrese un dato
            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, " debe ingresar un nombre ");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            //Validar que solo permita ingresar datos numericos

            decimal AsignacionDia;
            if (! Decimal.TryParse (txtAsigDiaDeTrabajo.Text,out AsignacionDia))

            {
                error1.SetError (txtAsigDiaDeTrabajo, " Debe ingresar un numero ");
                txtAsigDiaDeTrabajo.Focus();
                return;
            }


            error1.SetError(txtAsigDiaDeTrabajo, "");



            myEmpleado.Nombre = txtNombre.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myEmpleado.AsignacionDia= Convert.ToDecimal(txtAsigDiaDeTrabajo.Text);
            mySueldo.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Se guardo el registro correctamente");

        }

        private void txtDiasLaborados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsigDiaDeTrabajo.Clear();
            txtDiasLaborados.Clear();
            txtLuiquidacionDeSueldo.Clear();   

        }
    }
}
