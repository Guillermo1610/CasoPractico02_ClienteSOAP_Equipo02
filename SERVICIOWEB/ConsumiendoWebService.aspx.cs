using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SERVICIOWEB.Clase_Conversion;



namespace SERVICIOWEB
{
    public partial class ConsumiendoWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLetras_Click(object sender, EventArgs e)
        {
            Convertir convertir = new Convertir();
            txtResultado.Text = convertir.NumeroLetras(ulong.Parse(txtNumero.Text));
        }


      
        protected void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnDolar_Click(object sender, EventArgs  e)
        {
            Convertir convertir = new Convertir();
            txtResultado2.Text = convertir.NumeroDollar(decimal.Parse(TxtNumero2.Text));
        }
    }
}