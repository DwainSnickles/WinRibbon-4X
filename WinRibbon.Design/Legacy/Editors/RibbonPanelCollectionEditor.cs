using System;
using System.ComponentModel.Design;

namespace RibbonLib
{
    /// <summary>
    /// Design-time editor for the ribbon's tab collection.
    /// </summary>
    public class RibbonPanelCollectionEditor
        : CollectionEditor
    {
        public RibbonPanelCollectionEditor()
           : base(typeof(RibbonPanelCollection))
        {
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(RibbonPanel);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] { typeof(RibbonPanel) };
        }
    }
}
