namespace Blorc.OfficeUiFabric
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IRawFontStyle
    {
        string Font { get; set; }

        string FontFamily { get; set; }

        string FontKerning { get; set; }

        string FontSize { get; set; }

        string FontSizeAdjust { get; set; }

        string FontStretch { get; set; }

        string FontStyle { get; set; }

        string FontSynthesis { get; set; }

        string FontVariant { get; set; }

        string FontVariantAlternates { get; set; }

        FontWeight FontWeight { get; set; }
    }
}
