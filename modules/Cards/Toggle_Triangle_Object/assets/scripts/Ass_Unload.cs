function Module_Card_Toggle_Triangle_Object::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Triangle_Object.getAssetId());

}