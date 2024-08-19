
namespace Homework_2
{
    internal class Square: Figure
    {

        public Square( float  sideInput)
        {
            _side = sideInput;
        }

        private float _side;

		public float Side
		{
			get { return _side; }

            init { if (value >= 0) _side = value; }
		}

        public override float CalcArea()
        {
            return _side * _side ;
        }


    }
}
