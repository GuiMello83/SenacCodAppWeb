using System.Collections.Generic;
namespace consultorio.Models
{
    public class InfoAgenda
    {
        private static List<Agenda> lista = new List<Agenda>();

        public static void Incluir(Agenda item){
            lista.Add(item);
        }

        public static List<Agenda> Listar(){
            return lista;
        }
    }
}