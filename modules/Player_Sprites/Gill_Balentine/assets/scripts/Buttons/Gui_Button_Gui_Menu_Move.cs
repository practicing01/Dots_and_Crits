function Module_Player_Sprite_Gill_Balentine::Gui_Button_Gui_Menu_Move(%this,%Vector_2D_World_Point)
{

commandToServer('Relay_Module_Function',Module_Player_Sprite_Gill_Balentine,"Action_Move",%Vector_2D_World_Point);

}
