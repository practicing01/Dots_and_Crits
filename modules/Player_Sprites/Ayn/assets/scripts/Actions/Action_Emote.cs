function Module_Player_Sprite_Ayn::Action_Emote(%this,%Player_Information,%Asset_ID_Animation_Emote)
{

%Player_Information.Asset_ID_Animation_Emote=%Asset_ID_Animation_Emote;

%Player_Information.Sprite.playAnimation(%Asset_ID_Animation_Emote);

}
