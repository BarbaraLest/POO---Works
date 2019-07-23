using System;
using System.Text;

namespace Modelo.Dados
{
    public class Reflection
    {
        public static void Log(object obj)
        {
            var tipo = obj.GetType();

            StringBuilder construtor = new StringBuilder();
            construtor.AppendLine($"Log feito por: {tipo.Name}");
            construtor.AppendLine($"Data do login: {DateTime.Now}");

            foreach (var prop in tipo.GetProperties())
            {
                construtor.AppendLine($"{prop.Name}: {prop.GetValue(obj)}");
            }
            ImprimeLog(construtor.ToString());
        }

        public static void ImprimeLog(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
