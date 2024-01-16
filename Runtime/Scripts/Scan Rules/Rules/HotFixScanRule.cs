using System.Reflection;

namespace QFSW.QC.ScanRules
{
    public class HotFixScanRule : IQcScanRule
    {
        public ScanRuleResult ShouldScan<T>(T entity) where T : ICustomAttributeProvider
        {
            if (entity is Assembly assembly)
            {
                string[] bannedPrefixes = new string[]
                {
                    "Unity.HotFix",
                };

                string assemblyFullName = assembly.FullName;
                foreach (string prefix in bannedPrefixes)
                {
                    if (!assemblyFullName.StartsWith(prefix))
                    {
                        return ScanRuleResult.Reject;
                    }
                }
            }
            return ScanRuleResult.Accept;
        }
    }
}