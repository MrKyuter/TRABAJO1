using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Usuario
            Usuario usuario = new Usuario(txtUsuario.Text, txtContrasena.Text, 0);

            // Verificar credenciales
            if (usuario.VerificarUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                MessageBox.Show("Login correcto");
            }
            else
            {
                MessageBox.Show("Login incorrecto");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        {
}
    }
    }

    internal class Usuario
    {
        public Usuario(string text1, string text2, int v)
        {
            Text1 = text1;
            Text2 = text2;
            V = v;
        }

        public string Text1 { get; }
        public string Text2 { get; }
        public int V { get; }

        internal bool VerificarUsuario(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
