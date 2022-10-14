using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Helpers
{
    public static class SelectedHelper
    {
        public static string IsSelected(this IHtmlHelper htmlHelper, string option, string selectedOption)
        {
            return option.Equals(selectedOption, StringComparison.InvariantCultureIgnoreCase)
                ? "selected" : string.Empty;
        }

        public static string GetRandomText(this string s, int length)
        {
            return string.Empty;
        }
    }
}
