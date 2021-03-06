using System.Collections;
using HP.Model;
namespace HP.Facade
{

    public class EventsLogFacade : BaseFacade
    {
        protected static EventsLogFacade instance = new EventsLogFacade(new EventsLogModel());
        protected EventsLogFacade(EventsLogModel model)
            : base(model)
        {
        }
        public static EventsLogFacade Instance
        {
            get { return instance; }
        }
        protected EventsLogFacade()
            : base()
        {
        }

    }
}