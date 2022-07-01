namespace PRJ_CONTAS_BANCARIAS.Classes
{
    public class Endereco
    {
        public string? logradouro { get; set; }
        
        public int numero { get; set; }
        
        public string? complemento { get; set; }
        
        public bool endComercial  { get; set; }

        public static implicit operator string(Endereco v)
        {
            throw new NotImplementedException();
        }
    }
}