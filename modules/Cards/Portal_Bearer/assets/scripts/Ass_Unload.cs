function Module_Card_Portal_Bearer::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Portal_Bearer.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Portal_In.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Portal_In_Projectile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Portal_Out.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Portal_Out_Projectile.getAssetId());

}
