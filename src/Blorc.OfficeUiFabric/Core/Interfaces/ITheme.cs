namespace Blorc.OfficeUiFabric
{
    using System.Collections.Generic;

    public interface ITheme : IScheme
    {
        Dictionary<SchemeNames, IScheme> Schemes { get; }
    }
}
