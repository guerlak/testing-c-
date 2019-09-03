

namespace ByteBank
{
    public class Customer
    {
        private string _name { get; set; }
        private string _cpf { get; set; }
        private string _email;
        
        public Customer(string name, string cpf, string email)
        {
            this._name = name;
            this._cpf = cpf;
            this._email = email;
        }

        public string getName()
        {
            return _name;
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                //validate here
                if(int.TryParse(value, out int v))
                {
                    _email = value;
                }
               
            }
        }

    }
}
