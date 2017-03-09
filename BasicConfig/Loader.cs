using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicConfig
{
    public class Loader : IResult
    {
        readonly string message;
        readonly bool hide;

        public Loader(string message)
        {
            this.message = message;
        }

        public Loader(bool hide)
        {
            this.hide = hide;
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;

        public void Execute(CoroutineExecutionContext context)
        {
            var view = context.View as FrameworkElement;
            while (view != null)
            {
                var busyIndicator = view as BusyIndicator;
                if (busyIndicator != null)
                {
                    if (!string.IsNullOrEmpty(message))
                        busyIndicator.BusyContent = message;
                    busyIndicator.IsBusy = !hide;
                    break;
                }

                view = view.Parent as FrameworkElement;
            }

            Completed(this, new ResultCompletionEventArgs());
        }
    }
}
