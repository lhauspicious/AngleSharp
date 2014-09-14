﻿namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// This enumeration is indicating which type of unit applies to the value.
    /// </summary>
    public enum CssValueType : ushort
    {
        /// <summary>
        /// The value is inherited and the CssText contains "inherit".
        /// </summary>
        [DomName("CSS_INHERIT")]
        Inherit = 0,
        /// <summary>
        /// The value is a primitive value and an instance of the CSSPrimitiveValue.
        /// </summary>
        [DomName("CSS_PRIMITIVE_VALUE")]
        Primitive = 1,
        /// <summary>
        /// The value is a CSSValue list and an instance of the CSSValueList.
        /// </summary>
        [DomName("CSS_VALUE_LIST")]
        List = 2,
        /// <summary>
        /// The value is a custom value.
        /// </summary>
        [DomName("CSS_CUSTOM")]
        Custom = 3
    }
}
