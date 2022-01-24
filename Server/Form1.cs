using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets ;
using System.IO;
using System.Threading;
using System.Text;


using System.Diagnostics;
using System.Runtime.InteropServices;






namespace Server







{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private IContainer components;

        [DllImport("user32")]
        public static extern void LockWorkStation();
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iam Waiting Your Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(314, 88);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Remote Receive";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        ///
		private void Form1_Load(object sender, System.EventArgs e)
		{
			Thread myth;//نقوم بداله الفورم باستدعاء ثريد جديد
			myth= new Thread  (new System.Threading .ThreadStart(StartMethod)); // Start Thread Session
			myth.Start ();

        }
        string localvairable;


       

		void StartMethod ()
		{

           // texthost.Text="192.168.1.3";
            TcpListener mytcpl = new TcpListener(5020);//للاستماع الى اي طلب موجود على الشبكه من البور الموجود 

            //mytcpl = new TcpListener(texthost.Text, 5020);		 // Open The Port
			mytcpl.Start ();						 // Start Listening on That Port
			mysocket = mytcpl.AcceptSocket ();		 // Accept Any Request From Client and Start a Session
			myns = new NetworkStream (mysocket);	 // Receives The Binary Data From Port
			mysr = new StreamReader (myns);			 // Convert Received Data to String
			string order = mysr.ReadLine();

            if (order == "calc")
            {
                System.Diagnostics.Process.Start("calc.exe");               // Open Calc
                // mytcpl.Invoke(label1.Text = "calc Is Done");
                localvairable = "calc";
                cross_Thred(localvairable);
            }

            if (order == "compmgmt")
            {
                System.Diagnostics.Process.Start("compmgmt.msc");           // Open Computer Manger

                localvairable = "compmgmt";
                cross_Thred(localvairable);
            }
            if (order == "dxdiag")
            {
                System.Diagnostics.Process.Start("dxdiag");                    // Open Computer Specefication

                localvairable = "dxdiag";
                cross_Thred(localvairable);
            }
            if (order == "control desktop")
            {
                System.Diagnostics.Process.Start("control desktop");        // Open Computer Desktop

                localvairable = "control desktop";
                cross_Thred(localvairable);
            }
            if (order == "eventvwr")
            {
                System.Diagnostics.Process.Start("eventvwr.msc");
                localvairable = "eventvwr";
                cross_Thred(localvairable);
            }
            if (order == "control mouse")
            {
                System.Diagnostics.Process.Start("firefox");
                localvairable = "control mouse";

               


                cross_Thred(localvairable);
            }
            if (order == "Ping")
            {
                System.Diagnostics.Process.Start("cmd");
                localvairable = "Ping";
                cross_Thred(localvairable);
            }

            if (order == "Youtube")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=F8rpWO-4pAc&list=PLs8Xwm__VBVmxBeo4HCoiqRq8lvY9K5an");
                localvairable = "Youtube";
                cross_Thred(localvairable);
            }

            if (order == "satratup")
            {
                System.Diagnostics.Process.Start("msconfig");

                localvairable = "satratup";
                cross_Thred(localvairable);
            }
      

                   if (order == "OurWebSite")
            {
                System.Diagnostics.Process.Start("https://alsradihhr.wixsite.com/excellencetwins/brnamj-alaqarat");

                localvairable = "OurWebSite";
                cross_Thred(localvairable);
            }

                   if (order == "Shutdown")
            {
                Process.Start("shutdown", "/s /t 0");

                localvairable = "Shutdown";
                cross_Thred(localvairable);
            }

                   if (order == "Restart")
                   {
                       Process.Start("shutdown", "/r /t 0");

                       localvairable = "Restart";
                       cross_Thred(localvairable);
                   }
                   if (order == "LogOff")
                   {
                       ExitWindowsEx(0, 0);

                       localvairable = "LogOff";
                       cross_Thred(localvairable);
                   }

                       

            else

                mytcpl.Stop();		 // Close TCP Session


