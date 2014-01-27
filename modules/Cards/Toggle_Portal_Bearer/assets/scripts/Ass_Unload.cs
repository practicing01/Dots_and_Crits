function Module_Card_Toggle_Portal_Bearer::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Portal_Bearer.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Portal_Bearer_Projectile.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Portal_Bearer_Portal.getAssetId());

}
