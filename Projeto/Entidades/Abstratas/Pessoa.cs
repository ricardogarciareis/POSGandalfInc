namespace Projeto.Lib.Entidades
{
    public abstract class Pessoa : Entidade
    {
        public string NIF { get; set; }
        public Morada MoradaPessoa { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {
            MoradaPessoa = new Morada();

        }
    }
}
