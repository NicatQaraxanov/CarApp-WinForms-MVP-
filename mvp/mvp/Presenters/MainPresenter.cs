using mvp.Data;
using mvp.Models;
using mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp.Presenters
{
    public class MainPresenter
    {
        private readonly CarDbContext carDbContext;
        private readonly IMainView mainView;

        public MainPresenter(IMainView view)
        {
            mainView = view;
            carDbContext = new CarDbContext();

            mainView.AddEventHandler += ViewAddButtonClicked;
            mainView.LoadEventHandler += ViewLoadButtonClicked;

        }

        private void ViewAddButtonClicked(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Vendor = mainView.VendorText,
                Model = mainView.ModelText,
                Year = int.Parse(mainView.YearText),
                EngineVolume = float.Parse(mainView.EngineVolText),
                Color = mainView.ColorText
            };

            carDbContext.Cars.Add(car);
            carDbContext.SaveChanges();


        }

        private void ViewLoadButtonClicked(object sender, EventArgs e)
        {
            mainView.Cars = carDbContext.Cars.ToList();
        }

    }
}
