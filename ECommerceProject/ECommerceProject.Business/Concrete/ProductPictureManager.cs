﻿using ECommerceProject.Business.Abstract;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Concrete
{
	public class ProductPictureManager : IProductPictureService
	{
		public Task<ProductPicture> TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ProductPicture>> TGetList()
		{
			throw new NotImplementedException();
		}

		void IGenericService<ProductPicture>.TAdd(ProductPicture entity)
		{
			throw new NotImplementedException();
		}

		void IGenericService<ProductPicture>.TDelete(ProductPicture entity)
		{
			throw new NotImplementedException();
		}

		
		void IGenericService<ProductPicture>.TUpdate(ProductPicture entity)
		{
			throw new NotImplementedException();
		}
	}
}
