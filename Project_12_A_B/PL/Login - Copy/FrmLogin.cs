using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using BranchA.PL.Login;

namespace Project_Sce.PL
{
    public partial class LogIn : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetPanelModuleLogin();
        }

        public void SetPanelModuleLogin()
        {
            ModuleLogin moduleLogin = new ModuleLogin();
            if (!this.panel1.Controls.Contains(ModuleLogin.Instance))
            {
                //this.panel1.Controls.Add(ModuleLogin.Instance);
                //ModuleLogin.Instance.Dock = DockStyle.Fill;
                // or this:
                //
                this.panel1.Controls.Add(moduleLogin);
                moduleLogin.Dock = DockStyle.Fill;
            }
            //ModuleLogin.Instance.BringToFront();
            moduleLogin.BringToFront();
        }

        public void SetPanelModuleForgot()
        {
            ModuleForgot moduleForgot = new ModuleForgot();
            if (!this.panel1.Controls.Contains(ModuleForgot.Instance))
            {
                //this.panel1.Controls.Add(ModuleForgot.Instance);
                //ModuleForgot.Instance.Dock = DockStyle.Fill;
                // or this:
                //
                this.panel1.Controls.Add(moduleForgot);
                moduleForgot.Dock = DockStyle.Fill;
            }
            //ModuleLogin.Instance.BringToFront();
            moduleForgot.BringToFront();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
