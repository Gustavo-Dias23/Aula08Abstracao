using System;
namespace Aula08Abstração
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar(float valor){
            return "Pagamento efetuado";
        }
        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }
    }
}