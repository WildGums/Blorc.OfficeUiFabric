namespace Blorc.OfficeUiFabric
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IScheme
    {
        bool DisableGlobalClassNames { get; set; }

        IEffects Effects { get; set; }

        IFontStyles Fonts { get; set; }

        bool IsInverted { get; set; }

        IPalette Palette { get; set; }

        ISemanticColors SemanticColors { get; set; }
    }
}
