using System;
using System.Numerics;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ReinitializeAndDraw()
        {
            Scene scene = new Scene(new Vector3((float)(Math.Cos((float)X.Value) * Math.Cos((float)Y.Value)),
                                                                (float)Math.Sin((float)Y.Value), 
                                                                (float)(Math.Sin((float)X.Value) * Math.Cos((float)Y.Value))),
                                   new Vector3((float)XLight.Value, (float)YLight.Value, (float)ZLight.Value),
                                   new Vector3(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B),
                                   (float)LightIntensity.Value,
                                   (int)SpecPower.Value,
                                   (int)Size.Value);
            canvas.Image = scene.DrawPicture(canvas.Width, canvas.Height, (float)Height.Value, (float)Radius.Value);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void X_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void Y_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void Z_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void Height_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void Radius_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void Size_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void XLight_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void YLight_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void ZLight_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void LightIntensity_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }

        private void pickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                ReinitializeAndDraw();
        }

        private void SpecPower_ValueChanged(object sender, EventArgs e)
        {
            ReinitializeAndDraw();
        }
    }
}
