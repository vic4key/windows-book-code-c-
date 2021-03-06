using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RectDraw
{
	/// <summary>
	/// Draws a rectangle and a square
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox pic;
		private DoubleRect rect;
		
		private void init() {
			rect = new DoubleRect (50, 40, 70, 100);
			float x = 12.341514325f;
			string s =x.ToString ("###.###");
			float y = Convert.ToSingle (s);
			string m = y.ToString ("f");
			int k = 12;
		}
		public Form1()
		{
		InitializeComponent();
		init();
		}
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pic.Location = new System.Drawing.Point(16, 32);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(264, 216);
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pic});
			this.Name = "Form1";
			this.Text = "Rectangle drawing";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void pic_Paint(object sender, PaintEventArgs e) {
			Graphics g =  e.Graphics;
			rect.draw (g);
		}
	}
}
