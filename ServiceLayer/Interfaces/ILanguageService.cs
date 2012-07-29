using DomainClasses.Models;

namespace ServiceLayer.Interfaces
{
	public interface ILanguageService : IBaseService<Language>
	{
		int GetCountLanguageWithoutWord();
	}
}