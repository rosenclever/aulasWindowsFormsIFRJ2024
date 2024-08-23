using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulasWindowsForms
{
    public partial class FrmRestoDivisao : Form
    {
        public FrmRestoDivisao()
        {
            InitializeComponent();
        }

        private void BtnRestoDaDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = Convert.ToInt32(TxtDividendo.Text);
                int divisor = Convert.ToInt32(TxtDivisor.Text);
                int resto = dividendo % divisor;
                TxtResto.Text = resto.ToString();
            }
            catch(FormatException exc)
            { 
                MessageBox.Show("Entrada de dados inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch(DivideByZeroException exc )
            {
                MessageBox.Show("Não é possível realizar divisão por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
