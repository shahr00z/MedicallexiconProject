using System.Linq;
using AutoMapper;
using DomainClasses.Models;
using MedicallexiconProject.ViewModel;

namespace MedicallexiconProject.Classes.CustomMapper
{
	public class LanguageMapper : CustomMapper<Language, LanguageViewModel>
	{
		public override void ModelMappToModelViewModel()
		{
			Mapper.CreateMap<Language, LanguageViewModel>()
				.ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(x => x.ID, opt => opt.MapFrom(src => src.ID))
				.ForMember(x => x.WordCount, opt => opt.MapFrom(src => src.Words.Count(w => w.Language.Name == w.Name)));
		}
	}
}