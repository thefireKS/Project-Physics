/*==============================================================================
Copyright (c) 2018 PTC Inc. All Rights Reserved.

All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using System.Globalization;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class LogCultureInfo 
{
    static LogCultureInfo()
    {
        Debug.LogFormat("Current CultureInfo is '{0}'", CultureInfo.CurrentCulture.Name);
        Debug.LogFormat("Current NumberDecimalSeparator is '{0}'", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
    }
}
