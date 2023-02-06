using DatingApp.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace DatingApp.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Player>Players { get; }
        IGenericRepository<Message>Messages { get; }
        IGenericRepository<Consultation>Consultations { get; }
        IGenericRepository<MatchType>MatchTypes { get; }
    }
}