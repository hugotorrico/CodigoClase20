using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CodigoClase20
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public string ImagePath { get; set; }
        public Brush BackgroundColor
        {
            get
            {
                return Grade >= 70 ? Brushes.Green : Brushes.Red;
            }
        }
        public string ImageOk
        {
            get
            {
                return Grade >= 70 ? "https://w7.pngwing.com/pngs/537/407/png-transparent-verified-check-mark-confirmation-checkbox-passed-icon-thumbnail.png"
                    : "https://w7.pngwing.com/pngs/412/774/png-transparent-red-mark-cross-crossed-wrong-incorrect-sign-symbol-icon-thumbnail.png";
            }
        }



    }
}
