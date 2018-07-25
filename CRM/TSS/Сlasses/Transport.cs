using TSS.Enumes.Transport;
using System.Collections.Generic;

namespace TSS.Classes
{
    public class Transport
    {
        private Brand_tr _brand_tr;
        private string _additional_information;        
        private Color_tr _color_tr;
        private List<Service> _services;

        public List<Service> Services_List
        {
            get { return _services; }
            set { _services = value; }
        }

        public virtual Brand_tr Brand
        {
            get { return _brand_tr; }
            set { _brand_tr = value; }
        }

        public string Info
        {
            get { return _additional_information; }
            set { _additional_information = value; }
        }

        public virtual Color_tr Color
        {
            get { return _color_tr; }
            set { _color_tr = value; }
        }
    }
}