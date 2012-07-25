using System.Collections.Generic;
using AutoMapper;

namespace MedicallexiconProject.Classes.CustomMapper
{
	public abstract class CustomMapper<Model, ViewModel>
	{
		public ViewModel ModelViewModelMapping(Model modelName)
		{
			ModelMappToModelViewModel();
			ViewModel model = Mapper.Map<Model, ViewModel>(modelName);
			return model;
		}

		public virtual IEnumerable<ViewModel> ModelsViewModelsMapping(IEnumerable<Model> list)
		{
			ModelMappToModelViewModel();
			IEnumerable<ViewModel> model = Mapper.Map<IEnumerable<Model>, IEnumerable<ViewModel>>(list);
			return model;
		}

		public abstract void ModelMappToModelViewModel();
	}
}