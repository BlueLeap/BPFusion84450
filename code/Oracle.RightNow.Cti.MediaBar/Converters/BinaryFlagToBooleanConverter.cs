// ===========================================================================================
//  Oracle RightNow Connect
//  CTI Sample Code
// ===========================================================================================
//  Copyright � Oracle Corporation.  All rights reserved.
// 
//  Sample code for training only. This sample code is provided "as is" with no warranties 
//  of any kind express or implied. Use of this sample code is pursuant to the applicable
//  non-disclosure agreement and or end user agreement and or partner agreement between
//  you and Oracle Corporation. You acknowledge Oracle Corporation is the exclusive
//  owner of the object code, source code, results, findings, ideas and any works developed
//  in using this sample code.
// ===========================================================================================
  
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Oracle.RightNow.Cti.MediaBar.Converters {
    public class BinaryFlagToBooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var flag = (int)value;
            var targetValue = (int)parameter;

            return (flag & targetValue) == targetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}