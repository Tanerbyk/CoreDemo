﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IBlogService
    {
        void BlogAdd(Blog blog);

        void BlogDelete(Blog blog);

        void BlogUpdate(Blog blog);

        List<Blog> GetList();

        Blog Getbyid(int id);

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogByWriter(int id);

        


    }
}
