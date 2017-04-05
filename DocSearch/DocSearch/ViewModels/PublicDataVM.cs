using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocSearch.ViewModels
{
    public class PublicDataVM
    {
        public int Document_ID { get; set; } // tbl_Document
        public int DocumentType_ID { get; set; } // tbl_DocumentType

        //name of the document type
        public string DocTypeName { get; set; } // tbl_DocumentType.Name
        public Nullable<System.DateTime> Issue_DT { get; set; } // tbl_DocumentType
        public string Description { get; set; } // tbl_Document
        //need the ArchivedFile too and anything relating to it
        public int Category_ID { get; set; } // tbl_Category
        public string CategoryName { get; set; } //tbl_Category.Name
    }
}