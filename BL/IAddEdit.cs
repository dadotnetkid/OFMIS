using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public interface IAddEdit<TEntity>
    {
        void Add(TEntity entity);
        void Edit(TEntity entity);
        TEntity Details(int id);
        void Details(Form form);
        object Init();
        object Id { get; set; }
        
    }
}
