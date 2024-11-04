/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 30/10/2024
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSharp
{
	/// <summary>
	/// Description of Mates.
	/// </summary>
	public partial class Mates : Form
	{
		string[] valores;
		double pro = 0, dm = 0;
		int high = int.MinValue, low = int.MaxValue, moda, rep = 0, maxrep = int.MinValue, minimoAprobacion;
        /*
        double n, pro=0;
        cin >> n;
        vector<ll> a(n);
        for(auto &i:a){
            cin >> i;
            pro += i;
        }
        double dm = 0; 
        pro /= n;
        for(int i=0;i<n;++i){
            dm += abs(a[i] - pro);
        }
        dm /= n;
        cout << pro << '\n';
         */
		public Mates()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			string texto = cals.Text;
            valores = texto.Split(' ');
		}
		void Button1Click(object sender, EventArgs e)
		{
			int[] numeros = Array.ConvertAll(valores, int.Parse);
            for(int i=0;i<numeros.Length;i++){
                pro += numeros[i];
            }
			int n = numeros.Length;
            pro /= n;
            MessageBox.Show(pro.ToString(), "Promedio");
            for(int i=0;i<n;i++){
            	high = Math.Max(high,numeros[i]);
            	low = Math.Min(low,numeros[i]);
            	double ans = numeros[i] - pro;
                if(ans < 0){
                    ans *= -1;
                }
                dm += ans;
            }
            Array.Sort(numeros);
            for(int i=0;i<n;i++){
            	if(i>0){
	            	if(numeros[i]!=numeros[i-1]){
	            		if(rep>maxrep){
	            			maxrep = rep;
	            			moda = numeros[i];
	            		}
	            		rep = 1;
	            	}
            	}
            	rep++;
            }
            double med;
            if(n%2==0){
            	med = ((double)numeros[n/2] + (double)numeros[(n/2)-1])/2;
            	MessageBox.Show(med.ToString(), "Mediana");
            }
            else{
            	med = numeros[n/2];
                MessageBox.Show(med.ToString(), "Mediana");
            }
            dm /= n;
            minimoAprobacion = 6;
	        var calificacionesAprobadas = numeros.Where(c => c >= minimoAprobacion);
	        double promedioAprobados = calificacionesAprobadas.Any() ? calificacionesAprobadas.Average() : 0;
	        int contadorAprobados = 0;
	        int contadorReprobados = 0;
	        foreach (double c in numeros)
	        {
	            if (c >= minimoAprobacion)
	            {
	                contadorAprobados++;
	            }
	            else
	            {
	                contadorReprobados++;
	            }
	        }
           
            MessageBox.Show(moda.ToString(), "Moda");
            MessageBox.Show(high.ToString(), "Máximo");
            MessageBox.Show(low.ToString(), "Mínimo");
            MessageBox.Show(contadorAprobados.ToString(),"Aprobados");
            MessageBox.Show(contadorReprobados.ToString(),"Reprobados");
            MessageBox.Show(dm.ToString(), "Desviacion Media");
            MessageBox.Show(promedioAprobados.ToString(),"El promedio de calificaciones aprobadas es: ");
		}
	}
}
