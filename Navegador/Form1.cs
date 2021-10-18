using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Navegador
{
    public partial class FomNavegador : Form
    {
        string alterno;
         
        public FomNavegador()
        {
            InitializeComponent();
        }

        private void FomNavegador_Load(object sender, EventArgs e)
        {           
            webBrowser1.Navigate("www.google.com.do");
            TxtIr.Text = "www.google.com.do";                  
        }

        private void TxtIr_Click_1(object sender, EventArgs e)
        {
            alterno = TxtIr.Text;
            TxtIr.Text = "";
        }

        private void TxtIr_Leave_1(object sender, EventArgs e)
        {
            if (TxtIr.Text == "")
            {
                TxtIr.Text = alterno;
            }
        }

        #region Controles
        private void BtnAtras_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void BtnAdelante_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void BtnInicio_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
        }
        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(TxtIr.Text);
        }
        #endregion

        private void webBrowser1_NewWindow(string v)
        {
            throw new NotImplementedException("www.google.com.do");
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {

        }

       
    }
}
