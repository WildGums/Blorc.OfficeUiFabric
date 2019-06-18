namespace Blorc.OfficeUiFabric
{
    using System.Collections.Generic;

    public interface IRawStyle
    {
        string DisplayName { get; set; }

        Dictionary<string, IStyle> Selectors { get; }
    }
}
