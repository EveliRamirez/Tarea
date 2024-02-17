using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{

    public partial class Form1 : Form
    {
        private Bitmap lienzoBitmap;
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tampincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;
        FormaGeometrica formaActual = FormaGeometrica.Ninguna;
        Color colorFiguras = Color.Black;
        Pen penFiguras;
        Color colorRelleno = Color.White;
        public Form1()
        {
            InitializeComponent();
            penFiguras = new Pen(colorFiguras, 2);
            lienzoBitmap = new Bitmap(lienzo.Width, lienzo.Height); 
            papel = lienzo.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tampincel = trackBartampincel.Value;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tampincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            trackBartampincel.Scroll += trackBartampincel_Scroll;
            btnCargarImagen.Click += BtnCargarImagen_Click;



        }



        private void picBlack_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }



        private void lienzo_MouseDown(object sender, MouseEventArgs e)
        {

            moviendo = true;
            x = e.X;
            y = e.Y;
            lienzo.Cursor = Cursors.Cross;
            if (pintar)
            {
                lienzo.Cursor = Cursors.Default;
            }
            else if (formaActual != FormaGeometrica.Ninguna)
            {
                x = e.X;
                y = e.Y;
                lienzo.Cursor = Cursors.Cross;
            }
        }

        private void lienzo_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            if (formaActual != FormaGeometrica.Ninguna && !pintar)
            {
                moviendo = false;
                switch (formaActual)
                {
                    case FormaGeometrica.Cuadrado:
                        DibujarForma(formaActual, new Point(x, y), e.Location);
                        break;
                    case FormaGeometrica.Circulo:
                        DibujarForma(formaActual, new Point(x, y), e.Location);
                        break;
                    case FormaGeometrica.Triangulo:

                        Point punto1 = new Point(x, y);
                        Point punto2 = new Point(e.X, y);
                        Point punto3 = new Point((x + e.X) / 2, e.Y);

                        DibujarTriangulo(punto1, punto2, punto3);
                        break;
                }
            }
        }

        private void lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                cambiarpincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X; y = e.Y;
            }
            if (moviendo && borrar)
            {

                cambiarpincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X; y = e.Y;

            }

        }
        private void cambiarpincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBartampincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            if
        (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorFiguras = colorDialog1.Color;
                penFiguras.Color = colorFiguras;
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();

            }
        }

        private void lienzo_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
            if (!pintar && !borrar)
            {
                formaActual = FormaGeometrica.Ninguna;
            }
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
            if (!pintar && !borrar)
            {
                formaActual = FormaGeometrica.Ninguna;
            }
        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            formaActual = FormaGeometrica.Cuadrado;

        }

        private void btncirculo_Click(object sender, EventArgs e)
        {
            formaActual = FormaGeometrica.Circulo;
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            formaActual = FormaGeometrica.Triangulo;
        }
        private void DibujarForma(FormaGeometrica forma, Point puntoInicial, Point puntoFinal)
        {

            Graphics g = lienzo.CreateGraphics();
            Pen pen = new Pen(colorFiguras, 2);
            Brush brush = new SolidBrush(colorFiguras);

            switch (forma)
            {
                case FormaGeometrica.Cuadrado:
                    int anchoCuadrado = Math.Abs(puntoFinal.X - puntoInicial.X);
                    int altoCuadrado = Math.Abs(puntoFinal.Y - puntoInicial.Y);
                    Rectangle rectanguloCuadrado = new Rectangle(puntoInicial.X, puntoInicial.Y, anchoCuadrado, altoCuadrado);
                    g.DrawRectangle(pen, rectanguloCuadrado);
                    break;
                case FormaGeometrica.Circulo:
                    int radio = Math.Max(Math.Abs(puntoFinal.X - puntoInicial.X), Math.Abs(puntoFinal.Y - puntoInicial.Y));
                    Rectangle rectanguloCirculo = new Rectangle(puntoInicial.X - radio, puntoInicial.Y - radio, radio * 2, radio * 2);
                    g.DrawEllipse(pen, rectanguloCirculo);
                    break;
                case FormaGeometrica.Triangulo:
                    // Implementa el dibujo del triángulo aquí
                    break;
            }

            g.Dispose();
        }
        public enum FormaGeometrica
        {
            Ninguna,
            Cuadrado,
            Circulo,
            Triangulo
        }

        private void DibujarTriangulo(Point punto1, Point punto2, Point punto3)
        {
            // Obtener el gráfico del lienzo
            Graphics g = lienzo.CreateGraphics();


            Point[] puntos = { punto1, punto2, punto3 };

            // Dibujar el triángulo
            g.DrawPolygon(penFiguras, puntos);

            g.Dispose();
        }
        private void trackBartampincel_Scroll(object sender, EventArgs e)
        {
            // Actualizar el valor del tamaño del pincel en el TextBox
            txtTamanoPincel.Text = trackBartampincel.Value.ToString();

            // Aplicar el nuevo tamaño del pincel
            pen.Width = trackBartampincel.Value;
        }
        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Establecer el filtro de archivos
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen seleccionada
                        Image imagen = Image.FromFile(openFileDialog.FileName);

                        // Ajustar el tamaño de la imagen para que se ajuste al PictureBox
                        lienzo.Image = new Bitmap(lienzo.Width, lienzo.Height);
                        Graphics g = Graphics.FromImage(lienzo.Image);
                        g.DrawImage(imagen, new Rectangle(0, 0, lienzo.Width, lienzo.Height));

                        // Liberar recursos
                        g.Dispose();
                        imagen.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }

                }

            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de imagen PNG|*.png|Archivos de imagen JPEG|*.jpg";
                    saveFileDialog.Title = "Guardar imagen";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ImageFormat formato = ImageFormat.Png; // Por defecto, se guarda como PNG
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            formato = ImageFormat.Jpeg;
                        }

                        // Guardar el contenido del lienzo como una imagen
                        lienzoBitmap.Save(saveFileDialog.FileName, formato);
                        MessageBox.Show("Imagen guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
            }
        
    



