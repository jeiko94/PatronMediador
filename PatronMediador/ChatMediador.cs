//Esta clase coordina la comunicación entre los usuarios.

namespace PatronMediador
{
    public class ChatMediador : IMediador
    {
        private List<Usuario> _usuarios = new List<Usuario>();

        public void RegistrarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void EnviarMensaje(string mensaje, Usuario remitente)
        {
            foreach(var usuario in _usuarios)
            {
                if (usuario != remitente)
                {
                    usuario.RecibirMensaje(mensaje, remitente);
                }
            }
        }
    }
}
