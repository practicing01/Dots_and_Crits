function Module_Card_Toggle_Wall_Tile::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Wall_Tile.getAssetId());

}
