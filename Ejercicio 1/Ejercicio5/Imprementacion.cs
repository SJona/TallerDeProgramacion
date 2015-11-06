using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Implementacion : IRepositorioUsuario
    {
        Usuario iUsuario;
        IDictionary<string, Usuario> usuarios;

        public Implementacion(Usuario pUsuario) {
            usuarios.Add(pUsuario.Codigo,pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            if (usuarios.ContainsKey(pUsuario.Codigo)) {

            }
        }

        public void Agregar(Usuario pUsuario)
        {
            
        }

        public void Eliminar(string pCodigo)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparation)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
