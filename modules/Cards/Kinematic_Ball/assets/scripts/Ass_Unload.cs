function Module_Card_Kinematic_Ball::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Kinematic_Ball.getAssetId());

}
