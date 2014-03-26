function Module_Card_LiquidFun_Object::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_LiquidFun_Object.getAssetId());

}
