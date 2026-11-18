// *********************************
// Message from Original Author:
//
// 2008 Jose Menendez Poo
// Please give me credit if you use this code. It's all I ask.
// Contact me for more info: menendezpoo@gmail.com
// *********************************
//
// Original project from http://ribbon.codeplex.com/
// Continue to support and maintain by http://officeribbon.codeplex.com/



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
    public class RibbonItemCollectionEditor
        : CollectionEditor
    {
        public RibbonItemCollectionEditor()
           : base(typeof(RibbonItemCollection))
        {

        }

        protected override Type CreateCollectionItemType()
        {
            return typeof(RibbonButton);
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new[] {
            typeof(RibbonButton),
            typeof(RibbonButtonList),
            typeof(RibbonItemGroup),
            typeof(RibbonComboBox),
            typeof(RibbonSeparator),
            typeof(RibbonTextBox),
            typeof(RibbonColorChooser),
            typeof(RibbonDescriptionMenuItem),
            typeof(RibbonCheckBox),
            typeof(RibbonUpDown),
            typeof(RibbonLabel),
            typeof(RibbonHost)
         };
        }
    }
}