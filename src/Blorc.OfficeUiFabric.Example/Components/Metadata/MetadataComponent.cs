namespace Blorc.OfficeUiFabric.Example.Components.Metadata
{
    using Microsoft.AspNetCore.Components;

    public class MetadataComponent : MetadataComponentBase
    {
        public MetadataComponent()
        {

        }

        [Parameter]
        public string DocumentationUrl { get; set; }

        [Parameter]
        public string SourceUrl { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            DocumentationUrl = $"https://developer.microsoft.com/en-us/fabric#/controls/web/button/{ComponentNameSlug.ToLower()}";
            //SourceUrl = $"https://github.com/patternfly/patternfly-react/tree/master/packages/patternfly-4/react-core/src/components/{ComponentNameSlug}";
        }
    }
}
