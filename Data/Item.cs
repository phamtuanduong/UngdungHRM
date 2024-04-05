using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Item : BaseViewModel
    {
        private bool isSelect;
        public bool IsSelect { get => isSelect; set { isSelect = value; base.OnPropertyChanged("IsSelect"); } }
    }
}
