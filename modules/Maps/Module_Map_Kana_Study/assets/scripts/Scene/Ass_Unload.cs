function Module_Map_Kana_Study::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Image_Asset_ID_Hiragana.getAssetId());

AssetDatabase.releaseAsset(%this.Image_Asset_ID_Katakana.getAssetId());

}
