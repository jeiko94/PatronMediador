//Esta clase representa a los usuarios que interactúan con el mediador.

namespace PatronMediador
{
    public class Usuario
    {
        private IMediador _mediador;
        public string Nombre { get; private set; }

        public Usuario(string nombre, IMediador mediador)
        {
            Nombre = nombre;
            _mediador = mediador;
        }

        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"{Nombre} envía: {mensaje}");
            _mediador.EnviarMensaje(mensaje, this);
        }

        public void RecibirMensaje(string mensaje, Usuario remitente)
        {
            Console.WriteLine($"{Nombre} recibe de {remitente.Nombre}: {mensaje}");
        }
    }
}
