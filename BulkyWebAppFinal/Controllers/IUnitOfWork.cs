using Bulky.Models;

namespace BulkyBook.Controllers
{
    public interface IUnitOfWork
    {

        Category Category { get; }

        void Save();
    }
}