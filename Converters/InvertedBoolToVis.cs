﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UngdungHRM.Converters
{
    public class InvertedBoolToVis : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = bool.Parse(value.ToString());

            if (boolValue)
            {
                return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = bool.Parse(value.ToString());

            if (boolValue)
            {
                return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }
    }
}
