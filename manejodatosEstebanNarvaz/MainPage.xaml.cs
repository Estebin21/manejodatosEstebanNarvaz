using manejodatosEstebanNarvaz.interfaces;
using manejodatosEstebanNarvaz.modelos;
using manejodatosEstebanNarvaz.Repositories;

namespace manejodatosEstebanNarvaz
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            _estudianteUDLARepository = new EstudianteUDLAArchivos();
            InitializeComponent();

            estudiante = _estudianteUDLARepository.DevuelveEstudianteUDLA(1);
            BindingContext = estudiante;
        }
        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = 1,
                Nombre = "Estebin",
                Carrera = "Ingeniería software"
            };
            bool guardar_Estudiante = _estudianteUDLARepository.CrearEstudianteUDLA(estudiante);
            if (guardar_Estudiante)
            {
                await DisplayAlert("Alerta", "Todo posi", "OK");
            }
            else
            {
                await DisplayAlert("Alerta", "No valio xd", "Ok");
            }
        }

    }

}
