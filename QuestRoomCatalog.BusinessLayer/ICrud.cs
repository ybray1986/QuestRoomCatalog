using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer
{
    public interface ICrud<T> where T: class
    {
        void Create(T model);
        IEnumerable<T> Read();
        void Update(T model);
        void Delete(int id);


    }
}
