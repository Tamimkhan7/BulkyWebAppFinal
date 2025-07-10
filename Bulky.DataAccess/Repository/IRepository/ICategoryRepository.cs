//using Bulky.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bulky.DataAccess.Repository.IRepository
//{
//    internal interface ICategoryRepository; IRepository<Category>
//    {
//          void Update(Category obj);      
//    }
//}

using Bulky.Models;
using System;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
