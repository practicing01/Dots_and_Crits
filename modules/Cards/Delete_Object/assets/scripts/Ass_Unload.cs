function Module_Card_Delete_Object::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

}
