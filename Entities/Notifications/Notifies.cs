using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropiedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]
        public  List<Notifies> Notitycoes;

        public bool ValidrPropiedadeString( string valor, string nomePropiedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropiedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "campo Obrigatório",
                    NomePropiedade = NomePropiedade,
                });

                return false;
            }

            return true;
        }

        public bool ValidrPropiedadeInt(int valor, string nomePropiedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropiedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "valor deve ser maior que zero",
                    NomePropiedade = NomePropiedade,
                });

                return false;
            }

            return true;
        }

        public bool ValidrPropiedadeDecimal(decimal valor, string nomePropiedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropiedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "valor deve ser maior que zero",
                    NomePropiedade = NomePropiedade,
                });

                return false;
            }

            return true;
        }
    }
}
