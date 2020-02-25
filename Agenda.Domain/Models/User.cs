using System;


namespace Agenda.Domain.Models
{
    public class User
    {
        #region Ctor
        protected User() { }
        public User(string nome, string cpf, string telefone, string email, string endereco)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
        }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        #endregion

        #region Methods
         public void ChangeName(string nome)
        {
            this.Nome = nome;
         }
        #endregion
    }
}
