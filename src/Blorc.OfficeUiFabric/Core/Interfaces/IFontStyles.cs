namespace Blorc.OfficeUiFabric
{
    public interface IFontStyles
    {
        IRawStyle Tiny { get; set; }
        IRawStyle XSmall { get; set; }
        IRawStyle Small { get; set; }
        IRawStyle SmallPlus { get; set; }
        IRawStyle Medium { get; set; }
        IRawStyle MediumPlus { get; set; }
        IRawStyle Large { get; set; }
        IRawStyle XLarge { get; set; }
        IRawStyle XXLarge { get; set; }
        IRawStyle SuperLarge { get; set; }
        IRawStyle Mega { get; set; }
    }
}
