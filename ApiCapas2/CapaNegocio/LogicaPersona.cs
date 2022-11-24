using CapaDatos;
using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class LogicaPersona : ILogicaPersona
    {
        TESTContext Context;
        public LogicaPersona(TESTContext context)
        {
            Context = context;
        }  

        public List<Persona> GetPersona()
        { 
            return Context.Personas.ToList();
        }
    }
}