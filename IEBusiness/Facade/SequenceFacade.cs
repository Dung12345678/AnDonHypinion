
using System.Collections;
using IE.Model;
namespace IE.Facade
{
	
	public class SequenceFacade : BaseFacade
	{
		protected static SequenceFacade instance = new SequenceFacade(new SequenceModel());
		protected SequenceFacade(SequenceModel model) : base(model)
		{
		}
		public static SequenceFacade Instance
		{
			get { return instance; }
		}
		protected SequenceFacade():base() 
		{ 
		} 
	
	}
}
	