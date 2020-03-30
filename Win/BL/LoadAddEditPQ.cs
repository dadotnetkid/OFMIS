using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Win.BL
{
    public class LoadAddEditPQ : ILoad<PriceQuotations>, ITransactions<PriceQuotations>
    {
        public MethodType methodType { get; set; }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Detail()
        {
            throw new NotImplementedException();
        }

        void ITransactions<PriceQuotations>.Init()
        {
            throw new NotImplementedException();
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        void ILoad<PriceQuotations>.Init()
        {
            throw new NotImplementedException();
        }

        public void Detail(PriceQuotations item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
