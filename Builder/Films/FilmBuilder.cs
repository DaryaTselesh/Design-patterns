using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example
{
	public abstract class FilmBuilder
	{
		public virtual void SetScenario() { }

		public virtual void SetFilmName() { }

		public virtual void SetAuthors() { }

		public abstract IFilm GetResult();
	}
}
