using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkshopMVC.Models;

namespace WorkshopMVC.Business
{
    public class ModelService : IModelService
    {
        public SimpleModel GetEmptyModel()
        {
            return new SimpleModel();
        }
    }
}