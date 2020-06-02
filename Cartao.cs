namespace Aula08Abstração
{
    public class Cartao : Pagamento
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
        private string token = "090898yfu8syyag889gya89";

        public bool validarToken(){
            if(token !=null){
                return true;
            }
            return false;
        }
    }
}