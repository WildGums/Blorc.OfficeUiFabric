namespace Blorc.OfficeUiFabric
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ISemanticColors : ISemanticTextColors
    {
        string AccentButtonBackground { get; set; }

        string BlockingBackground { get; set; }

        string BodyBackground { get; set; }

        string BodyDivider { get; set; }

        string BodyFrameBackground { get; set; }

        string BodyFrameDivider { get; set; }

        string BodyStandoutBackground { get; set; }

        string ButtonBackground { get; set; }

        string ButtonBackgroundChecked { get; set; }

        string ButtonBackgroundCheckedHovered { get; set; }

        string ButtonBackgroundDisabled { get; set; }

        string ButtonBackgroundHovered { get; set; }

        string ButtonBackgroundPressed { get; set; }

        string ButtonBorder { get; set; }

        string ButtonBorderDisabled { get; set; }

        string DefaultStateBackground { get; set; }

        string DisabledBackground { get; set; }

        string ErrorBackground { get; set; }

        string FocusBorder { get; set; }

        string InputBackground { get; set; }

        string InputBackgroundChecked { get; set; }

        string InputBackgroundCheckedHovered { get; set; }

        string InputBorder { get; set; }

        string InputBorderHovered { get; set; }

        string InputFocusBorderAlt { get; set; }

        string InputForegroundChecked { get; set; }

        string ListBackground { get; set; }

        string ListHeaderBackgroundHovered { get; set; }

        string ListHeaderBackgroundPressed { get; set; }

        string ListItemBackgroundChecked { get; set; }

        string ListItemBackgroundCheckedHovered { get; set; }

        string ListItemBackgroundHovered { get; set; }

        string MenuBackground { get; set; }

        string MenuDivider { get; set; }

        string MenuHeader { get; set; }

        string MenuIcon { get; set; }

        string MenuItemBackgroundHovered { get; set; }

        string MenuItemBackgroundPressed { get; set; }

        string MenuItemText { get; set; }

        string MenuItemTextHovered { get; set; }

        string PrimaryButtonBackground { get; set; }

        string PrimaryButtonBackgroundDisabled { get; set; }

        string PrimaryButtonBackgroundHovered { get; set; }

        string PrimaryButtonBackgroundPressed { get; set; }

        string PrimaryButtonBorder { get; set; }

        string SmallInputBorder { get; set; }

        string SuccessBackground { get; set; }

        string VariantBorder { get; set; }

        string VariantBorderHovered { get; set; }

        string WarningBackground { get; set; }

        string WarningHighlight { get; set; }
    }
}
