namespace Blorc.OfficeUiFabric.Example.Components.Todo
{
    using Microsoft.AspNetCore.Components;

    public class TodoComponent : MetadataComponentBase
    {
        [Parameter]
        public RenderFragment TodoList { get; set; }
    }
}
