function Module_Player_Sprite_Unit_0::Gui_Button_Gui_Menu_Emote(%this,%Sprite_Player_Parent)
{

%Script_Object_Player_Sprite=%Sprite_Player_Parent.Script_Object_Parent;

commandToServer('Relay_Module_Function',Module_Player_Sprite_Unit_0,"Action_Emote",
%Script_Object_Player_Sprite.Asset_ID_Animation_Emote);

}
