using PRJ_CONTAS_BANCARIAS.Interfaces;

namespace PRJ_CONTAS_BANCARIAS.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?razaoSocial { get; set; }

        public string ?cnpj { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}