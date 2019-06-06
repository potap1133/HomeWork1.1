namespace HomeWork10
{
    public class Man1
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
                if (value > 0 && value < 150)
                {
                    _age = value;
                }
            }

        }

    }
}
