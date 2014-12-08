﻿namespace AngleSharp.DOM.Css.Media
{
    using AngleSharp.Extensions;
    using System;

    sealed class ColorIndexMediaFeature : MediaFeature
    {
        #region Fields

        static readonly IValueConverter<Int32> Converter = Converters.IntegerConverter.Constraint(m => m >= 0);
        Int32 _index;

        #endregion

        #region ctor

        public ColorIndexMediaFeature(String name)
            : base(name)
        {
        }

        #endregion

        #region Methods

        protected override Boolean TrySetDefault()
        {
            _index = 0;
            return true;
        }

        protected override Boolean TrySetCustom(ICssValue value)
        {
            return Converter.TryConvert(value, m => _index = m);
        }

        public override Boolean Validate(IWindow window)
        {
            return true;
        }

        #endregion
    }
}
