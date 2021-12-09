using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_de_Lab3
{
    static class Program
    {
        // Cada um dos módulos (instâncias das classes) será representado pela respetiva propriedade
        //com get público e set privado
        
            //public static ModelNotas M_Notas { get; private set; }
        public static ViewPrincipal V_Principal { get; private set; }
        public static FormJogarDificuldadeFacil _FormJogarDificuldadeFacil { get; private set; }
        public static FormJogarDificuldadeMedia _FormJogarDificuldadeMedia { get; private set; }

        //public static ControllerNotas C_Notas { get; private set; }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Os objetos devem ser instanciados nesta zona do método Main e pela ordem M V C,
            //ou seja,instanciar primeiro todos os Models seguido de todas as Views e finalmente todos os Controllers

            // MODELS
            

            // VIEWS
            V_Principal = new ViewPrincipal();
        

            // CONTROLLERS 


            Application.Run(V_Principal);
        }
    }
}
