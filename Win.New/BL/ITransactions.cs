using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Win.BL
{
   public interface ITransactions<TEntity>
    {
        MethodType methodType { get; set; }
        void Save();
        void Detail();
        void Init();
        void Close(FormClosingEventArgs eventArgs);
    }
}
