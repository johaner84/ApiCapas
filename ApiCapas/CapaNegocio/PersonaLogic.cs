using CapaDatos;
using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class PersonaLogic : IPersona
    {
        private TestContext Context;
        public PersonaLogic(TestContext context)
        {
            Context = context;
        }

        public List<Persona> GetPersona()
        {
            return Context.Personas.ToList();
        }
    }
}