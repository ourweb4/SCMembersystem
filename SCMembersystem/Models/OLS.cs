// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-08-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-08-2016
// ***********************************************************************
// <copyright file="OLS.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
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

    /// <summary>
    /// Class OLS.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.ObjectModel.ObservableCollection{T}" />
    /// <seealso cref="System.ComponentModel.IListSource" />
    class OLS<T> : ObservableCollection<T>, IListSource where T: BaseModel 
        {
        /// <summary>
        /// The bind
        /// </summary>
        private IBindingList _bind;

        /// <summary>
        /// Gets a value indicating whether the collection is a collection of <see cref="T:System.Collections.IList" /> objects.
        /// </summary>
        /// <value><c>true</c> if [contains list collection]; otherwise, <c>false</c>.</value>
        bool IListSource.ContainsListCollection => false;

        /// <summary>
        /// Returns an <see cref="T:System.Collections.IList" /> that can be bound to a data source from an object that does not implement an <see cref="T:System.Collections.IList" /> itself.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IList" /> that can be bound to a data source from the object.</returns>
        IList IListSource.GetList()
            {
                return _bind ?? (this.ToBindingList());
            }

        }

    
}
