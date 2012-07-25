using System.Collections.Generic;
using DomainClasses.Models;

namespace ServiceLayer.Interfaces
{
	public interface IPictureService : IBaseService<Picture>
	{
		IList<Picture> GetPicturesByTag(string tag);
		IList<Picture> GetPicturesByWord(Word word);
		IList<Picture> GetPicturesByWordID(Word wordID);
		void SavaPictures(IList<Picture> pictures);
	}
}