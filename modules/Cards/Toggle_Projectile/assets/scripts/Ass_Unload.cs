function Module_Card_Toggle_Projectile::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Toggle_Projectile.getAssetId());

}
