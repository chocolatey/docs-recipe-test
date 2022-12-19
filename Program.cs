using System.Globalization;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using Statiq.Markdown;
using Statiq.Common;
using Statiq.Core;

namespace Chocolatey.Docs.Cake.Recipe.Test
{
  public class Program
  {
    public static async Task<int> Main(string[] args)
    {
      CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

      return await Bootstrapper
        .Factory
        .CreateWeb(args)
        .AddSetting(Keys.Host, "chocolatey.github.io/")
        .AddSetting(Keys.LinkRoot, "docs-recipe-test")
        .AddSetting(Keys.LinksUseHttps, true)
        .RunAsync();
    }
  }
}