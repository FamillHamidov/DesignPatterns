﻿using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
	public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
	{
        public EfCategoryDal(Context context):base(context)
        {
            
        }
    }
}
