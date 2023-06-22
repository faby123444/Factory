namespace FactoryM
{
		partial class Form1
		{
			private System.ComponentModel.IContainer components = null;
			private System.Windows.Forms.Button btnGenerateAnimal;
			private System.Windows.Forms.Label lblAnimal;
			private System.Windows.Forms.PictureBox pictureBoxAnimal;

			private void InitializeComponent()
			{
				this.btnGenerateAnimal = new System.Windows.Forms.Button();
				this.lblAnimal = new System.Windows.Forms.Label();
				this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
				((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
				this.SuspendLayout();
				// 
				// btnGenerateAnimal
				// 
				this.btnGenerateAnimal.Location = new System.Drawing.Point(12, 12);
				this.btnGenerateAnimal.Name = "btnGenerateAnimal";
				this.btnGenerateAnimal.Size = new System.Drawing.Size(200, 50);
				this.btnGenerateAnimal.Text = "Generar Animal";
				this.btnGenerateAnimal.UseVisualStyleBackColor = true;
				this.btnGenerateAnimal.Click += new System.EventHandler(this.btnGenerateAnimal_Click);
				this.Controls.Add(this.btnGenerateAnimal);
				// 
				// lblAnimal
				// 
				this.lblAnimal.AutoSize = true;
				this.lblAnimal.Location = new System.Drawing.Point(12, 80);
				this.lblAnimal.Name = "lblAnimal";
				this.lblAnimal.Size = new System.Drawing.Size(0, 20);
				this.Controls.Add(this.lblAnimal);
				// 
				// pictureBoxAnimal
				// 
				this.pictureBoxAnimal.Location = new System.Drawing.Point(12, 120);
				this.pictureBoxAnimal.Name = "pictureBoxAnimal";
				this.pictureBoxAnimal.Size = new System.Drawing.Size(200, 200);
				this.pictureBoxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				this.Controls.Add(this.pictureBoxAnimal);
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Name = "Form1";
				this.Text = "Animal Generator";
				((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();
			}
		}
	}
