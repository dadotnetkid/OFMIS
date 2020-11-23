using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.BL;

namespace Win.BL
{
    public interface IAddEditTransaction<TEntity> : ITransactions<TEntity> where TEntity : class
    {
        void Delete(TEntity item);
        

    }
}
