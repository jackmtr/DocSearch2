using DocSearch.Models;
using DocSearch.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocSearch.Repositories
{
    public class PublicDataVMRepo
    {
        //repos does all the actual quering for the project, and the controller will call these actions
        private WASEntities _db = new WASEntities();

        public PublicDataVM getPublic(int publicNumber) {

            PublicDataVM publicData = new PublicDataVM();

            return null;
        }
    }
}