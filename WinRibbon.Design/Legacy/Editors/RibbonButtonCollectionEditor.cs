using System;
using System.ComponentModel.Design;

namespace RibbonLib
{
    /// <summary>
    /// Design-time editor for <see cref="RibbonButtonList.Buttons"/>. A button list only
    /// accepts <see cref="RibbonButton"/> items, so this editor offers that single type.
    /// </summary>
    public class RibbonButtonCollectionEditor
        : CollectionEditor
    {
        public RibbonButtonCollectionEditor()
           : base(typeof(RibbonButtonCollection))
        {
        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(RibbonButton);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] { typeof(RibbonButton) };
        }
    }
}
