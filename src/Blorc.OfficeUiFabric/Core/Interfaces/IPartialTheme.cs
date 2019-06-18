namespace Blorc.OfficeUiFabric
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IPartialTheme
    {
        bool DisableGlobalClassNames { get; set; }

        IRawStyle DefaultFontStyle { get; set; }

        IEffects Effects { get; set; }

        IFontStyles Fonts { get; set; }

        bool IsInverted { get; set; }

        IPalette Palette { get; set; }

        ISemanticColors SemanticColors { get; set; }

        ISpacing Spacing { get; set; }

        Dictionary<SchemeNames, IScheme> Schemes { get; }
    }
}
