function Module_Card_Mushroom::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Mushroom.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Rain_Drops.getAssetId());

}
