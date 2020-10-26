using System;

namespace PatronAdapterEnchufes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enchufe comun sin adaptador
            IEnchufeIngles enchufe = new EnchufeIngles();
            Taladro taladro = new Taladro(enchufe);
            taladro.Encender();
            Console.ReadLine();

            //Ahora usamos el taladro con el adaptador
            IEnchufeEuropeo enchufeEuropeo = new EnchufeEuropeo();
            AdapterInglesEuropeo adaptador = new AdapterInglesEuropeo(enchufeEuropeo);

            Taladro taladro2 = new Taladro(adaptador);
            taladro.Encender();
            Console.ReadLine();
        }
    }
}
