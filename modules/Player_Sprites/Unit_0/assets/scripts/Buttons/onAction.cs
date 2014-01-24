function Module_Player_Sprite_Unit_0_Gui_Menu::onAction(%this)
{

if (%this.String_Action$="Move")
{

Module_Player_Sprite_Unit_0.Bool_Waiting_For_Move=true;

}
else if (%this.String_Action$="Config")
{

Module_Player_Sprite_Unit_0.Gui_Button_Gui_Menu_Config(%this.Sprite_Player_Parent);

}
else if (%this.String_Action$="Emote")
{

Module_Player_Sprite_Unit_0.Gui_Button_Gui_Menu_Emote(%this.Sprite_Player_Parent);

}
else if (%this.String_Action$="Attack")
{

Module_Player_Sprite_Unit_0.Bool_Waiting_For_Attack=true;

}

}
