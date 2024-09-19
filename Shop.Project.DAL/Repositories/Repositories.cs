using Microsoft.EntityFrameworkCore;
using Shob.Project.Models.Entities;

namespace Shop.Project.DAL.Repositories;

public class Repositories<T> : IRepositories<T> where T : BaseEntity, new()
{
    private readonly ShoppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repositories()
    {
        _context = new ShoppDbContext();
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        entity.CreatedDate = DateTime.Now;
    }

    public void Delete(int id)
    {

        var entity = _dbSet.FirstOrDefault(x => x.Id == id);
        if (entity != null)
        {
            entity.IsDeleted = true;
        }
        else
        {
            throw new NullReferenceException();
        }
        entity.DeletedDate = DateTime.Now;
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.Where(t=>t.IsDeleted==false).ToList();

    }

    public T GetById(int id)
    {

        var entity = _dbSet.Where(x=>x.IsDeleted==true).FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
            throw new NullReferenceException();
        }
        return entity;
    }


    public void Update(T entity)
    {
        throw new Exception();
    }
    public void SaveChange()
    {
        _context.SaveChanges();
    }
}
