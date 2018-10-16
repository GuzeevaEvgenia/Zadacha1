using Logic1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1
{
    

    public partial class DrawCircle : Form
    {
        Circle circle;

        public DrawCircle()
        {
            InitializeComponent();
        }

        private  void DrawButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TextBoxX.Text);
            int y = int.Parse(TextBoxY.Text);
            int radius = int.Parse(TextBoxR.Text);

            Logic1.Point center = new Logic1.Point(x, y);

            circle = new Circle(center, radius);

            PictureBox.Refresh();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (circle != null)
                e.Graphics.DrawEllipse(Pens.Black, circle.Center.X - circle.Radius, circle.Center.Y - circle.Radius, circle.Radius * 2, circle.Radius * 2);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (circle == null)
                return;

            int x = int.Parse(TextBoxX0.Text);
            int y = int.Parse(TextBoxY0.Text);


            if (circle.IsPointInCircle(new Logic1.Point(x,y)))
                MessageBox.Show("Точка принадлежит окружности!", "Проверка выполнена", MessageBoxButtons.OK);
            else
                MessageBox.Show("Точка не принадлежит окружности!", "Проверка выполнена", MessageBoxButtons.OK);
        }
    }
}
