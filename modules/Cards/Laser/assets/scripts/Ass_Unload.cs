function Module_Card_Laser::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Laser.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Laser_Beam.getAssetId());

}
