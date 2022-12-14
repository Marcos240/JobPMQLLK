using SE214L22.Data.Entity.AppProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE214L22.Core.ViewModels.Reports.Dtos
{
    public class SearchModeDto:BaseDto
    {
        private int _key;
        private string _name;

        public int Key { get => _key; set { _key = value; OnPropertyChanged(); } }
        public string Name { get => _name; set { _name = value; OnPropertyChanged();} }

        //public SearchModeDto(int key, string name)
        //{
        //    Key = key;
        //    Name = name;
        //}
    }
}


