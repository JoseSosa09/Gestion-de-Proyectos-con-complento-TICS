using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RJM
{
    public partial class REGISTRO : Form
    {
        private ErrorProvider errorProvider;
        private static String error = "";
        private String[] auxiliarMaestro = new string[7];
        private String[] auxiliarMateria = new string[7];
        private int aux = 0;

        public REGISTRO()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            cargarData();
        }

        private void btnAceptar(object sender, EventArgs e)
        {
            try
            {
                LOGIN login = new LOGIN();                
                CN_Alumno oalumno = new CN_Alumno();
                CN_ALUMNO_MATERIA_MAESTRO omateria = new CN_ALUMNO_MATERIA_MAESTRO();

                oalumno.RegistrarAlumno(textNombre.Text, textApellido.Text, textTelefono.Text, textEmail.Text, textNumeroControl.Text, textPassword.Text);
                
                for(int i = 0; i < auxiliarMateria.Length; i++)
                {
                    omateria.Insert(textNumeroControl.Text, auxiliarMateria[i], auxiliarMaestro[i]);
                }

                MessageBox.Show("Se ha registrado de manera correcta", "Registrado", MessageBoxButtons.OK);
                this.Hide();
                login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {

            if (validarUsuarios() && camposVacios())
            {
                panelDPersonales.Visible = false;
                panelMaterias.Visible = true;

            }
            else
            {
                MessageBox.Show("No puedes continuar. " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cargarData()
        {
            CN_Maestro maestro = new CN_Maestro();
            cBMateria.DisplayMember = "nombre";
            cBMateria.DataSource = maestro.dataTableMaterias();
            cBMateria.DropDownStyle = ComboBoxStyle.DropDownList;

            cBMaestro.DisplayMember = "nombreCompleto";
            cBMaestro.DataSource = maestro.dataTableMaestros();
            cBMaestro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void agregarMateria_Click(object sender, EventArgs e)
        {
            String materia = cBMateria.Text;
            String maestro = cBMaestro.Text;

            if (validarMateria(materia))
            {
                if (aux < 7)
                {
                    try
                    {
                        dgvMaterias.Rows.Add(new object[] { materia, maestro, "" });
                        auxiliarMateria[aux] = materia;
                        auxiliarMaestro[aux] = maestro;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    aux++;
                }
                else
                {
                    MessageBox.Show("Solamente puedes escoger 7 Materias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("No puedes repetir materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarMateria(String materia)
        {        
            for (int i = 0; i < auxiliarMateria.Length; i++)
            {
                if (auxiliarMateria[i] == materia)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (dgvMaterias.Columns[e.ColumnIndex].Name == "borrarButton")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {                    
                    if (indice != null)
                    {
                        if (MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            dgvMaterias.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Se ha eliminado de manera correcta", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aux--;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvIntegrador_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.x_button.Width;
                var h = Properties.Resources.x_button.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.x_button, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelMaterias.Visible = false;
            panelDPersonales.Visible = true;
        }

        private bool camposVacios()
        {
            if (textNombre.Text.Length < 4 || textNombre.Text == "NOMBRE")
            {
                error = "es necesario llenar todos los campos";
                return false;
            }
            else if (textApellido.Text.Length < 4 || textApellido.Text == "APELLIDO")
            {
                error = "es necesario llenar todos los campos";
                return false;
            }
            else if (textTelefono.Text.Length < 4 || textTelefono.Text == "TELEFONO")
            {
                error = "es necesario llenar todos los campos";

                return false;
            }
            else if (textNumeroControl.Text.Length < 4 || textNumeroControl.Text == "NUMERO CONTROL")
            {
                error = "es necesario llenar todos los campos";

                return false;
            }
            else if (textEmail.Text.Length < 4 || textEmail.Text == "EMAIL")
            {
                error = "es necesario llenar todos los campos";

                return false;
            }
            else if (textPassword.Text.Length < 4 || textPassword.Text == "PASSWORD")
            {
                error = "es necesario llenar todos los campos";

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarUsuarios()
        {
            List<Alumno> alumnos = new CN_Alumno().Listar();

            String numeroControl = textNumeroControl.Text;
            String email = textEmail.Text;
            String telefono = textTelefono.Text;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.numeroControl == numeroControl)
                {
                    error = "Ya existe ese Número de Control";
                    return false;
                }
                if (alumno.email == email)
                {
                    error = "Ya existe ese Email";
                    return false;
                }
                if (alumno.telefono == telefono)
                {
                    error = "Ya existe ese Teléfono";
                    return false;
                }
            }
            return true;

        }

        private void validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string id = textBox.Name;
            string texto = textBox.Text;

            switch (id)
            {
                case "textNombre":
                    if (!validarNombre(texto) || texto == "NOMBRE")
                    {
                        errorProvider.SetError(textBox, "Nombre Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textApellido":
                    if (!validarNombre(texto) || texto == "APELLIDO")
                    {
                        errorProvider.SetError(textBox, "Apellido Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textTelefono":
                    if (!validarNumeroTelefono(texto) || texto == "TELEFONO")
                    {
                        errorProvider.SetError(textBox, "Numero Telefono Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textNumeroControl":
                    if (!validarNumeroControl(texto) || texto == "NUMERO CONTORL")
                    {
                        errorProvider.SetError(textBox, "Numero Control Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textEmail":
                    if (!validarEmail(texto) || texto == "EMAIL")
                    {
                        errorProvider.SetError(textBox, "Email Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
            }
        }

        private bool validarNombre(String nombre)
        {
            string patron = @"^[\p{L}\s\-']+$";
            return Regex.IsMatch(nombre, patron);
        }

        private bool validarEmail(String email)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, patron);
        }

        private bool validarNumeroTelefono(String numeroTelefono)
        {
            string patron = @"^[0-9()+-]+$";
            return Regex.IsMatch(numeroTelefono, patron);
        }

        private bool validarNumeroControl(String numeroTelefono)
        {
            string patron = @"^\d{8}$";
            return Regex.IsMatch(numeroTelefono, patron);
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "NOMBRE")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.White;
            }
            else
            {
                textNombre.ForeColor = Color.White;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "NOMBRE";
                textNombre.ForeColor = Color.Gold;
            }
            else
            {
                textNombre.ForeColor = Color.White;
            }
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "APELLIDO")
            {
                textApellido.Text = "";
                textApellido.ForeColor = Color.White;
            }
            else
            {
                textApellido.ForeColor = Color.White;
            }
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "APELLIDO";
                textApellido.ForeColor = Color.Gold;
            }
            else
            {
                textApellido.ForeColor = Color.White;
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Text == "TELEFONO")
            {
                textTelefono.Text = "";
                textTelefono.ForeColor = Color.White;
            }
            else
            {
                textTelefono.ForeColor = Color.White;
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Text == "")
            {
                textTelefono.Text = "TELEFONO";
                textTelefono.ForeColor = Color.Gold;
            }
            else
            {
                textTelefono.ForeColor = Color.White;
            }
        }

        private void textNumeroControl_Enter(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "NUMERO CONTROL")
            {
                textNumeroControl.Text = "";
                textNumeroControl.ForeColor = Color.White;
            }
            else
            {
                textNumeroControl.ForeColor = Color.White;
            }
        }

        private void textNumeroControl_Leave(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "")
            {
                textNumeroControl.Text = "NUMERO CONTROL";
                textNumeroControl.ForeColor = Color.Gold;
            }
            else
            {
                textNumeroControl.ForeColor = Color.White;
            }
        }

        private void tBEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "EMAIL")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
            else
            {
                textEmail.ForeColor = Color.White;
            }
        }

        private void tBEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "EMAIL";
                textEmail.ForeColor = Color.Gold;
            }
            else
            {
                textEmail.ForeColor = Color.White;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "PASSWORD")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "PASSWORD";
                textPassword.ForeColor = Color.Gold;
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
        }


        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void registrateCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de cerrar la ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void registrateMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void REGISTRO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (errorProvider.GetError(textNombre) != "" ||
                errorProvider.GetError(textApellido) != "" ||
                errorProvider.GetError(textTelefono) != "" ||
                errorProvider.GetError(textNumeroControl) != "" ||
                errorProvider.GetError(textEmail) != "")
            {
                // Hay errores presentes en el ErrorProvider, cancelar el cierre del formulario
                e.Cancel = false;
            }
        }

        private void REGISTRO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
