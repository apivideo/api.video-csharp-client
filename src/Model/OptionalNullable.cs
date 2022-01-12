namespace ApiVideo.Model
{
    public class OptionalNullable<T>
    {
        private T _value;

        public T value {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
                this.isDefined = true;
            }
        }
        public bool isDefined { get; set; }

        public OptionalNullable(T value)
        {
            this.value = value;
            this.isDefined = true;
        }

        public OptionalNullable()
        {
            this.isDefined = false;
        }
    }
}