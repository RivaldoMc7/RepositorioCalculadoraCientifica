using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OPTangente;
using OPSuma;
using OPSigno;
using OPSeno;
using OPResta;
using OPRaizCubica;
using OPRaizCualquiera;
using OPRaiz;
using OPPotenciaCualquiera;
using OPPorcentaje;
using OPNumeroCubo;
using OPNumeroCuadrado;
using OPMultiplicar;
using OPLogaritmo;
using OPExponente;
using OPDividir;
using OPDiezALA;
using OPCoseno;





namespace TareaC
{
    public partial class Form1 : Form
    {
        float dato1 = 0;
        float dato2 = 0;
        float resul = 0;

        double dato3 = 0;
        double dato4 = 0;
        double resul2 = 0;

        float CADENA;


        int indicador_Operador;

        public Form1()
        {
            InitializeComponent();
        }




        private void btnCero_Click(object sender, EventArgs e)
        {
            res.Text += 0;
        }


        private void btnUno_Click(object sender, EventArgs e)
        {
            res.Text += 1;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            res.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            res.Text += 3;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            res.Text += 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            res.Text += 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            res.Text += 6;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            res.Text += 7;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            res.Text += 8;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            res.Text += 9;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {

            indicador_Operador = 1;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para poder operar con el");
                return;
            }
            else
            {
                //YA QUE VEFICAMOS AHORA SI PASOMOS LO QUE ESTA EN res A dato3 PARA QUE GUARDE LE RESULTADO 
                dato1 = float.Parse(res.Text);

                res.Text = "";

                res2.Text = dato1.ToString() + " + ";
            }    
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            indicador_Operador = 2;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para poder operar con el");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1.ToString() + " - ";
            }       
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            indicador_Operador = 3;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para poder operar con el");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1.ToString() + " * ";
            }

               
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            indicador_Operador = 4;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para poder operar con el");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1.ToString() + " / ";
            } 
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            indicador_Operador = 5;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el Porcentaje");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1.ToString() + " % (";
            }

                
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Raiz OPR = new Raiz();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener la Raiz Cuadrada");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                if (dato1 < 0)
                {
                    MessageBox.Show("Para las raices solo podemos utilizar numeros positivos");
                    return;
                }
                else
                {
                    res2.Text = "√" + dato1.ToString();
                    double resultado1 = OPR.oper_Raiz(dato1);

                    res.Text = resultado1.ToString();
                }
                   
            }

                
        }

        private void btnCambiarSigno_Click(object sender, EventArgs e)
        {
            Signo OPSG = new Signo();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para poder cambiar su signo");
                return;
            }
            else
            {
                    dato1 = float.Parse(res.Text);
                    res.Text = "";
                    dato1 = OPSG.oper_Signo(dato1);

                    res.Text = dato1.ToString();
  
            }

                

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Logaritmo OPL = new Logaritmo();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener el Logaritmo");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                resul2 = OPL.oper_Logaritmo(dato1);


                res2.Text = "Log (" + dato1 + ")";

                res.Text = resul2.ToString();
            }

               
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            
            Seno seno = new Seno();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener el Seno");
                return;
            }
            else 
            {
                dato3 = double.Parse(res.Text);
                res.Text = "";

                resul2 = seno.oper_Seno(dato3);

                res2.Text = "Sen (" + dato3 + ")";

                res.Text = Math.Round(resul2, 10).ToString();
            }
        }


        private void btnCoseno_Click(object sender, EventArgs e)
        {
            Coseno coseno = new Coseno();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener el Coseno");
                return;
            }
            else 
            {
                dato3 = double.Parse(res.Text);
                res.Text = "";

                resul2 = coseno.oper_Coseno(dato3);

                res2.Text = "Cos (" + dato3 + ")";

                res.Text = Math.Round(resul2, 10).ToString();
            }
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            Tangente tangente = new Tangente();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener la Tangente");
                return;
            }
            else 
            {
                dato3 = double.Parse(res.Text);
                res.Text = "";

                resul2 = tangente.oper_Tangente(dato3);

                res2.Text = "Tan (" + dato3 + ")";

                res.Text = Math.Round(resul2, 10).ToString();
            }
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            indicador_Operador = 6;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para la notacion cientifica");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1 + " x 10^ ";
            }

                
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            NumeroCuadrado numerocuadrado = new NumeroCuadrado();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para elevar al Cuadrado");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1 + "^2";

                resul = numerocuadrado.oper_Exponente(dato1);

                res.Text = resul.ToString();
            }
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            Numerocubo numerocubo = new Numerocubo();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para elevar al Cubo");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1 + "^3";

                resul = numerocubo.oper_Exponente(dato1);

                res.Text = resul.ToString();
            }  
        }

        private void btnElevadoC_Click(object sender, EventArgs e)
        {
            indicador_Operador = 7;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para elevar al cualquier Potencia");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                res2.Text = dato1 + "^";
            }

                
        }

        private void btnDiezALA_Click(object sender, EventArgs e)
        {
            indicador_Operador = 8;

            res2.Text = "10^";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            double auxiliar = 0;
            double pi = 3.14156;

            if (res.Text != "")
            {
                auxiliar = double.Parse(res.Text);
                res.Text = "";

                dato3 = auxiliar * pi;

                res2.Text = auxiliar + "π";

                res.Text = dato3.ToString();

            }
            else
            {
                res.Text += pi;
            }
        }

        private void btnRaizCubica_Click(object sender, EventArgs e)
        {
            RaizCubica OPRC = new RaizCubica();

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el numero para obtener la Raiz Cubica");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                if (dato1 < 0)
                {
                    MessageBox.Show("Para las raices solo podemos utilizar numeros positivos");
                    return;
                }
                else
                {
                    res2.Text = "3√" + dato1.ToString();

                    double resultado1 = OPRC.oper_RaizCubica(dato1);

                    res.Text = resultado1.ToString();

                }
                    
            }     
        }

        private void button11_Click(object sender, EventArgs e)
        {
            indicador_Operador = 9;

            if (res.Text == "")
            {
                MessageBox.Show("Primero digita el indice de la raiz");
                return;
            }
            else
            {
                dato1 = float.Parse(res.Text);
                res.Text = "";

                if (dato1 < 0)
                {
                    MessageBox.Show("Para las raices solo podemos utilizar numeros positivos");
                    return;
                }
                else
                {
                    res2.Text = dato1 + "√";
                }       
            }

                

            
        }







        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!res.Text.Contains("."))
            {
                res.Text += ".";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //VARIABLES DE TIPO CLASE PARA QUE PODAMOS ACCEDER A LOS METODOS 

            Suma OPS = new Suma();
            resta OPR = new resta();
            multiplicar OPM = new multiplicar();
            dividir OPD = new dividir();
            porcentaje OPP = new porcentaje();
            Exponente OPExponente = new Exponente();
            PotenciaCualquiera OPcualquierexponente = new PotenciaCualquiera();
            DiezALA OPdiezala = new DiezALA();
            RaizCualquiera OPraizcualquiera = new RaizCualquiera();



            //GUARDAR EL dato2 Y PODAMOS OPERAR CON EL 

            if (res.Text == "")
            {
                MessageBox.Show("No hay numero para calcular");
                return;
            }
            else
            { 
            
            

                dato2 = float.Parse(res.Text);


            switch (indicador_Operador)
            {
                case 1:

                    resul = OPS.oper_suma(dato1, dato2);
                    res.Text = resul.ToString();


                    //CONCATENAR EL dato1 con el simbolo
                    res2.Text += dato2;

                    break;
                case 2:

                    resul = OPR.oper_resta(dato1, dato2);
                    res.Text = resul.ToString();

                    res2.Text += dato2;

                    break;
                case 3:
                    resul = OPM.oper_multiplicar(dato1, dato2);
                    res.Text = resul.ToString();

                    res2.Text += dato2;

                    break;

                case 4:

                    if (dato2 == 0)
                    {
                        MessageBox.Show("No puedes dividir entre 0");
                        return;
                    }

                    resul = OPD.oper_dividir(dato1, dato2);
                    res.Text = resul.ToString();

                    res2.Text += dato2;

                    break;

                case 5:

                    resul = OPP.oper_Porcentaje(dato1, dato2);
                    res.Text = resul.ToString();

                    res2.Text += dato2 + ")";
                    break;

                case 6:

                    dato2 = float.Parse(res.Text);
                    res.Text = "";

                    resul = OPExponente.oper_Exponente(dato1, dato2);

                    res2.Text += dato2;

                    res.Text = resul.ToString();

                    break;

                case 7:

                    dato2 = float.Parse(res.Text);
                    res.Text = "";

                    resul = OPcualquierexponente.oper_ExponenteCualquiera(dato1, dato2);

                    res2.Text += dato2;

                    res.Text = resul.ToString();

                    break;
                case 8:
                    dato1 = float.Parse(res.Text);
                    res.Text = "";

                    resul = OPdiezala.oper_Calcular(dato1);

                    res2.Text += dato1;

                    res.Text = resul.ToString();
                    break;
                case 9:
                    dato2 = float.Parse(res.Text);
                    res.Text = "";

                    resul2 = OPraizcualquiera.oper_RaizCualquiera(dato2, dato1);

                    res2.Text += dato2;

                    res.Text = resul2.ToString();

                    break;
            }

            }



        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(res.Text))
            {
                // Get the length of the text
                int CADENA = res.Text.Length;

                // Remove the last character using Substring
                res.Text = res.Text.Substring(0, CADENA - 1);
            }
            else 
            {
                res.Text = "";
                res2.Text = "";
                res2.Text += "0";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            res.Text = "";
            res2.Text = "";
            res2.Text += "0";
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            res.Text = "";
            res2.Text = "";
            res2.Text += "0";

        }

       
    }
}
