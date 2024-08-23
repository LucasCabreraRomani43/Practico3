namespace Practico3
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            // la segunda parte e.KeyChar captura cada tecla que se presiona y lo comparamos con el espacio del teclado, porque el deni no tiene que tener espacios
            // entonces hay que convertirlo en char porque estamos comparando con otro tipo de dato por eso se castea con (char)
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ingrese numeros", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                e.Handled = true;
            }



        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //luego hacemos las verificaciones en base al valor obtenido del teclado, usaremos char.IsLetter si no es un valor que no sea letra y char.Iscontrol si es una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //no te deja ingresar mas datos al textbox en caso de que se cumpla la condicion
                MessageBox.Show("ingrese letras", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //luego hacemos las verificaciones en base al valor obtenido del teclado, usaremos char.IsLetter si no es un valor que no sea letra y char.Iscontrol si es una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //no te deja ingresar mas datos al textbox en caso de que se cumpla la condicion
                MessageBox.Show("ingrese letras", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Ttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ingrese numeros", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            // para ver si los datos estan cargados o no en los text box
            if (String.IsNullOrEmpty(Tdni.Text) || String.IsNullOrEmpty(Tapellido.Text) || String.IsNullOrEmpty(Tnombre.Text))
                {
                    //el primer parametro es el mensaje, el segunto es el titulo y el tercero o cuarto son los botones que van a aparecer

                    MessageBox.Show("Debe completar todos los campos correctamente", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
           
                
            }
            else
            {
                //permite modificar el label que se encuentra en rojo si pasa la primera validacion
                String dni = Tdni.Text;
                if((RBvaron.Checked && !RBmujer.Checked) || (!RBvaron.Checked && RBmujer.Checked) && (dni.Length == 8) ) { 
                Lmodificar.Text = "MODIFICADO";
                DialogResult ask = MessageBox.Show("Seguro que\r\ndesea insertar un nuevo Cliente?", "Confirmacion insercion", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    String Tnomcompleto = Tapellido.Text + " " + Tnombre.Text;
                    MessageBox.Show("El cliente:" + " " + Tnomcompleto + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                else
                {
                    MessageBox.Show("Debe completar todos campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }

        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            String Tnomcompleto = Tapellido.Text + " " + Tnombre.Text;

            if (String.Equals(Lmodificar.Text, "Modificar") == true)
            {
                MessageBox.Show("No hay cliente para eliminiar", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Esta a punto de eliminar al cliente:" + Tnomcompleto, "Confirmar eliminacion", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    Tdni.Clear();
                    Tapellido.Clear();
                    Tnombre.Clear();
                    Ttelefono.Clear();
                    Cnaranja.Checked = false;
                    Cvisa.Checked = false;
                    Cmaster.Checked = false;
                    RBmujer.Checked = false;
                    RBvaron.Checked = false;
                }
            }
        }

        private void RBmujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBmujer.Checked)
            {
             
                pictureBox1.Image = Practico3.Properties.Resources.Mujer;

            }


        }

        private void RBvaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBvaron.Checked)
            {
                pictureBox1.Image = Practico3.Properties.Resources.Hombre;

            }
        }
    }
}

        
    

