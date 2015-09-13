﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace TinyCsvParser.TypeConverter
{
    public class SingleConverter : NonNullableConverter<Single>
    {
        private readonly IFormatProvider formatProvider;
        private readonly NumberStyles numberStyles;

        public SingleConverter()
            : this(CultureInfo.InvariantCulture)
        {
        }

        public SingleConverter(IFormatProvider formatProvider)
            : this(formatProvider, NumberStyles.None)
        {
        }

        public SingleConverter(IFormatProvider formatProvider, NumberStyles numberStyles)
        {
            this.formatProvider = formatProvider;
            this.numberStyles = numberStyles;
        }

        protected override Single InternalConvert(string value)
        {
            return Single.Parse(value, numberStyles, formatProvider);
        }
    }
}