            mytcpl.Stop();	
			if (mysocket.Connected ==true)		     // Looping While Connected to Receive Another Message 
			{
				while (true)
				{
					StartMethod ();					 // Back to First Method
				}
			}
		}
		TcpListener mytcpl;						 // Objects  Declaration 
		Socket mysocket;
		NetworkStream myns;
        private System.Windows.Forms.Label label1;
		StreamReader mysr;



        // ÏÇáÉ ÈÇÓã ÊÌÑíÈ áÇä Çáæáì ãÇÔÊÛáÊ Úáì ÇáÔÈßÉ

        void Read_From_Anther_PC(String server, String order)
		{

           // texthost.Text="192.168.1.3";

            try
            {
                Int32 port = 5020;
                TcpClient client = new TcpClient(server, port);

                byte[] bytes = new byte[client.ReceiveBufferSize];

                NetworkStream stream = client.GetStream();

                if (stream.CanWrite)
                {
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(order);
                    stream.Write(sendBytes, 0, sendBytes.Length);
                }
                else
                {
                    client.Close();
                    stream.Close();
                    return;
                }
                System.Threading.Thread.Sleep(50);
                stream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                string returndata = Encoding.UTF8.GetString(bytes);
                int Length = returndata.Length;

                if (order == "calc")
                {
                    System.Diagnostics.Process.Start("calc.exe");               // Open Calc
                    // mytcpl.Invoke(label1.Text = "calc Is Done");
                    localvairable = "calc";
                    cross_Thred(localvairable);
                }

                if (order == "compmgmt")
                {
                    System.Diagnostics.Process.Start("compmgmt.msc");           // Open Computer Manger

                    localvairable = "compmgmt";
                    cross_Thred(localvairable);
                }
                if (order == "dxdiag")
                {
                    System.Diagnostics.Process.Start("dxdiag");                    // Open Computer Specefication

                    localvairable = "dxdiag";
                    cross_Thred(localvairable);
                }
                if (order == "control desktop")
                {
                    System.Diagnostics.Process.Start("control desktop");        // Open Computer Desktop

                    localvairable = "control desktop";
                    cross_Thred(localvairable);
                }
                if (order == "eventvwr")
                {
                    System.Diagnostics.Process.Start("eventvwr.msc");
                    localvairable = "eventvwr";
                    cross_Thred(localvairable);
                }
                if (order == "control mouse")
                {


                    //
                    // System.Diagnostics.Process.Start("control mouse");
                    System.Diagnostics.Process.Start("firefox");



                    //
                    localvairable = "control mouse";




                    cross_Thred(localvairable);
                }
                if (order == "Ping")
                {
                    System.Diagnostics.Process.Start("cmd");
                    localvairable = "Ping";
                    cross_Thred(localvairable);
                }

                if (order == "Youtube")
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=F8rpWO-4pAc&list=PLs8Xwm__VBVmxBeo4HCoiqRq8lvY9K5an");
                    localvairable = "Youtube";
                    cross_Thred(localvairable);
                }

                if (order == "Facebook")
                {
                    System.Diagnostics.Process.Start("https://www.facebook.com/%D8%AB%D9%86%D8%A7%D8%A6%D9%8A-%D8%A7%D9%84%D8%AA%D9%85%D9%8A%D8%B2-%D9%84%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D9%8A%D8%A7%D8%AA-423386594531148/?ref=aymt_homepage_panel");

                    localvairable = "Facebook";
                    cross_Thred(localvairable);
                }


                if (order == "OurWebSite")
                {
                    System.Diagnostics.Process.Start("https://alsradihhr.wixsite.com/excellencetwins/brnamj-alaqarat");

                    localvairable = "OurWebSite";
                    cross_Thred(localvairable);
                }
                else

                    mytcpl.Stop();		 // Close TCP Session


                mytcpl.Stop();
                if (mysocket.Connected == true)		     // Looping While Connected to Receive Another Message 
                {
                    while (true)
                    {
                        StartMethod();					 // Back to First Method
                    }
                }














                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }



            ////mytcpl = new TcpListener(texthost.Text, 5020);		 // Open The Port
            //mytcpl.Start ();						 // Start Listening on That Port
            //mysocket = mytcpl.AcceptSocket ();		 // Accept Any Request From Client and Start a Session
            //myns = new NetworkStream (mysocket);	 // Receives The Binary Data From Port
            //mysr = new StreamReader (myns);			 // Convert Received Data to String
            ////string order = mysr.ReadLine();

		}


        void cross_Thred( string Receiving )
        {
            if (InvokeRequired)
            {

                this.Invoke(new MethodInvoker(delegate
                {

                    label1.Text = Receiving +" "+"Is Done";

                }));

            }

            else
            {

                label1.Text = Receiving +" Is Not Done";

            }

        }




		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				mytcpl.Stop ();
				Application.ExitThread ();
				Application.Exit();
			}
			catch (Exception ex) 
            {
                //MessageBox .Show (ex.Message );
            }
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      
	}
}
