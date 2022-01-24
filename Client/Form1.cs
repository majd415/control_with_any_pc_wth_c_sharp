using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets ;//مكتبه التعامل مع الشبكه
using System.IO;//مكتبه التعامل مع اجهزه الدخل و الخرج 
namespace Client
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_host;
		private System.Windows.Forms.Label label1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Timer Capturing;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(40, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Cmd";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_host
            // 
            this.txt_host.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_host.Location = new System.Drawing.Point(306, 12);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(200, 22);
            this.txt_host.TabIndex = 2;
            this.txt_host.Text = "localhost";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer IP";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(238, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "calc";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(437, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "computer info";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(40, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "Computer Manger";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Capturing
            // 
            this.Capturing.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.Location = new System.Drawing.Point(238, 110);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(176, 45);
            this.button8.TabIndex = 10;
            this.button8.Text = "Error Event";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button9.Location = new System.Drawing.Point(437, 110);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(176, 45);
            this.button9.TabIndex = 11;
            this.button9.Text = "Open Fire Fox";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button10.Location = new System.Drawing.Point(40, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(176, 45);
            this.button10.TabIndex = 12;
            this.button10.Text = "Open Our Youtube";
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button11.Location = new System.Drawing.Point(238, 169);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(176, 45);
            this.button11.TabIndex = 13;
            this.button11.Text = "Open startup Prog";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button12.Location = new System.Drawing.Point(437, 169);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(176, 45);
            this.button12.TabIndex = 14;
            this.button12.Text = "Open Our Website";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button13.Location = new System.Drawing.Point(437, 293);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(176, 45);
            this.button13.TabIndex = 17;
            this.button13.Text = "LogOff";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button14.Location = new System.Drawing.Point(238, 293);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(176, 45);
            this.button14.TabIndex = 16;
            this.button14.Text = "Restart";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button15.Location = new System.Drawing.Point(40, 290);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(176, 45);
            this.button15.TabIndex = 15;
            this.button15.Text = "Shutdown";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(700, 374);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Remote Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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



        void Basim(string b)//داله تقوم بارسال القيم فقط ولا تعيد اي قيمه
        {
            try
            {
                TcpClient myclient = new TcpClient(txt_host.Text,5020);//نقوم بتعريف تي سي بي كلاينت ثم نقوم باخذ العنوان اي بيمن مربع النص و نعرف ايضا البورت الموجود 
                NetworkStream myns = myclient.GetStream();//نقوم بفتح جلسه اتصال بالشبكه
                StreamWriter mysw = new StreamWriter(myns);//ثم نقوم بارسال الاوامر 
                System.Threading.Thread.Sleep(50);//نقوم باتاخه بعض التاخير بين ارسال كل امر واخر
                mysw.WriteLine(b);//نقوم بارسال الامر الموجود
                mysw.Close();
                myns.Close();
                myclient.Close();

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

		private void button1_Click(object sender, System.EventArgs e)
		{

            Basim("Ping");
		}

        private void button2_Click(object sender, EventArgs e)
        {
            
            Basim("calc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basim("dxdiag");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basim("compmgmt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basim("notepad");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Basim("verifier");
        }


        TcpClient myclient;
        MemoryStream ms;
        NetworkStream myns;
        BinaryWriter mysw;

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basim("control desktop");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basim("eventvwr");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Basim("control mouse");
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Basim("Youtube");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Basim("satratup");
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Basim("OurWebSite");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Basim("Shutdown");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Basim("Restart");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Basim("LogOff");
            
        }
	}
}
