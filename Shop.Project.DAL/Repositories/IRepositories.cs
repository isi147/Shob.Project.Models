using Shob.Project.Models.Entities;

namespace Shop.Project.DAL.Repositories;

public interface IRepositories<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Update(T entity);
    T GetById(int id);
    public IEnumerable<T> GetAll();
    public void Delete(int id);
    public void SaveChange();
}
