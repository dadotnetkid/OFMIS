using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Win.BL
{
    interface ITransactions<TEntity>
    {
        MethodType methodType { get; set; }

        void Save();
        void Details();
        void Init();
        void Close(FormClosingEventArgs e);

    }
}
