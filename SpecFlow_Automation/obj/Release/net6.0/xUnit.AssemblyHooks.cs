// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using global::System.Runtime.CompilerServices;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::SpecFlow_Automation_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.9.74")]
public class SpecFlow_Automation_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpecFlow_Automation_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(SpecFlow_Automation_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}

[global::Xunit.CollectionDefinition("SpecFlowNonParallelizableFeatures", DisableParallelization = true)]
public class SpecFlow_Automation_SpecFlowNonParallelizableFeaturesCollectionDefinition
{
}
#pragma warning restore
