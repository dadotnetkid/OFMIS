using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win.BL
{
    public interface ILoad<TEntity> where TEntity : class
    {
        void Init();
        void Detail(TEntity item);
        void Search(string search);
    }
}
