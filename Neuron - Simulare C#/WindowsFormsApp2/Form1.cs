using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Functia.Items.Add(new ComboBoxItem("Sigmoidala", 2));
            Functia.Items.Add(new ComboBoxItem("TangentaHiperbolica", 3));
            Functia.Items.Add(new ComboBoxItem("Treapta", 4));
            Functia.Items.Add(new ComboBoxItem("Semn", 5));
            Functia.Items.Add(new ComboBoxItem("Rampa", 6));
            GsiA_Value.ValueChanged += new EventHandler(ValueChange);
            prag_Value.ValueChanged += new EventHandler(ValueChange);
            Binar.CheckedChanged += new EventHandler(ValueChange);
            Functia.SelectedValueChanged += new EventHandler(ValueChange);
            Suma_R.CheckedChanged += new EventHandler(ValueChange);
            Min_R.CheckedChanged += new EventHandler(ValueChange);
            Max_R.CheckedChanged += new EventHandler(ValueChange);
            Produs_R.CheckedChanged += new EventHandler(ValueChange);

            First();
        }


        int Aux_conexiuni = 0;

        private void NumarConexiuni_ValueChanged(object sender, EventArgs e)
        {
            Calculare();
            int conexiuni = (int)NumarConexiuni.Value;
            int count = panel.Controls.Count;

            bool var;

            if (Aux_conexiuni > conexiuni)
            {
                var = false;
            }
            else
            {
                var = true;
                Aux_conexiuni = conexiuni;
            }

            if (var == true)
            {
                int n = count / 4;


                for (int i = n; i < conexiuni; i++)
                {

                    Label x = new Label();
                    Label w = new Label();
                    NumericUpDown xV = new NumericUpDown();
                    NumericUpDown wV = new NumericUpDown();
                    xV.Minimum = -100;
                    wV.Minimum = -100;
                    xV.Maximum = 1000;
                    wV.Maximum = 1000;
                    xV.Increment = (decimal)0.01;
                    wV.Increment = (decimal)0.01;
                    xV.Width = 50;
                    wV.Width = 50;
                    wV.DecimalPlaces = 2;
                    xV.DecimalPlaces = 2;
                    wV.ValueChanged  += new EventHandler(ValueChange);
                    xV.ValueChanged  += new EventHandler(ValueChange);
                    x.Text = "X:";
                    w.Text = "W:";

                    count = panel.Controls.Count;

                    x.Location = new Point(10, count * 10);
                    w.Location = new Point(90, count * 10);
                    xV.Location = new Point(30, count * 10);
                    wV.Location = new Point(110, count * 10);
                    panel.Controls.Add(wV);
                    panel.Controls.Add(w);
                    panel.Controls.Add(xV);
                    panel.Controls.Add(x);

                }
            }

            else
            {
                for (int i = Aux_conexiuni; i > conexiuni; i--)
                {
                    int auxcount = panel.Controls.Count;
                    panel.Controls.Remove(panel.Controls[auxcount - 1]);
                    panel.Controls.Remove(panel.Controls[auxcount - 2]);
                    panel.Controls.Remove(panel.Controls[auxcount - 3]);
                    panel.Controls.Remove(panel.Controls[auxcount - 4]);
                }

                Aux_conexiuni = conexiuni;
            }
        
        }

        // ----------------------------------------------------------------------

        double x;
        double w;



        public List<double> getValori()
        {
            List<double> lista = new List<double>();
            var numericUpDowns = panel.Controls.OfType<NumericUpDown>();
            bool var = false;
            foreach (NumericUpDown nr in numericUpDowns)
            {
                if (var == false)
                {
                    x = (double)nr.Value;
                    var = true;
                }
                else
                {
                    w = (double)nr.Value;
                    var = false;
                    lista.Add(w * x);
                }

            }

            return lista;
        }

        double gi;
        private void Calculare()
        {
            List<double> valori = new List<double>();
            valori = getValori();
         

            if (Suma_R.Checked == true)
            {
                gi = Suma(valori);
            }
            else if (Produs_R.Checked)
            {
                gi = Produs(valori);
            }
            else if (Min_R.Checked)
            {
                gi = Minim(valori);
            }
            else if (Max_R.Checked)
            {
                gi = Maxim(valori);
            }
          

            GID.Text = gi.ToString();


            //    ------------------------------------

     
            if (Functia.Text == "Sigmoidala")
            {
                Change();
                Rezultat.Text = Functia_Sigmoidala(gi).ToString();         
            }
            else if (Functia.Text == "TangentaHiperbolica")
            {
                Change();
                Rezultat.Text = Functia_TangentaHiperbolica(gi).ToString();   
            }
            else if(Functia.Text == "Treapta"){
                Change();
                Rezultat.Text = Functia_Treapta(gi).ToString();   
            }
            else if(Functia.Text == "Semn")
            {
                Change();
                Rezultat.Text = Functia_Semn(gi).ToString();       
            }
            else if (Functia.Text == "Rampa")
            {
                Rezultat.Text = Functia_Rampa(gi).ToString();
                prag_Value.Visible = false;
                prag_label.Visible = false;
                GsiA_Label.Text = "a";
                GsiA_Value.Value = 1;
            }
         


            if (Binar.Checked == true)
            {
                if (Functia.Text == "Sigmoidala")
                {
                    if (Double.Parse(Rezultat.Text) >= 0.5)
                    {
                        RezultatFinal.Text = "1";
                        Activare.Text = "Activ";                   
                    }
                    else
                    {
                        RezultatFinal.Text = "0";
                        Activare.Text = "Inactiv";
                    }
                }

                else if (Functia.Text == "TangentaHiperbolica" || Functia.Text == "Rampa")
                {
                    if (Double.Parse(Rezultat.Text) >= 0)
                    {
                        RezultatFinal.Text = "1";
                        Activare.Text = "Activ";
                    }
                    else
                    {
                        RezultatFinal.Text = "-1";
                        Activare.Text = "Inactiv";
                    }
                }
              
                else if(Functia.Text == "Treapta")
                {
                    RezultatFinal.Text = Rezultat.Text;
                }
               
            }
            else
            {
                RezultatFinal.Text = Rezultat.Text;
                if (Functia.Text == "Treapta" || Functia.Text == "Sigmoidala") // 0   1
                {
                    if (Double.Parse(Rezultat.Text) >= 0.5)
                    {
                        Activare.Text = "Activ";


                    }
                    else
                    {
                        Activare.Text = "Inactiv";
                    }
                }
                else if (Functia.Text == "TangentaHiperbolica" || Functia.Text == "Rampa" || Functia.Text == "Semn") // -1  1
                {
                    if (Double.Parse(Rezultat.Text) >= 0)
                    {

                        Activare.Text = "Activ";
                    }
                    else
                    {

                        Activare.Text = "Inactiv";
                    }
                }
               
            }
        }

        private void ValueChange(object sender, EventArgs e)
        {
            Calculare();
        }

        private void Change()
        {
            prag_Value.Visible = true;
            prag_label.Visible = true;
            GsiA_Label.Text = "g";
        }
    


        private double Suma(List<double> lista)
        {
            double S = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                S += lista[i];
            }
            return S;
        }

        private double Produs(List<double> lista)
        {
            double P = 1;
            for (int i = 0; i < lista.Count; i++)
            {
                P *= lista[i];
            }
            return P;
        }

        private double Minim(List<double> lista)
        {
            double min = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (min > lista[i])
                {
                    min = lista[i];
                }
            }
            return min;
        }

        private double Maxim(List<double> lista)
        {
            double max = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (max < lista[i])
                {
                    max = lista[i];
                }
            }
            return max;
        }


 
        private double Functia_Sigmoidala(double gid)  // 0-1
        {
            double prag = (double)prag_Value.Value;
            double g = (double)GsiA_Value.Value;

            double aux = -g * (gid - prag);
            return (double)(1 / (1 + Math.Pow(Math.E, aux)));
        }

        private double Functia_TangentaHiperbolica(double gid) // -1  +1
        {
            double prag = (double)prag_Value.Value;
            double g = (double)GsiA_Value.Value;

            double auxP = g * (gid - prag);
            double auxN = -g * (gid - prag);

            return (Math.Pow(Math.E, auxP) - Math.Pow(Math.E, auxN)) /
                   (Math.Pow(Math.E, auxP) + Math.Pow(Math.E, auxP));
        }

        private double Functia_Treapta(double gid)  // 1 - 0;
        {
            double prag = (double)prag_Value.Value;

            if (gid >= prag)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        private double Functia_Semn(double gid)  // 1  -1
        {
            double prag = (double)prag_Value.Value;

            if (gid >= prag)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }


        private double Functia_Rampa(double gid)
        {
            double a = (double)GsiA_Value.Value;

            if (gid >= a)
            {
                return 1;
            }
            else if(gid < a * -1)
            {
                return -1;
            }
            else if( gid > -1 * a && gid < a)
            {
                return gid / a;
            }
            return 0;
        }


        private void First()
        {
            Label x = new Label();
            Label w = new Label();
            NumericUpDown xV = new NumericUpDown();
            NumericUpDown wV = new NumericUpDown();
            xV.Minimum = -100;
            wV.Minimum = -100;
            xV.Maximum = 1000;
            wV.Maximum = 1000;
            xV.Increment = (decimal)0.01;
            wV.Increment = (decimal)0.01;
            xV.Width = 50;
            wV.Width = 50;
            wV.DecimalPlaces = 2;
            xV.DecimalPlaces = 2;
            wV.ValueChanged += new EventHandler(ValueChange);
            xV.ValueChanged += new EventHandler(ValueChange);
            x.Text = "X:";
            w.Text = "W:";

            int count = panel.Controls.Count;

            x.Location = new Point(10, count * 10);
            w.Location = new Point(90, count * 10);
            xV.Location = new Point(30, count * 10);
            wV.Location = new Point(110, count * 10);
            panel.Controls.Add(wV);
            panel.Controls.Add(w);
            panel.Controls.Add(xV);
            panel.Controls.Add(x);
        }

        
    }
}
