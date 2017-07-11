using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopMVC.Models;

namespace WorkshopMVC.Business
{
    public interface IModelService
    {
        SimpleModel GetEmptyModel();
    }
}
