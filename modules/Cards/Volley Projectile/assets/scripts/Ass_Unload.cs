function Module_Card_Volley_Projectile::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Volley_Projectile.getAssetId());

}
