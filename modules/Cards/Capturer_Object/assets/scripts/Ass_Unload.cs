function Module_Card_Capturer_Object::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Capturer_Object.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Font.getAssetId());

}
