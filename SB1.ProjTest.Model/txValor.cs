using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    public class txValor : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {

            base.OnGotFocus(e);
            this.SelectAll();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.Text == "")
                return;
            {
                try
                {
                    double valor = Convert.ToDouble(this.Text.Replace("R$ ", " "));
                    this.Text = String.Format("{0:c}", valor);
                }
                catch
                {
                    this.Text = "";
                    MessageBox.Show("Valor Inválido");
                }
            }
        }
    }
}
