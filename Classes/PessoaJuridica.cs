using PRJ_CONTAS_BANCARIAS.Interfaces;
using System.Text.RegularExpressions;


namespace PRJ_CONTAS_BANCARIAS.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? razaoSocial { get; set; }

        public string? cnpj { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public override float PagarImposto(float rendimento)
        {
            /* Escala de cobrança
            Até 1500 (considerando 1500) - 3% de impostos 
            De 1500 a 3500 (considerando 3500) - 5% de impostos
            De 3500 a 6000 (considerando 6000) - 7 % de impostos
            Acima de 6000 - 9% de impostos
            */

            if (rendimento <= 1500)
            {
                return (rendimento / 100) * 3;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 5;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return (rendimento / 100) * 7;
            }
            else
            {
                return (rendimento / 100) * 9;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    public void Inserir(PessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);

            string[] pjString = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjString);
        }
        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);


            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();
                
                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}