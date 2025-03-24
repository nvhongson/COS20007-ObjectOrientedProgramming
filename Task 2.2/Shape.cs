using SplashKitSDK;

namespace DrawingShape
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private readonly int _width;
        private readonly int _height;

        public Shape()
        {
            _color = Color.Green; //Setting initial color
            _x = _y = 0; //Setting initial starting coords
            _width = _height = 100; //Setting shape dimesions
        }
        // Color
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        // X axis
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        // Y axis
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        // Draw 
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }


        public bool IsAt(Point2D p)
        {
            return SplashKit.PointInRectangle(p, SplashKit.RectangleFrom(X, Y, _width, _height));
        }

    }
}