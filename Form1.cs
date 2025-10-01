// Estas librerías son necesarias para el funcionamiento del programa
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// Esta librería se usa para trabajar con expresiones regulares.
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holamundo
{
    // Esta es la clase principal de nuestro formulario.
    public partial class Form1 : Form
    {
        // Este es el Constructor del formulario este se ejecuta cuando se abre el programa.
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario (botones, textos, etc.)
        }

        // Aqui esta el evento que se ejecuta cuando el usuario hace clic en el botón de "Validar contraseña"
        private void btnValidar_Click(object sender, EventArgs e)
        {
            /*
             * Requisitos de la contraseña:
             * - Debe tener al menos una letra mayúscula
             * - Debe tener al menos una letra minúscula
             * - Debe tener al menos un símbolo
             * - Debe tener al menos un número
             */

            // Guardamos lo que el usuario escribió en las cajas de texto
            string contrasena1 = txtcontrasena1.Text;  // Primer campo de contraseña
            string contrasena2 = txtcontrasena2.Text;  // Segundo campo de contraseña (repetición)

            // Expresión regular que define los requisitos de la contraseña
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).+$";

            // Se verifica si la primera contraseña cumple con el patrón
            bool valido = Regex.IsMatch(contrasena1, patron);

            //  Esta es la funcion if(si) donde si la contraseña NO cumple con los requisitos , muestra un mensaje de texto...
            if (!valido)
            {
                // Muestra un mensaje de error y muestra que error es..
                MessageBox.Show("La contraseña no contiene los caracteres esperados al menos una letra mayúscula, Al menos una letra minúscula, Al menos un símbolo, Al menos un número...");
                return; // con esto se detiene la ejecución del método
            }

            // Aqui es si las dos contraseñas no son iguales...
            if (!contrasena1.Equals(contrasena2))
            {
                // Muestra otro mensaje de error
                MessageBox.Show("Las contraseñas no coinciden rectifica que ambas son iguales...");
                return; // Se detiene la ejecución del método
            }

            // Si pasa todas las validaciones anteriores, muestra un mensaje de éxito
            MessageBox.Show("La contraseña es válida");
        }
    }
}


