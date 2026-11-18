
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
    class RibbonOrbRecentItemCollectionEditor
        : CollectionEditor
    {
        public RibbonOrbRecentItemCollectionEditor()
           : base(typeof(RibbonOrbRecentItemCollection))
        {
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(RibbonOrbRecentItem);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] {
            typeof(RibbonOrbRecentItem),
            typeof(RibbonSeparator)
         };
        }
    }
}