namespace Aula09.Dominio
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public int IdCliente { get; set; }
        public int IdComercio { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
