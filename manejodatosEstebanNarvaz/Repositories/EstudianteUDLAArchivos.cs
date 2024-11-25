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
    internal class EstudianteUDLAArchivos : IEstudianteUDLARepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            { 
                throw;
            }

        }

        public EstudianteUDLA DevuelveEstudianteUDLA(int id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
                
            }
            return estudiante;
        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiante()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
