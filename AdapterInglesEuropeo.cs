namespace PatronAdapterEnchufes
{
    public class AdapterInglesEuropeo: IEnchufeIngles
    {
        //primero el adatpador se hereda de la interface Enchufe Ingles
        //Luego debe recibir una interface de enchufe europeo

        IEnchufeEuropeo enchufeEuropeo = new EnchufeEuropeo();
        /*una forma alternativo de inicializar una interface es 
        private IEnchufeIngles _enchufe;
        */

        //Creamos el constructor para que reciba enchufe europeo
        public AdapterInglesEuropeo(IEnchufeEuropeo enchufe)
        {
            enchufeEuropeo = enchufe;
        }
        public int flujo110v()
        {
            //En este metodo debemos adaptar el 220 al 110
            int voltaje220 = enchufeEuropeo.flujo220v();
            int voltaje110 = voltaje220/2;
            return voltaje110;
        }


        //Recordemos siempre que la acción del Adapter debe ser adaptar un método "viejo" a uno "nuevo".
        //Acá lo que hacemos es invocar al método Flujo110 del enchufe británico que llamará al 220 del enchufe español
        //adaptando el voltaje "viejo" al nuevo. Es decir, el método del adaptador devolverá 110 v, que son los que 
        //recibirá el taladro.
    }
}