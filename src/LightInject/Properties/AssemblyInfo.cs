﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyTitle("LightInject")]
#if NET45
    [assembly: AssemblyProduct("LightInject (NET45)")]
#endif
#if NET46
[assembly: AssemblyProduct("LightInject (NET46)")]
#endif
#if NETSTANDARD11
    [assembly: AssemblyProduct("LightInject (NETSTANDARD11)")]
#endif
#if NETSTANDARD13
    [assembly: AssemblyProduct("LightInject (NETSTANDARD13)")]
#endif
#if NETSTANDARD16
    [assembly: AssemblyProduct("LightInject (NETSTANDARD16)")]
#endif
#if PCL_111
    [assembly: AssemblyProduct("LightInject (PCL Profile 111))")]
#endif
[assembly: AssemblyCopyright("Copyright © Bernhard Richter 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("4.0.0")]
[assembly: AssemblyFileVersion("4.0.0")]
[assembly: AssemblyInformationalVersion("4.0.0")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:FileMustHaveHeader", Justification = "Custom header.")]
