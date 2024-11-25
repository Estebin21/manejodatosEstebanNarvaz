using manejodatosEstebanNarvaz.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejodatosEstebanNarvaz.interfaces
{
    internal interface IEstudianteUDLARepository
    {
        IEnumerable<EstudianteUDLA> DevuelveListadoEstudiante();
        EstudianteUDLA DevuelveEstudianteUDLA(int id);
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int id);
    }
}
