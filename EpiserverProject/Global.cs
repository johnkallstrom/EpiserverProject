using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverProject
{
    public class Global
    {
        public static readonly string LoginPath = "/util/login.aspx";
        public static readonly string AppRelativeLoginPath = string.Format("~{0}", LoginPath);

        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Specialized", Order = 1)]
            public const string Specialized = "Specialized";
        }
    }
}