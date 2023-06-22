using FactoryMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryM
{
	public partial class Form1 : Form
	{
		private Animal animal;
		private Random random;

		public Form1()
		{
			InitializeComponent();
			random = new Random();
			GenerateAnimal();
		}

		private void btnGenerateAnimal_Click(object sender, EventArgs e)
		{
			GenerateAnimal();
		}

		private void GenerateAnimal()
		{
			int rInt = random.Next(0, 3);

			switch (rInt)
			{
				case 0:
					animal = new Vaca();
					pictureBoxAnimal.Image = Image.FromFile(@"Images\Vaca.jpg");
					break;
				case 1:
					animal = new Pajaro();
					pictureBoxAnimal.Image = Image.FromFile(@"Images\Pajaro.jpg");
					break;
				case 2:
					animal = new Serpiente();
					pictureBoxAnimal.Image = Image.FromFile(@"Images\Serpiente.jpg");
					break;
				default:
					animal = new Vaca();
					pictureBoxAnimal.Image = Image.FromFile(@"Images\Vaca.jpg");
					break;
			}

			lblAnimal.Text = animal.Render();
		}
	}
}
