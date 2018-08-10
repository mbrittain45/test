using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;


namespace WebApplication1.Models
{
    public class Calculate
    {
        const int maxSize = 60;
        const int rowSize  = 10;
        const int columnSize = 10;

        string[] rowNames = new string[] { "F", "E", "D", "C", "B", "A" };
        
        string FigureName( Point v1, Point v2, Point v3 )
        {
            string name;
            int column;

            if (v1.Y > maxSize || v2.Y > maxSize || v3.Y > maxSize)
                return "Error";

            if (v1.X > maxSize || v2.X > maxSize || v3.X > maxSize)
                return "Error";

            // find the row we are looking for
            int yRowStart = (v1.Y / rowSize);
            int yRowEnd   = (v2.Y / rowSize);
            if ( yRowEnd < yRowStart )
                name = rowNames[ yRowEnd ];
            else
                name = rowNames[ yRowStart ];

            // figure out the column and which half
            int xColStart = (v1.X / columnSize);
            int xColEnd   = (v3.X / columnSize);
            if (xColEnd < xColStart)
                column = (xColEnd * 2);
            else
                column = xColStart;

            name += Convert.ToString(column);

            return name;
        }
    }
}
