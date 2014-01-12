function Module_Map_PvP_Construct::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile_0.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Floor_Tile_1.getAssetId());

}
