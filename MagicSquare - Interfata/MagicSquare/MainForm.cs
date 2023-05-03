using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MagicSquare
{
    public partial class MainForm : Form
    {
        private int _squareSize, _squareSum;
        private int[,] _squareMatrix;
        private Bitmap _bmp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBoxSquare_Paint(object sender, PaintEventArgs e)
        {
            // evenimentul de desenare

            _bmp = new Bitmap(pictureBoxSquare.Width, pictureBoxSquare.Height);
            Graphics g = Graphics.FromImage(_bmp);

            Font drawFont = new Font("Arial", 15);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            Pen blackPen = new Pen(Color.Black, 3);

            g.Clear(Color.White);

            if (_squareMatrix != null)
            {
                for (int i = 0; i < _squareSize; i++)
                    for (int j = 0; j < _squareSize; j++)
                    {
                        g.DrawString(_squareMatrix[i,j].ToString(), drawFont, drawBrush, i*50, j*50, drawFormat);
                    }

                for (int i = 0; i <= _squareSize; i++)
                {
                    PointF point1 = new PointF(i*50, 0);
                    PointF point2 = new PointF(i*50, _squareSize*50);
                    g.DrawLine(blackPen, point1, point2);

                    PointF point3 = new PointF(0, i*50);
                    PointF point4 = new PointF(_squareSize * 50, i*50);
                    g.DrawLine(blackPen, point3, point4);
                }
            }

            e.Graphics.DrawImage(_bmp, 0, 0);

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // calculeaza patratul
            _squareSize = Convert.ToInt32(this.textBoxSize.Text);
            MagicBuilder mb = new MagicBuilder(_squareSize);
            _squareMatrix = mb.BuildMagicSquare();

            // apeleaza evenimentul de desenare cu metoda Refresh
            pictureBoxSquare.Refresh();
            textBoxSum.Enabled = true;
            if (textBoxSum.Enabled == true)
            {
                int suma = 0;
                for (int i = 0; i < _squareSize; i++)
                    suma += _squareMatrix[i, 0];
                textBoxSum.Text = suma.ToString();
            }
            // codul din aceasta metoda trebuie inclus intr-un bloc de tratare a exceptiilor
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                buttonSave.Image = _bmp;
                buttonSave.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                fs.Close();
            }


        }

        private void buttonChm_Click(object sender, EventArgs e)
        {
            // afiseaza help-ul
             //System.Diagnostics.Process.Start("helpPmagic.chm");
            Help.ShowHelp(this, "C:\\Users\\40732\\Desktop\\ip\\l4\\MagicSquare - Interfata\\MagicSquare\\helpPmagic.chm");
            //Help.ShowHelpIndex(this, "helpPmagic.chm");
           // Help.ShowHelpIndex(this, "helpPmagic.chm");


        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie patrat magic, Ingineria Programarii v2");
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSum.Enabled == true)
            {
                int suma = 0;
                for(int i=0; i<_squareSize; i++)
                    suma+= _squareMatrix[i,0];
                textBoxSum.Text = suma.ToString();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}