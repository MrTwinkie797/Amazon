using Amazon.ViewModels;

namespace Amazon.Models
{
    public class DataManager
    {
        public static ListEngineViewModel[] GetAll()
        {
            return new ListEngineViewModel[]
            {
                new ListEngineViewModel {Id = 1, Type = "B16", Litre = 1.6, Bhp = 66, TopSpeed = 140, Info = "The B16 engine was the first enginen being put in to an Amazon. It was a 1,6 liter and was quickly changed to the better B18" },
                new ListEngineViewModel {Id = 2, Type = "B16A", Litre = 1.6, Bhp = 60, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 3, Type = "B16B", Litre = 1.6, Bhp = 78, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 4, Type = "B16C", Litre = 1.6, Bhp = 60, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 5, Type = "B18", Litre = 1.8, Bhp = 75, TopSpeed = 140, Info = "This is B18" },
                new ListEngineViewModel {Id = 6, Type = "B18A-1", Litre = 1.8, Bhp = 68, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 7, Type = "B18A-2", Litre = 1.8, Bhp = 75, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 8, Type = "B18B", Litre = 1.8, Bhp = 90-103, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 9, Type = "B18D", Litre = 1.8, Bhp = 80-90, TopSpeed = 140, Info = "This is something" },
                new ListEngineViewModel {Id = 10, Type = "B20", Litre = 2.0, Bhp = 90, TopSpeed = 140, Info = "This is something" }
            };
        }

        
        public static ListEngineViewModel GetById(int id)
        {
            return new ListEngineViewModel
            {
                Type = "Name" + id
            };
        }



    }
}

