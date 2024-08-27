namespace AplicacaoMVClinq.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }
        public Cliente(int id, string Nome, string Email, string Telefone, DateOnly DataNasc)
        {
            this.ClienteId = id;
            this.Nome = Nome;
            this.Email = Email;
            this.Telefone = Telefone;
            this.DataNasc = DataNasc;
        }
    }

}
