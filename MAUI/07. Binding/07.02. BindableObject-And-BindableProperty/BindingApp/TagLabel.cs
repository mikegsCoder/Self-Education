using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingApp
{
    //Bindable property example:
    public class TagLabel : Label
    {
        public static readonly BindableProperty TagProperty =
            BindableProperty.Create("Tag",  // property name
                typeof(string),             // property return type 
                typeof(TagLabel),           // type
                "0"                         // default setting
            );

        public string Tag
        {
            set
            {
                SetValue(TagProperty, value);
            }
            get
            {
                return (string)GetValue(TagProperty);
            }
        }
    }
}
