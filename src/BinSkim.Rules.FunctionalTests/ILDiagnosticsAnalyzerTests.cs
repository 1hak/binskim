﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

using FluentAssertions;
using Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.CodeAnalysis.IL
{
    public class ILDiagnosticsAnalyzerTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ILDiagnosticsAnalyzerTests(ITestOutputHelper output)
        {
            _testOutputHelper = output;
        }

        private void Verify(string analyzerPath, IEnumerable<string> expectedMessages, params string[] assemblyPaths)
        {
            var actualMessages = new List<string>();
            var analyzer = ILDiagnosticsAnalyzer.Create(this.GetType().Assembly.Location);

            foreach (string assemblyPath in assemblyPaths)
            {
                analyzer.Analyze(assemblyPath, (d) => actualMessages.Add(d.GetMessage()));
            }

            try
            {
                actualMessages.ShouldBeEquivalentTo(expectedMessages);
            }
            catch
            {
                _testOutputHelper.WriteLine("Expected messages:");
                foreach (string message in expectedMessages) { _testOutputHelper.WriteLine("\"" + message + "\","); }

                _testOutputHelper.WriteLine("Actual messages:");
                foreach (string message in actualMessages) { _testOutputHelper.WriteLine("\"" + message + "\","); }

                throw;
            }
        }

        [Fact]
        public void RunSymbolNameAndRoslynCallbackReportingsAnalyzers()
        {
            // This is not a particularly desirable verification mechanism but for now it 
            // ensures (in a fragile way) that analysis is visiting all expected symbols 
            // and that we see an appropriate set of callbacks within the test analyzer.
            // To update this test data (in the event that new types are added or removed
            // from analysis targets), 1) click 'Output' in the failed test result, 
            // 2) Right-click output and select 'Copy All', 3) copy test results into
            // notepad and select the list of actually observed strings. Test output is
            // formatted to permit it to easily be pasted into the declaration below.
            var expected = new List<string>(new string[] {
                "Symbol encountered in MSIL 'global::<Module>'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.ILDiagnosticsAnalyzerTests.<>c__DisplayClass2_0'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.ILDiagnosticsAnalyzerTests'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.RoslynAnalysisContextTests.<>c__DisplayClass0_0'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.RoslynAnalysisContextTests'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.RoslynCompilationStartAnalysisContextTests.<>c__DisplayClass0_0'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.RoslynCompilationStartAnalysisContextTests'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.ExceptionCondition'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.RuleTests'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.SarifHelpers'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.TestMessageLogger'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.TestRoslynAnalyzer.<>c'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.Rules.TestRoslynAnalyzer'",
                "Roslyn 'RegisterCompilationAction' callback invoked analyzing 'BinSkim.Rules.FunctionalTests.dll'",
                "Roslyn 'RegisterCompilationEndAction' callback invoked analyzing 'BinSkim.Rules.FunctionalTests.dll'",
                "Symbol encountered in MSIL 'global::<Module>'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryData.BinaryParsersResources'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.Packer'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PdbParseErrorCode'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageLoadConfigDirectory64.Fields'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageLoadConfigDirectory64'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.Type'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageHeader'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageFieldData'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageLoadConfigDirectory32.Fields'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.ImageLoadConfigDirectory32'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.PortableExecutableExtensionMethods'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.PE'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable.SafePointer'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.CompilandRecord'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.CompilerCommandLine.WarningState'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.CompilerCommandLine'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.Pdb.<CreateSourceFileIteratorImpl>d__21'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.Pdb'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.PdbParseException'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.ObjectModuleDetails'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.Language'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.WellKnownCompilers'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.SourceFile'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.HashType'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.Symbol.<CreateChildrenImpl>d__52'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.Symbol'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.LocationType'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.DataKind'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.NameSearchOptions'",
#if DEBUG
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.TruncatedCompilandRecordList.<>c'",
#endif
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.BinaryParsers.ProgramDatabase.TruncatedCompilandRecordList'",
                "Symbol encountered in MSIL 'global::Microsoft.CodeAnalysis.IL.VersionConstants'",
                "Roslyn 'RegisterCompilationAction' callback invoked analyzing 'BinaryParsers.dll'",
                "Roslyn 'RegisterCompilationEndAction' callback invoked analyzing 'BinaryParsers.dll'",            });
            string testAssemblyPath = this.GetType().Assembly.Location;
            string binskimBinaryPath = typeof(PE).Assembly.Location;
            Verify(testAssemblyPath, expected, testAssemblyPath, binskimBinaryPath);
        }
    }
}
