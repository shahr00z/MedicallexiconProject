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
				.ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name));
		}
	}
}