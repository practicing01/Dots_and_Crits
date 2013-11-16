function Module_Card_Kingless_Hill::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Kingless_Hill.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Font.getAssetId());

}
