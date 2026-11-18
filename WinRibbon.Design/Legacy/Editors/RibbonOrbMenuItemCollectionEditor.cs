
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace RibbonLib
{
    class RibbonOrbMenuItemCollectionEditor
        : CollectionEditor
    {
        public RibbonOrbMenuItemCollectionEditor()
           : base(typeof(RibbonOrbMenuItemCollection))
        {
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(RibbonOrbMenuItem);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] {
            typeof(RibbonOrbMenuItem),
            typeof(RibbonSeparator)
         };
        }
    }
}