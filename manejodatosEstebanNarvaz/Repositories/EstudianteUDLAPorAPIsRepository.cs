using manejodatosEstebanNarvaz.interfaces;
using manejodatosEstebanNarvaz.modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejodatosEstebanNarvaz.Repositories
{
    public class EstudianteUDLAPorAPIsRepository : IEstudianteUDLARepository
    {
        public string _urlEndpoint = "https://www.freetestapi.com/api/v1/students";
        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }

        bool IEstudianteUDLARepository.ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        bool IEstudianteUDLARepository.CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        EstudianteUDLA IEstudianteUDLARepository.DevuelveEstudianteUDLA(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(_urlEndpoint).Result;
                var json_data = response.Content.ReadAsStringAsync().Result;

                List<EstudianteAPI> estudianteAPIs = JsonConvert.DeserializeObject<List<EstudianteAPI>>(json_data);
            }

        }

        IEnumerable<EstudianteUDLA> IEstudianteUDLARepository.DevuelveListadoEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
