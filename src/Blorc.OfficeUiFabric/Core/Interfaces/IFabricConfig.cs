namespace Blorc.OfficeUiFabric
{
    public interface IFabricConfig
    {
        string FontBaseUrl { get; set; }

        IStyleSheetConfig MergeStyles { get; set; }
    }
}
