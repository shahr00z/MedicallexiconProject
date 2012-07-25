using AutoMapper;
using DomainClasses.Models;
using MedicallexiconProject.ViewModel;

namespace MedicallexiconProject.Classes.CustomMapper
{
	public class CategoryMapper : CustomMapper<Category, CategoryViewModel>
	{
		public override void ModelMappToModelViewModel()
		{
			Mapper.CreateMap<Category, CategoryViewModel>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
		}
	}
}