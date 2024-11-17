using PatronMediador;
using System;

class Program
{
    static void Main(string[] args)
    {
        IMediador chat = new ChatMediador();

        Usuario usuario1 = new Usuario("Juan", chat);
        Usuario usuario2 = new Usuario("María", chat);
        Usuario usuario3 = new Usuario("Carlos", chat);

        chat.RegistrarUsuario(usuario1);
        chat.RegistrarUsuario(usuario2);
        chat.RegistrarUsuario(usuario3);

        usuario1.EnviarMensaje("Hola a todos");
        usuario2.EnviarMensaje("Hola Juan");
        usuario3.EnviarMensaje("Buenas tardes");
    }
}
