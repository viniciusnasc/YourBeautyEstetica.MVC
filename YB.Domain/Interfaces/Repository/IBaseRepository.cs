﻿using YB.Domain.Models;

namespace YB.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Incluir(T entity);
        Task Alterar(T entity);
        Task<T> SelecionarPorId(Guid id);
        Task<List<T>> SelecionarTudo();
    }
}