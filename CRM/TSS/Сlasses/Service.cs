using TSS.Enumes.Work;

namespace TSS.Classes
{
    public class Service
    {
        private Serviсe_type _servise_type;
        private int _price;

        public Service() { }
        public Service(int servise_type, int price)
        {
            Type = (Serviсe_type)servise_type;
            Price = price;
        }

        public Serviсe_type Type
        {
            get { return _servise_type; }
            set { _servise_type = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}