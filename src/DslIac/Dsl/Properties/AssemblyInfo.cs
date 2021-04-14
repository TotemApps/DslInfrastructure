#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Variamos")]
[assembly: AssemblyProduct(@"IacTemplateGenerator")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Variamos.IacTemplateGenerator.IacLanguage.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100B5255343B3B7D6932AEF2CF1E3C850B0D0F2C03A7A58D2EC1327B02E24331B93AD454D1A1C6F3E8E6486D0D3B97515C70B8A1BE7735F4DC6DE3D4F89EAAB889F0DE5443B6ED319D323C750E31F84DB5C392F4937289630E7186065FE508BA57FC5F80960EE825F4576A8ED9629F8E41344B0B931A32384478D943AC4A804BCC4")]