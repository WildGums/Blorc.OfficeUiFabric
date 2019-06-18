namespace Blorc.OfficeUiFabric
{
    public interface IFontFace : IRawFontStyle
    {
        string Src { get; set; }

        string UnicodeRange { get; set; }

        string FontFeatureSettings { get; set; }
    }
}
