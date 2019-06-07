namespace HomeWork10
{
    public class Man2
    {
        public string Name { get; set; }

        int _age;

        public int Age
        {
            get
            {
                return _age + 4;
            }

            set
            {

                _age = value;

            }

        }

    }
}
