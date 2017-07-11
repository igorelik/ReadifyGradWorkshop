using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Business
{
    public class ModelService : IModelService
    {
        public ModelService()
        {

        }

        public SimpleModel GetEmpty()
        {
            return new SimpleModel();
        }
    }
}