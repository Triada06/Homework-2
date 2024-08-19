namespace Homework_2
{
    internal class Rectangular : Figure
    {
        private float _width;

        public float Width
        {
            get { return _width; }
            init { if (value >= 0) _width = value; }
        }

        private float _length;

        public float Length
        {
            get { return _length; }
            init { if (value >= 0) _length = value; }
        }



        public Rectangular(float lengthInput, float widthInput)
        {
            _length = lengthInput;
            _width = widthInput;
        }



        public override float CalcArea()
        {
            return _width * _length;
        }

    }
}
