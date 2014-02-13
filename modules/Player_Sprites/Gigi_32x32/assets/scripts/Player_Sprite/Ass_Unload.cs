function Module_Player_Sprite_Gigi_32x32::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Stand_Down.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Stand_Left.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Stand_Right.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Stand_Up.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Run_Down.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Run_Left.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Run_Right.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Gigi_32x32_Run_Up.getAssetId());

}
