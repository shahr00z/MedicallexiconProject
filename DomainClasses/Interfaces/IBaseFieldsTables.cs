using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DomainClasses.Interfaces
{
	/// از این اینترفیس به منظور تعیین فیلدهایی
	/// استفاده می شود که در تمامی کلاس های ما استفاده میشوند
	/// علت استفاده از این اینترفیس جلوگیری از تکرار کد و
	/// همچنین امکان اضافه کردن فیلدبه تمام جداول از این طرق فراهم می باشد
	internal interface IBaseFieldsTables
	{
		int ID { get; set; }
		string Name { get; set; }
		Guid UniqID { get; set; }
		DateTime CreatedDate { get; set; }
		byte[] RowVersion { set; get; }
	}
}