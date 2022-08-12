using PRJ_CONTAS_BANCARIAS.Interfaces;

namespace PRJ_CONTAS_BANCARIAS.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        
        
        public override float PagarImposto(float rendimento)
        {
            /* Escala de cobrança
            Até 1500 (considerando 1500) - isento 
            De 1500 a 3500 (considerando 3500) - 2% de impostos
            De 3500 a 6000 (considerando 6000) - 3,5 % de impostos
            Acima de 6000 - 5% de impostos
            */
            
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if(rendimento > 1500 && rendimento <= 3500){
                return (rendimento / 100) * 2;
            }
            else if(rendimento > 3500 && rendimento <= 6000){
                return (rendimento / 100) * 3.5f;
            }
            else{
                return (rendimento / 100) * 5;
            }
        }
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual= DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;
            if(anos >= 18){
                return true;
            }
            return false;
        }
        

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida)){
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if(anos >= 18){
                    return true;
                }
                return false;
            }
            return false;  
        }
    }
}