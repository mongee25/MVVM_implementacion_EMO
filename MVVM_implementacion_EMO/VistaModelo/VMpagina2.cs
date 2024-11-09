using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_EMO.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        private string _Texto;
        public List<MiUsuario> ListaUsuario { get; set; }

        #region CONSTRUCTOR
        public VMpagina2()
        {

            MostrarUsuarios();
        }

        public class MiUsuario
        {
            public string Nombre { get; set; }
            public string Imagen { get; set; }
        }
        #endregion

        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }

        #region COMANDOS 


        public void MostrarUsuarios()
        {
            ListaUsuario = new List<MiUsuario> 
            {

                new MiUsuario
                {
                    Nombre = "Emiliano",
                    Imagen = "https://ibb.co/gZ0Y0cw"
                },

                new MiUsuario
                {
                    Nombre = "Alexa",
                    Imagen = "https://ibb.co/GTVZ95K"
                },

                new MiUsuario
                {
                    Nombre = "José Luis",
                    Imagen = "https://ibb.co/GF3RkTN"
                }
            };
        }

        public async Task si()
        {
        }
        public ICommand Volvercommand => new Command(async () => await si());
        #endregion

    }
}

