using System;

namespace Registration
{
	public class Speaker : Registrant
	{
		public Speaker (string title, int room)
		{
			Title = title;
			Room = room;
		}

		public string Title { get; private set; }
		public int Room { get; private set; }
	}
}