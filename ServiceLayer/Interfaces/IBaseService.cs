using System.Collections.Generic;
using System.Web.Mvc;

namespace ServiceLayer.Interfaces
{
	public  interface IBaseService<T>
	{
		void AddNew(T obj);
		IList<T> GetAll();
		T GetByID(int id);
		T GetByName(string name);
		void Delete(int id);
		void Edit(int id, T obj);
		IList<SelectListItem> GetSelectList();
		int GetCount();
	}
}
