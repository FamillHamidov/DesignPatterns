﻿using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TDelete(Product t)
		{
			_productDal.Delete(t);	
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);	
		}

		public List<Product> TGetList()
		{
			return _productDal.GetList();
		}

		public void TInsert(Product t)
		{
			_productDal.Insert(t);
		}

		public List<Product> TProductListWithCategoryName()
		{
			return _productDal.ProductListWithCategoryName();
		}

		public void TUpdate(Product t)
		{
			_productDal.Update(t);
		}
	}
}
