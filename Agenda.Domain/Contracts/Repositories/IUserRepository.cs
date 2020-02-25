using Agenda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domain.Contracts.Repositories
{
     public  interface IUserRepository : IDisposable
    {
        User Get(string nome);
        User Get(Guid id);
        void Create(User user);
        void Update(User user);
        void Delete(User user);

    }
}
