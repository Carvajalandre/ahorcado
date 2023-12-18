using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ArrayStringCarvajal
{
    public partial class frmLecturaArchivo : Form
    {
        const int MAX = 1000;
        string[] arrayNombres;
        int totalElementos;
        Random random = new Random();
        TextBox[] arrayTextBoxs;
        Color colorPar;

        public frmLecturaArchivo()
        {
            InitializeComponent();
            arrayTextBoxs = new TextBox[16];
            for (int i = 0; i < 16; i++)
            {
                arrayTextBoxs[i] = new TextBox();
                arrayTextBoxs[i].Location = new System.Drawing.Point(8 + i * 40, 280);
                arrayTextBoxs[i].Size = new System.Drawing.Size(30, 20);
                arrayTextBoxs[i].CharacterCasing = CharacterCasing.Upper;
                arrayTextBoxs[i].TextAlign = HorizontalAlignment.Center;
                arrayTextBoxs[i].TextChanged += TextBox_TextChanged;  // Agregamos el evento TextChanged
                this.Controls.Add(arrayTextBoxs[i]);
            }

            colorPar = GetRandomColor();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Title = "Seleccione el archivo de texto",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "archivos txt (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtArchivo.Text = openFileDialog1.FileName;
                this.LeerArchivoTexto(this.txtArchivo.Text);
            }
        }

        private void LeerArchivoTexto(string nombreArchivo)
        {
            String line;
            arrayNombres = new string[MAX];
            int cont = 0;
            totalElementos = 0;
            try
            {
                StreamReader sr = new StreamReader(nombreArchivo, Encoding.UTF8);
                line = sr.ReadLine();
                while (line != null && cont < MAX)
                {
                    arrayNombres[cont] = line;
                    totalElementos++;
                    line = sr.ReadLine();
                    cont++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void btnSeleccionarNombre_Click(object sender, EventArgs e)
        {
            int indiceAleatorio = random.Next(0, totalElementos);
            string nombreSeleccionado = arrayNombres[indiceAleatorio];

            for (int i = 0; i < 16; i++)
            {
                arrayTextBoxs[i].Text = string.Empty;
                arrayTextBoxs[i].BackColor = Color.White;
            }

            for (int i = 0; i < Math.Min(nombreSeleccionado.Length, 16); i++)
            {
                arrayTextBoxs[i].Text = nombreSeleccionado[i].ToString();
                if (i % 2 == 0)
                {
                    arrayTextBoxs[i].BackColor = colorPar;
                }
            }

            colorPar = GetRandomColor();
        }

        private Color GetRandomColor()
        {
            string[] colors = { "LightBlue", "LightGreen", "LightGoldenrodYellow", "LightSalmon", "Orange", "LightCoral", "LightCyan" };
            string randomColor = colors[random.Next(0, colors.Length)];
            return Color.FromName(randomColor);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verificar si el carácter ingresado coincide con alguna letra en los TextBox
            if (txtCaracter.Text.Length > 0)
            {
                char caracterIngresado = txtCaracter.Text.ToUpper()[0];

                if (!string.IsNullOrEmpty(textBox.Text) && (textBox.Text.ToUpper()[0] == caracterIngresado || textBox.Text.ToLower()[0] == caracterIngresado))
                {
                    textBox.ForeColor = Color.DarkViolet;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                }
            }
            else
            {
                textBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtCaracter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaracter.Text))
            {
                foreach (TextBox textBox in arrayTextBoxs)
                {
                    textBox.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}
