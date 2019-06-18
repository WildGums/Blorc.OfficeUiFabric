namespace Blorc.OfficeUiFabric
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IRawStyleBase : IRawFontStyle
    {
        string MsHighContrastAdjust { get; set; }

        string MozOsxFontSmoothing { get; set; }

        string WebkitFontSmoothing { get; set; }

        string WebkitOverflowScrolling { get; set; }

        string AlignContent { get; set; }

        string AlignItems { get; set; }

        string AlignSelf { get; set; }

        string AlignmentAdjust { get; set; }

        string AlignmentBaseline { get; set; }

        string Animation { get; set; }

        string AnimationDelay { get; set; }

        string AnimationDirection { get; set; }

        string AnimationDuration { get; set; }

        string AnimationFillMode { get; set; }

        string AnimationIterationCount { get; set; }

        string AnimationName { get; set; }

        string AnimationPlayState { get; set; }

        string AnimationTimingFunction { get; set; }

        string Appearance { get; set; }

        string BackdropFilter { get; set; }

        string WebkitBackdropFilter { get; set; }

        string BackfaceVisibility { get; set; }

        string Background { get; set; }

        string BackgroundAttachment { get; set; }

        string BackgroundBlendMode { get; set; }

        string BackgroundClip { get; set; }

        string BackgroundColor { get; set; }

        string BackgroundComposite { get; set; }

        string BackgroundImage { get; set; }

        string BackgroundOrigin { get; set; }

        string BackgroundPosition { get; set; }

        string BackgroundRepeat { get; set; }

        string BackgroundSize { get; set; }

        string Border { get; set; }

        string BorderBottom { get; set; }

        string BorderBottomColor { get; set; }

        string BorderBottomLeftRadius { get; set; }

        string BorderBottomStyle { get; set; }

        string BorderBottomWidth { get; set; }

        string BorderCollapse { get; set; }

        string BorderColor { get; set; }

        string BorderCornerShape { get; set; }

        string BorderImageSource { get; set; }

        string BorderImageWidth { get; set; }

        string BorderLeft { get; set; }

        string BorderLeftColor { get; set; }

        string BorderLeftStyle { get; set; }

        string BorderLeftWidth { get; set; }

        string BorderRadius { get; set; }

        string BorderRight { get; set; }

        string BorderRightColor { get; set; }

        string BorderRightStyle { get; set; }

        string BorderRightWidth { get; set; }

        string BorderSpacing { get; set; }

        string BorderStyle { get; set; }

        string BorderTop { get; set; }

        string BorderTopColor { get; set; }

        string BorderTopLeftRadius { get; set; }

        string BorderTopRightRadios { get; set; }

        string BorderTopStyle { get; set; }

        string BorderTopWidth { get; set; }

        string BorderWidth { get; set; }

        string Bottom { get; set; }

        string BoxDecorationBreak { get; set; }

        string BoxShadow { get; set; }

        string BoxSizing { get; set; }

        string BreakAfter { get; set; }

        string BreakBefore { get; set; }

        string BreakInside { get; set; }

        string Clear { get; set; }

        string ClipRule { get; set; }

        string Color { get; set; }

        string ColumnCount { get; set; }

        string ColumnFill { get; set; }

        string ColumnGap { get; set; }

        string ColumnRule { get; set; }

        string ColumnRuleColor { get; set; }

        string ColumnRuleWidth { get; set; }

        string ColumnSpan { get; set; }

        string ColumnWidth { get; set; }

        string Content { get; set; }

        string CounterIncrement { get; set; }

        string CounterReset { get; set; }

        string Cue { get; set; }

        string CueAfter { get; set; }

        string Cursor { get; set; }

        string Direction { get; set; }

        string Display { get; set; }

        string Fill { get; set; }

        string FillOpacity { get; set; }

        string FillRule { get; set; }

        string Filter { get; set; }

        string Flex { get; set; }

        string FlexBasis { get; set; }

        string FlexDirection { get; set; }

        string FlexFlow { get; set; }

        string FlexGrow { get; set; }

        string FlexShrink { get; set; }

        string FlexWrap { get; set; }

        string Float { get; set; }

        string FlowFrom { get; set; }

        string GridArea { get; set; }

        string GridAutoColumns { get; set; }

        string GridAutoFlow { get; set; }

        string GridAutoRows { get; set; }

        string GridColumn { get; set; }

        string GridColumnEnd { get; set; }

        string GridColumnGap { get; set; }

        string GridColumnStart { get; set; }

        string GridGap { get; set; }

        string GridRow { get; set; }

        string GridRowEnd { get; set; }

        string GridRowGap { get; set; }

        string GridRowStart { get; set; }

        string GridRowPosition { get; set; }

        string GridTemplate { get; set; }

        string GridTemplateAreas { get; set; }

        string GridTemplateColumns { get; set; }

        string GridTemplateRows { get; set; }

        string Height { get; set; }

        string HyphenateLimitChars { get; set; }

        string HyphenateLimitLines { get; set; }

        string HyphenateLimitZone { get; set; }

        string Hyphens { get; set; }

        string JustifyContent { get; set; }

        string JustifySelf { get; set; }

        string Left { get; set; }

        string LetterSpacing { get; set; }

        string LineHeight { get; set; }

        string ListStyle { get; set; }

        string ListStyleImage { get; set; }

        string ListStylePosition { get; set; }

        string ListStyleType { get; set; }

        string Margin { get; set; }

        string MarginBottom { get; set; }

        string MarginLeft { get; set; }

        string MarginRight { get; set; }

        string MarginTop { get; set; }

        string MarqueeStyle { get; set; }

        string Mask { get; set; }

        string MaskBorder { get; set; }

        string MaskBorderRepeat { get; set; }

        string MaskBorderSlice { get; set; }

        string MaskBorderSource { get; set; }

        string MaskClip { get; set; }

        string MaskOrigin { get; set; }

        string MaxFontSize { get; set; }

        string MaxHeight { get; set; }

        string MaxWidth { get; set; }

        string MinHeight { get; set; }

        string MinWidth { get; set; }

        string MixBlendMode { get; set; }

        string ObjectFit { get; set; }

        string Opacity { get; set; }

        string Order { get; set; }

        string Orphans { get; set; }

        string Outline { get; set; }

        string OutlineColor { get; set; }

        string OutlineOffset { get; set; }

        string Overflow { get; set; }

        string OverflowStyle { get; set; }

        string OverflowWrap { get; set; }

        string OverflowX { get; set; }

        string OverflowY { get; set; }

        string Padding { get; set; }

        string PaddingBlockEnd { get; set; }

        string PaddingBlockStart { get; set; }

        string PaddingLeft { get; set; }

        string PaddingBottom { get; set; }

        string PaddingInlineEnd { get; set; }

        string PaddingInlineStart { get; set; }

        string PaddingRight { get; set; }

        string PaddingTop { get; set; }

        string PaddingBreakAfter { get; set; }

        string PaddingBreakBefore { get; set; }

        string PaddingBreakInside { get; set; }

        string Pause { get; set; }

        string PauseAfter { get; set; }

        string PauseBefore { get; set; }

        string Perspective { get; set; }

        string PerspectiveOrigin { get; set; }

        string PointerEvents { get; set; }

        string Position { get; set; }

        string Quotes { get; set; }

        string RegionFragment { get; set; }

        string Resize { get; set; }

        string RestAfter { get; set; }

        string RestBefore { get; set; }

        string Right { get; set; }

        string ShapeImageThreshold { get; set; }

        string ShapeInside { get; set; }

        string ShapeMargin { get; set; }

        string ShapeOutside { get; set; }

        string Speak { get; set; }

        string SpeakAs { get; set; }

        string Stroke { get; set; }

        string StrokeLineCap { get; set; }

        string StrokeOpacity { get; set; }

        string StrokeWidth { get; set; }

        string TabSize { get; set; }

        string TableLayout { get; set; }

        string TextAlign { get; set; }

        string TextAlignLast { get; set; }

        string TextDecoration { get; set; }

        string TextDecorationColor { get; set; }

        string TextDecorationLine { get; set; }

        string TextDecorationSkip { get; set; }

        string TextDecorationStyle { get; set; }

        string TextEmphasis { get; set; }

        string TextEmphasisColor { get; set; }

        string TextEmhapsisStyle { get; set; }

        string TextHeight { get; set; }

        string TextIndent { get; set; }

        string TextOverflow { get; set; }

        string TextOverline { get; set; }

        string TextOverlineColor { get; set; }

        string TextOverlineMode { get; set; }

        string TextOverlineStyle { get; set; }

        string TextOverlineWidth { get; set; }

        string TextRendering { get; set; }

        string TextShadow { get; set; }

        string TextTransform { get; set; }

        string TextUnderlinePosition { get; set; }

        string TextUnderlineStyle { get; set; }

        string Top { get; set; }

        string TouchAction { get; set; }

        string Transform { get; set; }

        string TransformOrigin { get; set; }

        string TransformOriginZ { get; set; }

        string TransformStyle { get; set; }

        string Transition { get; set; }

        string TransitionDelay { get; set; }

        string TransitionDuration { get; set; }

        string TransitionProperty { get; set; }

        string TransitionTimingFunction { get; set; }

        string UnicodeBidi { get; set; }

        string UserFocus { get; set; }

        string UserInput { get; set; }

        string UserSelect { get; set; }

        string VerticalAlign { get; set; }

        string Visibility { get; set; }

        string VoiceBalance { get; set; }

        string VoiceDuration { get; set; }

        string VoiceFamily { get; set; }

        string VoicePitch { get; set; }

        string VoiceRange { get; set; }

        string VoiceRate { get; set; }

        string VoiceStress { get; set; }

        string VoiceVolume { get; set; }

        string WhiteSpace { get; set; }

        string Widows { get; set; }

        string Width { get; set; }

        string WordBreak { get; set; }

        string WordSpacing { get; set; }

        string WordWrap { get; set; }

        string WrapFlow { get; set; }

        string WrapMargin { get; set; }

        string WritingMode { get; set; }

        string ZIndex { get; set; }

        string Zoom { get; set; }

    }
}
