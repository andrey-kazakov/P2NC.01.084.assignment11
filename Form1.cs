using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment11_AndreiKazakov
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1()
        {
            InitializeComponent();

            this.car = new Car(1967, "Chevrolet Impala");
            Draw();
        }

        private void Draw()
        {
            YearLabel.Text = car.year.ToString();
            MakeLabel.Text = car.make;
            SpeedLabel.Text = car.speed.ToString();
        }

        private void BrakeButton_Click(object sender, EventArgs e)
        {
            car.Brake();
            Draw();
        }

        private void AccelerateButton_Click(object sender, EventArgs e)
        {
            car.Accelerate();
            Draw();
        }
    }
}
