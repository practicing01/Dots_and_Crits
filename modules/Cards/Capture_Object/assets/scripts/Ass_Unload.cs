function Module_Card_Capture_Object::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Capture_Object_Spawner.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Capture_Object_Capture_Object.getAssetId());

}
