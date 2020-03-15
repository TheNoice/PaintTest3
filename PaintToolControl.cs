using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTest3
{
    public class PaintToolControl
    {
        public PaintingToolType ChoosendPaintingTool { get; set; }

        /// <summary>
        /// Sets a <see cref="PaintingToolType"/> that will be currently used to paint
        /// </summary>
        /// <param name="paintingToolType">e.g. a Pen, a Rectangle and so on</param>
        public PaintToolControl(PaintingToolType paintingToolType)
        {
            ChoosendPaintingTool = paintingToolType;
        }
    }
}
