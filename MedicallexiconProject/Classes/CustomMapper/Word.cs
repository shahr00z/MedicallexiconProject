using AutoMapper;
using DomainClasses.Models;
using MedicallexiconProject.ViewModel;

namespace MedicallexiconProject.Classes.CustomMapper
{
	public class WordMapper : CustomMapper<Word, WordViewModel>
	{
		public override void ModelMappToModelViewModel()
		{
			Mapper.CreateMap<Word, WordViewModel>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.LanguageName, opt => opt.MapFrom(src => src.Language.Name))
				.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
		}
	}
}