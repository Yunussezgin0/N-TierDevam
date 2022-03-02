using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void Destroy(T item);
        void AddRange(List<T> list);
        void UpdateRange(List<T> list);
        void DeleteRange(List<T> list);
        void DestoryRange(List<T> list);

        List<T> Where(Expression<Func<T, bool>> expression);
        bool Any(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        object Select(Expression<Func<T, object>> expression);

        T Find(int id);
    }
}
