using System.Collections.Generic;
using System.Linq;
using DomainClasses.Models;

namespace ServiceLayer.Interfaces
{
	public interface IWordService : IBaseService<Word>
	{
		IList<Word> GetAllWordByCategory(string category);
		IList<Word> GetAllWordByLanguage(string language);
		int GetWordsCountByLanguage(Language language);
		int GetWordsCountByCategory(Category category);
		IQueryable<Word> Search(string term);
		IQueryable<Word> QuickSearch(string term);
		Word GetWordByWordNameAndLanguageID(string name, int languageID);
		IList<Word> GetWordsByLanguageAndCategory(string category, string language);
	}
}