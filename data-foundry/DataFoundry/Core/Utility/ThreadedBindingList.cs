using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Threading;

namespace DataFoundry.Core.Utility
{

    public class ThreadedBindingList<T> : BindingList<T>
    {
        SynchronizationContext ctx = SynchronizationContext.Current;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            if (ctx == null)
            {
                BaseAddingNew(e);
            }
            else
            {
                ctx.Send(delegate
                {
                    BaseAddingNew(e);
                }, null);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        void BaseAddingNew(AddingNewEventArgs e)
        {
            base.OnAddingNew(e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnListChanged(ListChangedEventArgs e)
        {
           // SynchronizationContext ctx = SynchronizationContext.Current;
            if (ctx == null)
            {
                BaseListChanged(e);
            }
            else
            {
                ctx.Send(delegate
                {
                    BaseListChanged(e);
                }, null);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        void BaseListChanged(ListChangedEventArgs e)
        {
            base.OnListChanged(e);
        }
    } 
}
