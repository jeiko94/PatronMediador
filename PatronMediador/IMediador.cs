//Esta interfaz declara los métodos para registrar usuarios y enviar mensajes.

namespace PatronMediador
{
    public interface IMediador
    {
        void RegistrarUsuario(Usuario usuario);
        void EnviarMensaje(string mensaje, Usuario remitente);
    }
}
