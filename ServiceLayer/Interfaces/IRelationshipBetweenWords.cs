using System.Collections.Generic;
using DomainClasses.Models;

namespace ServiceLayer.Interfaces
{
	public interface IRelationshipBetweenWords : IBaseService<RelationshipBetweenWords>
	{
		int GetLagnuageCount(int wordID);
		int GetRelationCount(int wordID);
		IList<Language> GetLanguage(int wordID);
	}
}