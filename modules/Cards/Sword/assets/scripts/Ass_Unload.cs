function Module_Card_Sword::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Icon.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Sword.getAssetId());

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

Scene_Dots_and_Crits.deleteJoint(%Player_Object.Scene_Object_Anchor.Joint_ID);

Scene_Dots_and_Crits.deleteJoint(%Player_Object.Sprite_Sword.Joint_ID);

}

}
