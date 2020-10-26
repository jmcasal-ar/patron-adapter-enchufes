using System;
namespace PatronAdapterEnchufes
{
    public class Taladro
    {
        //el ejercicio dice que el taladro recibe en su inicializacion un enchufe ingles
        private IEnchufeIngles _enchufe;

        public Taladro(IEnchufeIngles enchufe)
        {
            _enchufe = enchufe;
        }
        public void Encender()
        {
            int voltaje110= _enchufe.flujo110v();
            Console.WriteLine("El taladro se ha encendido con enchufe britanico de " + voltaje110);
        }
    }
}