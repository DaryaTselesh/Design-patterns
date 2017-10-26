using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example
{
	public class DramaBuilder : FilmBuilder
	{
		public override IFilm GetResult()
		{
			throw new NotImplementedException();
		}
	}
}
