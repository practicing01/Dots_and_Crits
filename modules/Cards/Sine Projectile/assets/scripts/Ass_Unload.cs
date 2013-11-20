function Module_Card_Sine_Projectile::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Sine_Projectile.getAssetId());

}
