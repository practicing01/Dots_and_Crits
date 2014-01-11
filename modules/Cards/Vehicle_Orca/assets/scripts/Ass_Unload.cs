function Module_Card_Vehicle_Orca::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Vehicle_Orca.getAssetId());

}
