using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_EN_C_
{
    internal class ComentarioService
    {
        public interface IComentarioService
        {
            void AgregarComentario(string comentario);
            // Declaración del método para agregar un comentario.

            List<string> ObtenerComentarios();
            // Declaración del método para obtener los comentarios como una lista.
        }

        public class ComentarioServic : IComentarioService
        {
            private List<string> comentarios = new List<string>();
            // Campo privado para almacenar los comentarios como una lista.

            public void AgregarComentario(string comentario)
            {
                // Implementación del método AgregarComentario de la interfaz.
                comentarios.Add(comentario);
                // Agrega el comentario a la lista de comentarios.
            }

            public List<string> ObtenerComentarios()
            {
                // Implementación del método ObtenerComentarios de la interfaz.
                return comentarios;
                // Devuelve la lista de comentarios.
            }
        }

    }
}
