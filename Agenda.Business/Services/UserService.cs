using Agenda.Domain.Contracts.Repositories;
using Agenda.Domain.Contracts.Services;
using Agenda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Business.Services
{
    public class UserService : IUseService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void ChangeInformation(string email, string nome, string cpf)
        {
            var user = GetByEmail(email);
            user.ChangeName(nome);
            _repository.Update(user);
        }

        private object GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Register(string name, string email, string cpf, string endereco, string telefone)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _repository.Dispose();
        }

        User IUseService.GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
