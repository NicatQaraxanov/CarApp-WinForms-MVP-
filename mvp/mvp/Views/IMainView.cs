using mvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddEventHandler { get; set; }

        EventHandler<EventArgs> LoadEventHandler { get; set; }


        string VendorText { get; set; }

        string ModelText { get; set; }

        string ColorText { get; set; }

        string YearText { get; set; }

        string EngineVolText { get; set; }

        List<Car> Cars { set; }

    }
}
