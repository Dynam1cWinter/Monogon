//    var welcome = Welcome.FromJson(jsonString);

using System.Text.Json;

namespace Monogon.Engine
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LDTKSupport
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("$schema")]
        public Uri Schema { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("LdtkJsonRoot")]
        public LdtkJsonRoot LdtkJsonRoot { get; set; }

        [JsonProperty("otherTypes")]
        public OtherTypes OtherTypes { get; set; }
    }

    public partial class LdtkJsonRoot
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> LdtkJsonRootRequired { get; set; }

        [JsonProperty("properties")]
        public LdtkJsonRootProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class LdtkJsonRootProperties
    {
        [JsonProperty("backupLimit")]
        public AppBuildId BackupLimit { get; set; }

        [JsonProperty("defaultEntityWidth")]
        public AppBuildId DefaultEntityWidth { get; set; }

        [JsonProperty("backupOnSave")]
        public AppBuildId BackupOnSave { get; set; }

        [JsonProperty("worldGridWidth")]
        public AppBuildId WorldGridWidth { get; set; }

        [JsonProperty("iid")]
        public AppBuildId Iid { get; set; }

        [JsonProperty("defaultLevelBgColor")]
        public AppBuildId DefaultLevelBgColor { get; set; }

        [JsonProperty("bgColor")]
        public AppBuildId BgColor { get; set; }

        [JsonProperty("worlds")]
        public CustomCommands Worlds { get; set; }

        [JsonProperty("toc")]
        public CustomCommands Toc { get; set; }

        [JsonProperty("nextUid")]
        public AppBuildId NextUid { get; set; }

        [JsonProperty("imageExportMode")]
        public IdentifierStyle ImageExportMode { get; set; }

        [JsonProperty("identifierStyle")]
        public IdentifierStyle IdentifierStyle { get; set; }

        [JsonProperty("defaultPivotY")]
        public AppBuildId DefaultPivotY { get; set; }

        [JsonProperty("dummyWorldIid")]
        public AppBuildId DummyWorldIid { get; set; }

        [JsonProperty("customCommands")]
        public CustomCommands CustomCommands { get; set; }

        [JsonProperty("worldGridHeight")]
        public AppBuildId WorldGridHeight { get; set; }

        [JsonProperty("appBuildId")]
        public AppBuildId AppBuildId { get; set; }

        [JsonProperty("defaultGridSize")]
        public AppBuildId DefaultGridSize { get; set; }

        [JsonProperty("worldLayout")]
        public WorldLayout WorldLayout { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }

        [JsonProperty("levelNamePattern")]
        public AppBuildId LevelNamePattern { get; set; }

        [JsonProperty("exportPng")]
        public AppBuildId ExportPng { get; set; }

        [JsonProperty("defaultLevelWidth")]
        public AppBuildId DefaultLevelWidth { get; set; }

        [JsonProperty("pngFilePattern")]
        public AppBuildId PngFilePattern { get; set; }

        [JsonProperty("__FORCED_REFS")]
        public ForcedRefs ForcedRefs { get; set; }

        [JsonProperty("exportTiled")]
        public AppBuildId ExportTiled { get; set; }

        [JsonProperty("defs")]
        public Defs Defs { get; set; }

        [JsonProperty("levels")]
        public CustomCommands Levels { get; set; }

        [JsonProperty("jsonVersion")]
        public AppBuildId JsonVersion { get; set; }

        [JsonProperty("defaultEntityHeight")]
        public AppBuildId DefaultEntityHeight { get; set; }

        [JsonProperty("defaultPivotX")]
        public AppBuildId DefaultPivotX { get; set; }

        [JsonProperty("defaultLevelHeight")]
        public AppBuildId DefaultLevelHeight { get; set; }

        [JsonProperty("simplifiedExport")]
        public AppBuildId SimplifiedExport { get; set; }

        [JsonProperty("externalLevels")]
        public AppBuildId ExternalLevels { get; set; }

        [JsonProperty("tutorialDesc")]
        public AppBuildId TutorialDesc { get; set; }

        [JsonProperty("minifyJson")]
        public AppBuildId MinifyJson { get; set; }

        [JsonProperty("exportLevelBg")]
        public AppBuildId ExportLevelBg { get; set; }

        [JsonProperty("backupRelPath")]
        public AppBuildId BackupRelPath { get; set; }
    }

    public partial class AppBuildId
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class CustomCommands
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public ItemsValue Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class ItemsValue
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public partial class Defs
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

    public partial class Flags
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public FlagsItems Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class FlagsItems
    {
        [JsonProperty("enum")]
        public List<string> Enum { get; set; }
    }

    public partial class ForcedRefs
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, ItemsValue> Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class IdentifierStyle
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enum")]
        public List<string> Enum { get; set; }
    }

    public partial class WorldLayout
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enum")]
        public List<string> Enum { get; set; }
    }

    public partial class OtherTypes
    {
        [JsonProperty("TilesetRect")]
        public TilesetRect TilesetRect { get; set; }

        [JsonProperty("FieldInstance")]
        public FieldInstance FieldInstance { get; set; }

        [JsonProperty("EntityInstance")]
        public EntityInstance EntityInstance { get; set; }

        [JsonProperty("Definitions")]
        public Definitions Definitions { get; set; }

        [JsonProperty("EnumTagValue")]
        public EnumTagValue EnumTagValue { get; set; }

        [JsonProperty("AutoRuleDef")]
        public AutoRuleDef AutoRuleDef { get; set; }

        [JsonProperty("FieldDef")]
        public FieldDef FieldDef { get; set; }

        [JsonProperty("CustomCommand")]
        public CustomCommand CustomCommand { get; set; }

        [JsonProperty("EntityDef")]
        public EntityDef EntityDef { get; set; }

        [JsonProperty("AutoLayerRuleGroup")]
        public AutoLayerRuleGroup AutoLayerRuleGroup { get; set; }

        [JsonProperty("IntGridValueGroupDef")]
        public IntGridValueGroupDef IntGridValueGroupDef { get; set; }

        [JsonProperty("IntGridValueInstance")]
        public IntGridValueInstance IntGridValueInstance { get; set; }

        [JsonProperty("TocInstanceData")]
        public TocInstanceData TocInstanceData { get; set; }

        [JsonProperty("NeighbourLevel")]
        public NeighbourLevel NeighbourLevel { get; set; }

        [JsonProperty("LayerInstance")]
        public LayerInstance LayerInstance { get; set; }

        [JsonProperty("World")]
        public World World { get; set; }

        [JsonProperty("EntityReferenceInfos")]
        public EntityReferenceInfos EntityReferenceInfos { get; set; }

        [JsonProperty("TileCustomMetadata")]
        public TileCustomMetadata TileCustomMetadata { get; set; }

        [JsonProperty("TilesetDef")]
        public TilesetDef TilesetDef { get; set; }

        [JsonProperty("EnumDefValues")]
        public EnumDefValues EnumDefValues { get; set; }

        [JsonProperty("Tile")]
        public Tile Tile { get; set; }

        [JsonProperty("LayerDef")]
        public LayerDef LayerDef { get; set; }

        [JsonProperty("LevelBgPosInfos")]
        public LevelBgPosInfos LevelBgPosInfos { get; set; }

        [JsonProperty("Level")]
        public Level Level { get; set; }

        [JsonProperty("TableOfContentEntry")]
        public TableOfContentEntry TableOfContentEntry { get; set; }

        [JsonProperty("EnumDef")]
        public EnumDef EnumDef { get; set; }

        [JsonProperty("GridPoint")]
        public GridPoint GridPoint { get; set; }

        [JsonProperty("IntGridValueDef")]
        public IntGridValueDef IntGridValueDef { get; set; }
    }

    public partial class AutoLayerRuleGroup
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> AutoLayerRuleGroupRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public AutoLayerRuleGroupProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class AutoLayerRuleGroupProperties
    {
        [JsonProperty("name")]
        public AppBuildId Name { get; set; }

        [JsonProperty("collapsed")]
        public AppBuildId Collapsed { get; set; }

        [JsonProperty("biomeRequirementMode")]
        public AppBuildId BiomeRequirementMode { get; set; }

        [JsonProperty("color")]
        public AppBuildId Color { get; set; }

        [JsonProperty("isOptional")]
        public AppBuildId IsOptional { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("usesWizard")]
        public AppBuildId UsesWizard { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("requiredBiomeValues")]
        public RequiredBiomeValues RequiredBiomeValues { get; set; }

        [JsonProperty("active")]
        public AppBuildId Active { get; set; }

        [JsonProperty("rules")]
        public CustomCommands Rules { get; set; }
    }

    public partial class Icon
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("oneOf")]
        public List<OneOf> OneOf { get; set; }
    }

    public partial class OneOf
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<ForcedRefsType> Type { get; set; }

        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }
    }

    public partial class RequiredBiomeValues
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public RequiredBiomeValuesItems Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class RequiredBiomeValuesItems
    {
        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class AutoRuleDef
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> AutoRuleDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public AutoRuleDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class AutoRuleDefProperties
    {
        [JsonProperty("flipX")]
        public AppBuildId FlipX { get; set; }

        [JsonProperty("pivotX")]
        public AppBuildId PivotX { get; set; }

        [JsonProperty("perlinActive")]
        public AppBuildId PerlinActive { get; set; }

        [JsonProperty("tileRectsIds")]
        public TileRectsIds TileRectsIds { get; set; }

        [JsonProperty("perlinScale")]
        public AppBuildId PerlinScale { get; set; }

        [JsonProperty("outOfBoundsValue")]
        public AppBuildId OutOfBoundsValue { get; set; }

        [JsonProperty("pattern")]
        public RequiredBiomeValues Pattern { get; set; }

        [JsonProperty("tileRandomXMin")]
        public AppBuildId TileRandomXMin { get; set; }

        [JsonProperty("checker")]
        public IdentifierStyle Checker { get; set; }

        [JsonProperty("perlinOctaves")]
        public AppBuildId PerlinOctaves { get; set; }

        [JsonProperty("tileIds")]
        public RequiredBiomeValues TileIds { get; set; }

        [JsonProperty("alpha")]
        public AppBuildId Alpha { get; set; }

        [JsonProperty("tileXOffset")]
        public AppBuildId TileXOffset { get; set; }

        [JsonProperty("invalidated")]
        public AppBuildId Invalidated { get; set; }

        [JsonProperty("xModulo")]
        public AppBuildId XModulo { get; set; }

        [JsonProperty("size")]
        public AppBuildId Size { get; set; }

        [JsonProperty("chance")]
        public AppBuildId Chance { get; set; }

        [JsonProperty("breakOnMatch")]
        public AppBuildId BreakOnMatch { get; set; }

        [JsonProperty("tileYOffset")]
        public AppBuildId TileYOffset { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("perlinSeed")]
        public AppBuildId PerlinSeed { get; set; }

        [JsonProperty("yOffset")]
        public AppBuildId YOffset { get; set; }

        [JsonProperty("tileRandomYMax")]
        public AppBuildId TileRandomYMax { get; set; }

        [JsonProperty("tileRandomYMin")]
        public AppBuildId TileRandomYMin { get; set; }

        [JsonProperty("tileMode")]
        public IdentifierStyle TileMode { get; set; }

        [JsonProperty("flipY")]
        public AppBuildId FlipY { get; set; }

        [JsonProperty("tileRandomXMax")]
        public AppBuildId TileRandomXMax { get; set; }

        [JsonProperty("pivotY")]
        public AppBuildId PivotY { get; set; }

        [JsonProperty("yModulo")]
        public AppBuildId YModulo { get; set; }

        [JsonProperty("active")]
        public AppBuildId Active { get; set; }

        [JsonProperty("xOffset")]
        public AppBuildId XOffset { get; set; }
    }

    public partial class TileRectsIds
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public TileRectsIdsItems Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class TileRectsIdsItems
    {
        [JsonProperty("items")]
        public RequiredBiomeValuesItems Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class CustomCommand
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> CustomCommandRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public CustomCommandProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class CustomCommandProperties
    {
        [JsonProperty("when")]
        public IdentifierStyle When { get; set; }

        [JsonProperty("command")]
        public AppBuildId Command { get; set; }
    }

    public partial class Definitions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> DefinitionsRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public DefinitionsProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class DefinitionsProperties
    {
        [JsonProperty("tilesets")]
        public CustomCommands Tilesets { get; set; }

        [JsonProperty("layers")]
        public CustomCommands Layers { get; set; }

        [JsonProperty("levelFields")]
        public CustomCommands LevelFields { get; set; }

        [JsonProperty("enums")]
        public CustomCommands Enums { get; set; }

        [JsonProperty("entities")]
        public CustomCommands Entities { get; set; }

        [JsonProperty("externalEnums")]
        public CustomCommands ExternalEnums { get; set; }
    }

    public partial class EntityDef
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EntityDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EntityDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EntityDefProperties
    {
        [JsonProperty("tileId")]
        public AppBuildId TileId { get; set; }

        [JsonProperty("showName")]
        public AppBuildId ShowName { get; set; }

        [JsonProperty("tilesetId")]
        public AppBuildId TilesetId { get; set; }

        [JsonProperty("maxHeight")]
        public AppBuildId MaxHeight { get; set; }

        [JsonProperty("limitScope")]
        public IdentifierStyle LimitScope { get; set; }

        [JsonProperty("pivotX")]
        public AppBuildId PivotX { get; set; }

        [JsonProperty("maxCount")]
        public AppBuildId MaxCount { get; set; }

        [JsonProperty("allowOutOfBounds")]
        public AppBuildId AllowOutOfBounds { get; set; }

        [JsonProperty("hollow")]
        public AppBuildId Hollow { get; set; }

        [JsonProperty("minHeight")]
        public AppBuildId MinHeight { get; set; }

        [JsonProperty("keepAspectRatio")]
        public AppBuildId KeepAspectRatio { get; set; }

        [JsonProperty("color")]
        public AppBuildId Color { get; set; }

        [JsonProperty("minWidth")]
        public AppBuildId MinWidth { get; set; }

        [JsonProperty("tileRect")]
        public Icon TileRect { get; set; }

        [JsonProperty("doc")]
        public AppBuildId Doc { get; set; }

        [JsonProperty("fieldDefs")]
        public CustomCommands FieldDefs { get; set; }

        [JsonProperty("tileRenderMode")]
        public IdentifierStyle TileRenderMode { get; set; }

        [JsonProperty("limitBehavior")]
        public IdentifierStyle LimitBehavior { get; set; }

        [JsonProperty("tileOpacity")]
        public AppBuildId TileOpacity { get; set; }

        [JsonProperty("nineSliceBorders")]
        public RequiredBiomeValues NineSliceBorders { get; set; }

        [JsonProperty("resizableX")]
        public AppBuildId ResizableX { get; set; }

        [JsonProperty("uiTileRect")]
        public Icon UiTileRect { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("lineOpacity")]
        public AppBuildId LineOpacity { get; set; }

        [JsonProperty("maxWidth")]
        public AppBuildId MaxWidth { get; set; }

        [JsonProperty("resizableY")]
        public AppBuildId ResizableY { get; set; }

        [JsonProperty("exportToToc")]
        public AppBuildId ExportToToc { get; set; }

        [JsonProperty("fillOpacity")]
        public AppBuildId FillOpacity { get; set; }

        [JsonProperty("height")]
        public AppBuildId Height { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("pivotY")]
        public AppBuildId PivotY { get; set; }

        [JsonProperty("renderMode")]
        public IdentifierStyle RenderMode { get; set; }

        [JsonProperty("tags")]
        public RequiredBiomeValues Tags { get; set; }

        [JsonProperty("width")]
        public AppBuildId Width { get; set; }
    }

    public partial class EntityInstance
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EntityInstanceRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EntityInstanceProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EntityInstanceProperties
    {
        [JsonProperty("iid")]
        public AppBuildId Iid { get; set; }

        [JsonProperty("defUid")]
        public AppBuildId DefUid { get; set; }

        [JsonProperty("__identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("__tile")]
        public Icon Tile { get; set; }

        [JsonProperty("px")]
        public RequiredBiomeValues Px { get; set; }

        [JsonProperty("__worldX")]
        public AppBuildId WorldX { get; set; }

        [JsonProperty("__worldY")]
        public AppBuildId WorldY { get; set; }

        [JsonProperty("__smartColor")]
        public AppBuildId SmartColor { get; set; }

        [JsonProperty("__grid")]
        public RequiredBiomeValues Grid { get; set; }

        [JsonProperty("__pivot")]
        public RequiredBiomeValues Pivot { get; set; }

        [JsonProperty("fieldInstances")]
        public CustomCommands FieldInstances { get; set; }

        [JsonProperty("height")]
        public AppBuildId Height { get; set; }

        [JsonProperty("__tags")]
        public RequiredBiomeValues Tags { get; set; }

        [JsonProperty("width")]
        public AppBuildId Width { get; set; }
    }

    public partial class EntityReferenceInfos
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EntityReferenceInfosRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EntityReferenceInfosProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EntityReferenceInfosProperties
    {
        [JsonProperty("worldIid")]
        public AppBuildId WorldIid { get; set; }

        [JsonProperty("entityIid")]
        public AppBuildId EntityIid { get; set; }

        [JsonProperty("layerIid")]
        public AppBuildId LayerIid { get; set; }

        [JsonProperty("levelIid")]
        public AppBuildId LevelIid { get; set; }
    }

    public partial class EnumDef
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EnumDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EnumDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EnumDefProperties
    {
        [JsonProperty("externalFileChecksum")]
        public AppBuildId ExternalFileChecksum { get; set; }

        [JsonProperty("externalRelPath")]
        public AppBuildId ExternalRelPath { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("values")]
        public CustomCommands Values { get; set; }

        [JsonProperty("iconTilesetUid")]
        public AppBuildId IconTilesetUid { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("tags")]
        public RequiredBiomeValues Tags { get; set; }
    }

    public partial class EnumDefValues
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EnumDefValuesRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EnumDefValuesProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EnumDefValuesProperties
    {
        [JsonProperty("tileId")]
        public AppBuildId TileId { get; set; }

        [JsonProperty("color")]
        public AppBuildId Color { get; set; }

        [JsonProperty("tileRect")]
        public Icon TileRect { get; set; }

        [JsonProperty("id")]
        public AppBuildId Id { get; set; }

        [JsonProperty("__tileSrcRect")]
        public RequiredBiomeValues TileSrcRect { get; set; }
    }

    public partial class EnumTagValue
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> EnumTagValueRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public EnumTagValueProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class EnumTagValueProperties
    {
        [JsonProperty("tileIds")]
        public RequiredBiomeValues TileIds { get; set; }

        [JsonProperty("enumValueId")]
        public AppBuildId EnumValueId { get; set; }
    }

    public partial class FieldDef
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> FieldDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public FieldDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class FieldDefProperties
    {
        [JsonProperty("acceptFileTypes")]
        public RequiredBiomeValues AcceptFileTypes { get; set; }

        [JsonProperty("editorDisplayScale")]
        public AppBuildId EditorDisplayScale { get; set; }

        [JsonProperty("searchable")]
        public AppBuildId Searchable { get; set; }

        [JsonProperty("useForSmartColor")]
        public AppBuildId UseForSmartColor { get; set; }

        [JsonProperty("editorShowInWorld")]
        public AppBuildId EditorShowInWorld { get; set; }

        [JsonProperty("allowedRefs")]
        public IdentifierStyle AllowedRefs { get; set; }

        [JsonProperty("editorAlwaysShow")]
        public AppBuildId EditorAlwaysShow { get; set; }

        [JsonProperty("arrayMinLength")]
        public AppBuildId ArrayMinLength { get; set; }

        [JsonProperty("editorTextSuffix")]
        public AppBuildId EditorTextSuffix { get; set; }

        [JsonProperty("min")]
        public AppBuildId Min { get; set; }

        [JsonProperty("__type")]
        public AppBuildId Type { get; set; }

        [JsonProperty("editorDisplayMode")]
        public IdentifierStyle EditorDisplayMode { get; set; }

        [JsonProperty("editorDisplayColor")]
        public AppBuildId EditorDisplayColor { get; set; }

        [JsonProperty("canBeNull")]
        public AppBuildId CanBeNull { get; set; }

        [JsonProperty("autoChainRef")]
        public AppBuildId AutoChainRef { get; set; }

        [JsonProperty("doc")]
        public AppBuildId Doc { get; set; }

        [JsonProperty("allowedRefsEntityUid")]
        public AppBuildId AllowedRefsEntityUid { get; set; }

        [JsonProperty("tilesetUid")]
        public AppBuildId TilesetUid { get; set; }

        [JsonProperty("allowedRefTags")]
        public RequiredBiomeValues AllowedRefTags { get; set; }

        [JsonProperty("symmetricalRef")]
        public AppBuildId SymmetricalRef { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("editorTextPrefix")]
        public AppBuildId EditorTextPrefix { get; set; }

        [JsonProperty("isArray")]
        public AppBuildId IsArray { get; set; }

        [JsonProperty("exportToToc")]
        public AppBuildId ExportToToc { get; set; }

        [JsonProperty("editorDisplayPos")]
        public IdentifierStyle EditorDisplayPos { get; set; }

        [JsonProperty("textLanguageMode")]
        public WorldLayout TextLanguageMode { get; set; }

        [JsonProperty("max")]
        public AppBuildId Max { get; set; }

        [JsonProperty("allowOutOfLevelRef")]
        public AppBuildId AllowOutOfLevelRef { get; set; }

        [JsonProperty("editorCutLongValues")]
        public AppBuildId EditorCutLongValues { get; set; }

        [JsonProperty("defaultOverride")]
        public DefaultOverride DefaultOverride { get; set; }

        [JsonProperty("editorLinkStyle")]
        public IdentifierStyle EditorLinkStyle { get; set; }

        [JsonProperty("regex")]
        public AppBuildId Regex { get; set; }

        [JsonProperty("type")]
        public AppBuildId PropertiesType { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("arrayMaxLength")]
        public AppBuildId ArrayMaxLength { get; set; }
    }

    public partial class DefaultOverride
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class FieldInstance
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> FieldInstanceRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public FieldInstanceProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class FieldInstanceProperties
    {
        [JsonProperty("__type")]
        public AppBuildId Type { get; set; }

        [JsonProperty("defUid")]
        public AppBuildId DefUid { get; set; }

        [JsonProperty("__identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("__tile")]
        public Icon Tile { get; set; }

        [JsonProperty("realEditorValues")]
        public RealEditorValues RealEditorValues { get; set; }

        [JsonProperty("__value")]
        public DefaultOverride Value { get; set; }
    }

    public partial class RealEditorValues
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public RealEditorValuesItems Items { get; set; }

        [JsonProperty("type")]
        public List<CustomCommandsType> Type { get; set; }
    }

    public partial class RealEditorValuesItems
    {
    }

    public partial class GridPoint
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> GridPointRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public GridPointProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class GridPointProperties
    {
        [JsonProperty("cy")]
        public AppBuildId Cy { get; set; }

        [JsonProperty("cx")]
        public AppBuildId Cx { get; set; }
    }

    public partial class IntGridValueDef
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> IntGridValueDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public IntGridValueDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class IntGridValueDefProperties
    {
        [JsonProperty("tile")]
        public Icon Tile { get; set; }

        [JsonProperty("color")]
        public AppBuildId Color { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("value")]
        public AppBuildId Value { get; set; }

        [JsonProperty("groupUid")]
        public AppBuildId GroupUid { get; set; }
    }

    public partial class IntGridValueGroupDef
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> IntGridValueGroupDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public IntGridValueGroupDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class IntGridValueGroupDefProperties
    {
        [JsonProperty("color")]
        public AppBuildId Color { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }
    }

    public partial class IntGridValueInstance
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> IntGridValueInstanceRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public IntGridValueInstanceProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class IntGridValueInstanceProperties
    {
        [JsonProperty("v")]
        public AppBuildId V { get; set; }

        [JsonProperty("coordId")]
        public AppBuildId CoordId { get; set; }
    }

    public partial class LayerDef
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> LayerDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public LayerDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class LayerDefProperties
    {
        [JsonProperty("pxOffsetX")]
        public AppBuildId PxOffsetX { get; set; }

        [JsonProperty("tilePivotX")]
        public AppBuildId TilePivotX { get; set; }

        [JsonProperty("uiFilterTags")]
        public RequiredBiomeValues UiFilterTags { get; set; }

        [JsonProperty("displayOpacity")]
        public AppBuildId DisplayOpacity { get; set; }

        [JsonProperty("parallaxFactorY")]
        public AppBuildId ParallaxFactorY { get; set; }

        [JsonProperty("hideInList")]
        public AppBuildId HideInList { get; set; }

        [JsonProperty("__type")]
        public AppBuildId Type { get; set; }

        [JsonProperty("guideGridHei")]
        public AppBuildId GuideGridHei { get; set; }

        [JsonProperty("uiColor")]
        public AppBuildId UiColor { get; set; }

        [JsonProperty("doc")]
        public AppBuildId Doc { get; set; }

        [JsonProperty("tilesetDefUid")]
        public AppBuildId TilesetDefUid { get; set; }

        [JsonProperty("canSelectWhenInactive")]
        public AppBuildId CanSelectWhenInactive { get; set; }

        [JsonProperty("useAsyncRender")]
        public AppBuildId UseAsyncRender { get; set; }

        [JsonProperty("autoSourceLayerDefUid")]
        public AppBuildId AutoSourceLayerDefUid { get; set; }

        [JsonProperty("autoTilesetDefUid")]
        public AppBuildId AutoTilesetDefUid { get; set; }

        [JsonProperty("parallaxScaling")]
        public AppBuildId ParallaxScaling { get; set; }

        [JsonProperty("renderInWorldView")]
        public AppBuildId RenderInWorldView { get; set; }

        [JsonProperty("intGridValuesGroups")]
        public CustomCommands IntGridValuesGroups { get; set; }

        [JsonProperty("inactiveOpacity")]
        public AppBuildId InactiveOpacity { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("excludedTags")]
        public RequiredBiomeValues ExcludedTags { get; set; }

        [JsonProperty("hideFieldsWhenInactive")]
        public AppBuildId HideFieldsWhenInactive { get; set; }

        [JsonProperty("intGridValues")]
        public CustomCommands IntGridValues { get; set; }

        [JsonProperty("autoRuleGroups")]
        public CustomCommands AutoRuleGroups { get; set; }

        [JsonProperty("type")]
        public IdentifierStyle PropertiesType { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("guideGridWid")]
        public AppBuildId GuideGridWid { get; set; }

        [JsonProperty("requiredTags")]
        public RequiredBiomeValues RequiredTags { get; set; }

        [JsonProperty("pxOffsetY")]
        public AppBuildId PxOffsetY { get; set; }

        [JsonProperty("tilePivotY")]
        public AppBuildId TilePivotY { get; set; }

        [JsonProperty("biomeFieldUid")]
        public AppBuildId BiomeFieldUid { get; set; }

        [JsonProperty("gridSize")]
        public AppBuildId GridSize { get; set; }

        [JsonProperty("parallaxFactorX")]
        public AppBuildId ParallaxFactorX { get; set; }

        [JsonProperty("autoTilesKilledByOtherLayerUid")]
        public AppBuildId AutoTilesKilledByOtherLayerUid { get; set; }
    }

    public partial class LayerInstance
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> LayerInstanceRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public LayerInstanceProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class LayerInstanceProperties
    {
        [JsonProperty("__cHei")]
        public AppBuildId CHei { get; set; }

        [JsonProperty("pxOffsetX")]
        public AppBuildId PxOffsetX { get; set; }

        [JsonProperty("__tilesetRelPath")]
        public AppBuildId TilesetRelPath { get; set; }

        [JsonProperty("iid")]
        public AppBuildId Iid { get; set; }

        [JsonProperty("levelId")]
        public AppBuildId LevelId { get; set; }

        [JsonProperty("__type")]
        public AppBuildId Type { get; set; }

        [JsonProperty("autoLayerTiles")]
        public CustomCommands AutoLayerTiles { get; set; }

        [JsonProperty("optionalRules")]
        public RequiredBiomeValues OptionalRules { get; set; }

        [JsonProperty("__identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("__gridSize")]
        public AppBuildId GridSize { get; set; }

        [JsonProperty("__pxTotalOffsetY")]
        public AppBuildId PxTotalOffsetY { get; set; }

        [JsonProperty("intGridCsv")]
        public RequiredBiomeValues IntGridCsv { get; set; }

        [JsonProperty("overrideTilesetUid")]
        public AppBuildId OverrideTilesetUid { get; set; }

        [JsonProperty("visible")]
        public AppBuildId Visible { get; set; }

        [JsonProperty("entityInstances")]
        public CustomCommands EntityInstances { get; set; }

        [JsonProperty("__opacity")]
        public AppBuildId Opacity { get; set; }

        [JsonProperty("seed")]
        public AppBuildId Seed { get; set; }

        [JsonProperty("layerDefUid")]
        public AppBuildId LayerDefUid { get; set; }

        [JsonProperty("__pxTotalOffsetX")]
        public AppBuildId PxTotalOffsetX { get; set; }

        [JsonProperty("__cWid")]
        public AppBuildId CWid { get; set; }

        [JsonProperty("pxOffsetY")]
        public AppBuildId PxOffsetY { get; set; }

        [JsonProperty("__tilesetDefUid")]
        public AppBuildId TilesetDefUid { get; set; }

        [JsonProperty("gridTiles")]
        public CustomCommands GridTiles { get; set; }

        [JsonProperty("intGrid")]
        public CustomCommands IntGrid { get; set; }
    }

    public partial class Level
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> LevelRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public LevelProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class LevelProperties
    {
        [JsonProperty("__neighbours")]
        public CustomCommands Neighbours { get; set; }

        [JsonProperty("__bgColor")]
        public AppBuildId BgColor { get; set; }

        [JsonProperty("worldX")]
        public AppBuildId WorldX { get; set; }

        [JsonProperty("externalRelPath")]
        public AppBuildId ExternalRelPath { get; set; }

        [JsonProperty("useAutoIdentifier")]
        public AppBuildId UseAutoIdentifier { get; set; }

        [JsonProperty("iid")]
        public AppBuildId Iid { get; set; }

        [JsonProperty("bgColor")]
        public AppBuildId PropertiesBgColor { get; set; }

        [JsonProperty("bgPos")]
        public WorldLayout PropertiesBgPos { get; set; }

        [JsonProperty("pxHei")]
        public AppBuildId PxHei { get; set; }

        [JsonProperty("worldY")]
        public AppBuildId WorldY { get; set; }

        [JsonProperty("__bgPos")]
        public Icon BgPos { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("__smartColor")]
        public AppBuildId SmartColor { get; set; }

        [JsonProperty("fieldInstances")]
        public CustomCommands FieldInstances { get; set; }

        [JsonProperty("pxWid")]
        public AppBuildId PxWid { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("bgPivotY")]
        public AppBuildId BgPivotY { get; set; }

        [JsonProperty("bgPivotX")]
        public AppBuildId BgPivotX { get; set; }

        [JsonProperty("layerInstances")]
        public CustomCommands LayerInstances { get; set; }

        [JsonProperty("bgRelPath")]
        public AppBuildId BgRelPath { get; set; }

        [JsonProperty("worldDepth")]
        public AppBuildId WorldDepth { get; set; }
    }

    public partial class LevelBgPosInfos
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> LevelBgPosInfosRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public LevelBgPosInfosProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class LevelBgPosInfosProperties
    {
        [JsonProperty("cropRect")]
        public RequiredBiomeValues CropRect { get; set; }

        [JsonProperty("scale")]
        public RequiredBiomeValues Scale { get; set; }

        [JsonProperty("topLeftPx")]
        public RequiredBiomeValues TopLeftPx { get; set; }
    }

    public partial class NeighbourLevel
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> NeighbourLevelRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public NeighbourLevelProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class NeighbourLevelProperties
    {
        [JsonProperty("levelIid")]
        public AppBuildId LevelIid { get; set; }

        [JsonProperty("levelUid")]
        public AppBuildId LevelUid { get; set; }

        [JsonProperty("dir")]
        public AppBuildId Dir { get; set; }
    }

    public partial class TableOfContentEntry
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TableOfContentEntryRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TableOfContentEntryProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TableOfContentEntryProperties
    {
        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("instancesData")]
        public CustomCommands InstancesData { get; set; }

        [JsonProperty("instances")]
        public CustomCommands Instances { get; set; }
    }

    public partial class Tile
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TileRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TileProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TileProperties
    {
        [JsonProperty("t")]
        public AppBuildId T { get; set; }

        [JsonProperty("d")]
        public RequiredBiomeValues D { get; set; }

        [JsonProperty("px")]
        public RequiredBiomeValues Px { get; set; }

        [JsonProperty("a")]
        public AppBuildId A { get; set; }

        [JsonProperty("f")]
        public AppBuildId F { get; set; }

        [JsonProperty("src")]
        public RequiredBiomeValues Src { get; set; }
    }

    public partial class TileCustomMetadata
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TileCustomMetadataRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TileCustomMetadataProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TileCustomMetadataProperties
    {
        [JsonProperty("tileId")]
        public AppBuildId TileId { get; set; }

        [JsonProperty("data")]
        public AppBuildId Data { get; set; }
    }

    public partial class TilesetDef
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TilesetDefRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TilesetDefProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TilesetDefProperties
    {
        [JsonProperty("cachedPixelData")]
        public AppBuildId CachedPixelData { get; set; }

        [JsonProperty("__cHei")]
        public AppBuildId CHei { get; set; }

        [JsonProperty("pxHei")]
        public AppBuildId PxHei { get; set; }

        [JsonProperty("customData")]
        public CustomCommands CustomData { get; set; }

        [JsonProperty("tagsSourceEnumUid")]
        public AppBuildId TagsSourceEnumUid { get; set; }

        [JsonProperty("uid")]
        public AppBuildId Uid { get; set; }

        [JsonProperty("padding")]
        public AppBuildId Padding { get; set; }

        [JsonProperty("enumTags")]
        public CustomCommands EnumTags { get; set; }

        [JsonProperty("pxWid")]
        public AppBuildId PxWid { get; set; }

        [JsonProperty("__cWid")]
        public AppBuildId CWid { get; set; }

        [JsonProperty("spacing")]
        public AppBuildId Spacing { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }

        [JsonProperty("savedSelections")]
        public RequiredBiomeValues SavedSelections { get; set; }

        [JsonProperty("tags")]
        public RequiredBiomeValues Tags { get; set; }

        [JsonProperty("embedAtlas")]
        public WorldLayout EmbedAtlas { get; set; }

        [JsonProperty("relPath")]
        public AppBuildId RelPath { get; set; }

        [JsonProperty("tileGridSize")]
        public AppBuildId TileGridSize { get; set; }
    }

    public partial class TilesetRect
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TilesetRectRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TilesetRectProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TilesetRectProperties
    {
        [JsonProperty("tilesetUid")]
        public AppBuildId TilesetUid { get; set; }

        [JsonProperty("h")]
        public AppBuildId H { get; set; }

        [JsonProperty("x")]
        public AppBuildId X { get; set; }

        [JsonProperty("y")]
        public AppBuildId Y { get; set; }

        [JsonProperty("w")]
        public AppBuildId W { get; set; }
    }

    public partial class TocInstanceData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> TocInstanceDataRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public TocInstanceDataProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class TocInstanceDataProperties
    {
        [JsonProperty("worldX")]
        public AppBuildId WorldX { get; set; }

        [JsonProperty("widPx")]
        public AppBuildId WidPx { get; set; }

        [JsonProperty("worldY")]
        public AppBuildId WorldY { get; set; }

        [JsonProperty("heiPx")]
        public AppBuildId HeiPx { get; set; }

        [JsonProperty("fields")]
        public DefaultOverride Fields { get; set; }

        [JsonProperty("iids")]
        public Defs Iids { get; set; }
    }

    public partial class World
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("required")]
        public List<string> WorldRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("properties")]
        public WorldProperties Properties { get; set; }

        [JsonProperty("type")]
        public List<ForcedRefsType> Type { get; set; }
    }

    public partial class WorldProperties
    {
        [JsonProperty("worldGridWidth")]
        public AppBuildId WorldGridWidth { get; set; }

        [JsonProperty("iid")]
        public AppBuildId Iid { get; set; }

        [JsonProperty("worldGridHeight")]
        public AppBuildId WorldGridHeight { get; set; }

        [JsonProperty("worldLayout")]
        public WorldLayout WorldLayout { get; set; }

        [JsonProperty("defaultLevelWidth")]
        public AppBuildId DefaultLevelWidth { get; set; }

        [JsonProperty("levels")]
        public CustomCommands Levels { get; set; }

        [JsonProperty("defaultLevelHeight")]
        public AppBuildId DefaultLevelHeight { get; set; }

        [JsonProperty("identifier")]
        public AppBuildId Identifier { get; set; }
    }

    public enum ForcedRefsType { Boolean, Integer, Null, Number, Object, String };

    public enum CustomCommandsType { Array, Null };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ForcedRefsTypeConverter.Singleton,
                CustomCommandsTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ForcedRefsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ForcedRefsType) || t == typeof(ForcedRefsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boolean":
                    return ForcedRefsType.Boolean;
                case "integer":
                    return ForcedRefsType.Integer;
                case "null":
                    return ForcedRefsType.Null;
                case "number":
                    return ForcedRefsType.Number;
                case "object":
                    return ForcedRefsType.Object;
                case "string":
                    return ForcedRefsType.String;
            }
            throw new Exception("Cannot unmarshal type ForcedRefsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ForcedRefsType)untypedValue;
            switch (value)
            {
                case ForcedRefsType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case ForcedRefsType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case ForcedRefsType.Null:
                    serializer.Serialize(writer, "null");
                    return;
                case ForcedRefsType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case ForcedRefsType.Object:
                    serializer.Serialize(writer, "object");
                    return;
                case ForcedRefsType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type ForcedRefsType");
        }

        public static readonly ForcedRefsTypeConverter Singleton = new ForcedRefsTypeConverter();
    }

    internal class CustomCommandsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CustomCommandsType) || t == typeof(CustomCommandsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return CustomCommandsType.Array;
                case "null":
                    return CustomCommandsType.Null;
            }
            throw new Exception("Cannot unmarshal type CustomCommandsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CustomCommandsType)untypedValue;
            switch (value)
            {
                case CustomCommandsType.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case CustomCommandsType.Null:
                    serializer.Serialize(writer, "null");
                    return;
            }
            throw new Exception("Cannot marshal type CustomCommandsType");
        }

        public static readonly CustomCommandsTypeConverter Singleton = new CustomCommandsTypeConverter();
    }
}
