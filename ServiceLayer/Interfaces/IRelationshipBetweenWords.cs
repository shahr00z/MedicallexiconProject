using DomainClasses.Models;

namespace ServiceLayer.Interfaces
{
	public interface IRelationshipBetweenWords : IBaseService<RelationshipBetweenWords>
	{
		int GetLagnuageCount(int wordID);
		int GetRelationCount(int wordID);
	}
}