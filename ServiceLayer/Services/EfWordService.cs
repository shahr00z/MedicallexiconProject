using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
{
	public class EfWordService : IWordService
	{
		private readonly IUnitOfWork _uow;
		private readonly IDbSet<Word> _words;

		public EfWordService(IUnitOfWork uow)
		{
			_uow = uow;
			_words = _uow.Set<Word>();
		}

		#region IWordService Members

		public void AddNew(Word obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_words.Add(obj);
		}

		public IList<Word> GetAll()
		{
			return (_words.ToList());
		}

		public Word GetByID(int id)
		{
			Word word = _words.Find(id);
			return (word);
		}

		public Word GetByName(string name)
		{
			Word word = _words.FirstOrDefault(x => x.Name == name);
			return (word);
		}

		public void Delete(int id)
		{
			var toDelete = new Word {ID = id};
			_words.Attach(toDelete);
			_words.Remove(toDelete);
		}

		public void Edit(int id, Word obj)
		{
			throw new NotImplementedException();
		}

		public IList<SelectListItem> GetSelectList()
		{
			return null;
		}

		public IList<Word> GetAllWordByCategory(string category)
		{
			List<Word> words = _words.Where(x => x.Category.Name == category).ToList();
			return (words);
		}

		public IList<Word> GetAllWordByLanguage(string language)
		{
			List<Word> words = _words.Where(x => x.Language.Name == language).ToList();
			return (words);
		}

		public int GetCount()
		{
			int count = _words.Count();
			return (count);
		}

		public int GetWordsCountByLanguage(Language language)
		{
			int count = _words.Count(x => x.Language == language);
			return count;
		}

		public int GetWordsCountByCategory(Category category)
		{
			int count = _words.Count(x => x.Category == category);
			return count;
		}

		public IQueryable<Word> Search(string term)
		{
			IQueryable<Word> word = _words
				.Where(r => r.Name.Contains(term) ||
				            String.IsNullOrEmpty(term))
				.Take(10);
			return (word);
		}

		public IQueryable<Word> QuickSearch(string term)
		{
			IQueryable<Word> word = _words
				.Where(r => r.Name.Contains(term))
				.Take(10);
			return (word);
		}

		public Word GetWordByWordNameAndLanguageID(string name, int selectedLanguageID)
		{
			Word word = _words.FirstOrDefault(x => x.Name == name & x.LanguageID == selectedLanguageID);
			return (word);
		}

		public IList<Word> GetWordsByLanguageAndCategory(string category, string language)
		{
			List<Word> words = _words.Where(x => x.Category.Name == category && x.Language.Name == language).ToList();
			return (words);
		}

		#endregion
	}
}