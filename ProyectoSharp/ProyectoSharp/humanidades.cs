/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 30/10/2024
 * Time: 07:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSharp
{
	/// <summary>
	/// Description of humanidades.
	/// </summary>
	public partial class humanidades : Form
	{
		public humanidades()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		
		
		void OrdensocialClick(object sender, EventArgs e)
		{
			texto.Text="Una vez que hemos reflexionado sobre el origen de las leyes analizaremos qué pasa con éstas o cómo se instauran para que las personas puedan vivir de forma segura y con cierto orden social";

		}
		
		void RelacionesdepoderClick(object sender, EventArgs e)
		{
			texto.Text="Como vimos en el libro de Humanidades 1 para él el poder no es simplemente una entidad que algunos individuos o instituciones poseen no es una propiedad concentrada en las autoridades o en el Estado sino un entramado de personas e instituciones que lo ejercen a través de diversos mecanismos y que atraviesan todas las dimensiones de la vida Piensa que en las carceles escuelas y en tu propio hogar hay personas que representan la figura de autoridad los carceleros el director del plantel y los padres respectivamente pero las demás personas que ocupan estos espacios igualmente ejercen relaciones de poder entre ellas las hay entre los reclusos en las prisiones los docentes o estudiantes en las escuelas y los hijos en una familia Por ejemplo en la escuela pueden existir grupos de alumnos que controlen las acciones de los demás";	
		}
		
		void QueeselbienClick(object sender, EventArgs e)
		{
			texto.Text="¿Por qué decimos que alguien es bueno o malo? ¿Qué es el bien? El concepto de bien ha sido un tema central en la filosofía a lo largo de la historia. Desde la antigua Grecia hasta la filosofía contemporánea, ha habido diversas preguntas al respecto: ¿cómo evaluar la conducta?, ¿el bien es algo propio del ser humano o es algo externo?, ¿es algo absoluto y universal o relativo a cada ser humano o cultura?, ¿cómo podemos conocerlo?, entre otras";
		}
	}
}
