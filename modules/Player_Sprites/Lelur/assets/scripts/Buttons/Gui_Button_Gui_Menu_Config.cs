function Module_Player_Sprite_Lelur::Gui_Button_Gui_Menu_Config(%this,%Sprite_Player_Parent)
{

%this.Gui_Menu_Config=%this.Gui_Menu_Config_Create(%Sprite_Player_Parent);

Window_Dots_and_Crits.add(%this.Gui_Menu_Config);

}
