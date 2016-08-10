using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMembersystem.Models
{
    
        class OLS<T> : ObservableCollection<T>, IListSource where T: BaseModel 
        {
            private IBindingList _bind;

            bool IListSource.ContainsListCollection => false;

            IList IListSource.GetList()
            {
                return _bind ?? (this.ToBindingList());
            }

        }

    
}
