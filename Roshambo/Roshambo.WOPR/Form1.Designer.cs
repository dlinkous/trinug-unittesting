namespace Roshambo.WOPR
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.USA = new System.Windows.Forms.Label();
			this.USSR = new System.Windows.Forms.Label();
			this.TIE = new System.Windows.Forms.Label();
			this.DotUSA = new System.Windows.Forms.PictureBox();
			this.DotUSSR = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DotUSA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DotUSSR)).BeginInit();
			this.SuspendLayout();
			// 
			// USA
			// 
			this.USA.BackColor = System.Drawing.Color.Transparent;
			this.USA.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.USA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(175)))), ((int)(((byte)(245)))));
			this.USA.Location = new System.Drawing.Point(147, 523);
			this.USA.Name = "USA";
			this.USA.Size = new System.Drawing.Size(76, 34);
			this.USA.TabIndex = 0;
			this.USA.Text = "0";
			this.USA.Visible = false;
			// 
			// USSR
			// 
			this.USSR.BackColor = System.Drawing.Color.Transparent;
			this.USSR.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.USSR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(175)))), ((int)(((byte)(245)))));
			this.USSR.Location = new System.Drawing.Point(615, 523);
			this.USSR.Name = "USSR";
			this.USSR.Size = new System.Drawing.Size(76, 34);
			this.USSR.TabIndex = 1;
			this.USSR.Text = "0";
			this.USSR.Visible = false;
			// 
			// TIE
			// 
			this.TIE.BackColor = System.Drawing.Color.Transparent;
			this.TIE.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
			this.TIE.Location = new System.Drawing.Point(373, 523);
			this.TIE.Name = "TIE";
			this.TIE.Size = new System.Drawing.Size(76, 34);
			this.TIE.TabIndex = 2;
			this.TIE.Text = "0";
			this.TIE.Visible = false;
			// 
			// DotUSA
			// 
			this.DotUSA.BackColor = System.Drawing.Color.Transparent;
			this.DotUSA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DotUSA.BackgroundImage")));
			this.DotUSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.DotUSA.Location = new System.Drawing.Point(225, 165);
			this.DotUSA.Name = "DotUSA";
			this.DotUSA.Size = new System.Drawing.Size(28, 27);
			this.DotUSA.TabIndex = 3;
			this.DotUSA.TabStop = false;
			this.DotUSA.Visible = false;
			// 
			// DotUSSR
			// 
			this.DotUSSR.BackColor = System.Drawing.Color.Transparent;
			this.DotUSSR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DotUSSR.BackgroundImage")));
			this.DotUSSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.DotUSSR.Location = new System.Drawing.Point(555, 109);
			this.DotUSSR.Name = "DotUSSR";
			this.DotUSSR.Size = new System.Drawing.Size(28, 27);
			this.DotUSSR.TabIndex = 4;
			this.DotUSSR.TabStop = false;
			this.DotUSSR.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(787, 647);
			this.Controls.Add(this.DotUSSR);
			this.Controls.Add(this.DotUSA);
			this.Controls.Add(this.TIE);
			this.Controls.Add(this.USSR);
			this.Controls.Add(this.USA);
			this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(245)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WOPR";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DotUSA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DotUSSR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label USA;
		private System.Windows.Forms.Label USSR;
		private System.Windows.Forms.Label TIE;
		private System.Windows.Forms.PictureBox DotUSA;
		private System.Windows.Forms.PictureBox DotUSSR;
	}
}

