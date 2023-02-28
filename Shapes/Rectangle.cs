using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Represents a rectangle.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Get or set the length of the rectangle.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Get or set the width of the rectangle.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Constructs a rectangle with a length and width of 10.
        /// </summary>
        public Rectangle() : this(10, 10) { }

        /// <summary>
        /// Constructors a rectangle with a given length and width.
        /// </summary>
        /// <param name="length">Length of the rectangle.</param>
        /// <param name="width">Width of the rectangle.</param>
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area of the rectangle.</returns>
        public int Area()
        {
            return Length * Width;
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter of the rectangle.</returns>
        public int Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        /// <summary>
        /// Reports whether the rectangle is a square.
        /// </summary>
        /// <returns>
        /// Returns true if the rectangle is a square; false otherwise.
        /// </returns>
        public bool IsSquare()
        {
            return Length == Width;
        }

        /// <summary>
        /// Converts the object into a string.
        /// </summary>
        /// <returns>
        /// A string in the format "Rectangle with length = {Length}
        /// and width = {Width}".
        /// </returns>
        public override string ToString()
        {
            return "Rectangle with length = " + Length 
                + " and width = " + Width;
        }
    }
}
